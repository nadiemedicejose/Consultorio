using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    class Dentist
    {
        conexionConsultorioDBDataContext dbConsultorio = new conexionConsultorioDBDataContext();

        public void MostrarDentistas(DataGridView dgvDentistas)
        {
            var registros = dbConsultorio.DentistasMostrarTodos();
            dgvDentistas.DataSource = registros;
        }

        public void BuscarDentista(TextBox txtDentistaID, TextBox txtNombre, TextBox txtDireccion, TextBox txtTelefono, TextBox txtEdad, ComboBox cmbEspecialidad)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            cmbEspecialidad.SelectedItem = null;

            if (txtDentistaID.Text != "")
            {
                var registros = dbConsultorio.BuscarDentista(Convert.ToInt32(txtDentistaID.Text)).ToList();

                if (registros.Any())
                {
                    foreach (var dentista in registros)
                    {
                        txtNombre.Text = dentista.Nombre;
                        txtDireccion.Text = dentista.Dirección;
                        txtTelefono.Text = dentista.Teléfono;
                        txtEdad.Text = dentista.Edad.ToString();
                        cmbEspecialidad.SelectedItem = dentista.Especialidad;
                    }
                }
                else
                {
                    MessageBox.Show("No existe el dentista con ID: " + txtDentistaID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDentistaID.Text = "";
                    txtDentistaID.Focus();
                }
            }
            else
            {
                MessageBox.Show("No ingresaste un ID de dentista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistaID.Focus();
            }
        }

        public void ObtenerEspecialidades(ComboBox cmbEspecialidad)
        {
            cmbEspecialidad.Items.Clear();
            var registros = from valor in dbConsultorio.Especialidades
                            select valor;
            foreach (var especialidad in registros)
            {
                cmbEspecialidad.Items.Add(especialidad.NombreEspecialidad);
            }
        }
    }
}
