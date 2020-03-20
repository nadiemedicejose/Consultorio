using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    class Patient
    {
        conexionConsultorioDBDataContext dbConsultorio = new conexionConsultorioDBDataContext();

        public void MostrarPacientes(DataGridView dgvPacientes)
        {
            var registros = dbConsultorio.PacientesMostrarTodos();
            dgvPacientes.DataSource = registros;
        }

        public void BuscarPaciente(TextBox txtPacienteID, TextBox txtNombre, TextBox txtDireccion, TextBox txtTelefono)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            if (txtPacienteID.Text != "")
            {
                var registros = dbConsultorio.BuscarPaciente(Convert.ToInt32(txtPacienteID.Text)).ToList();

                if (registros.Any())
                {
                    foreach (var paciente in registros)
                    {
                        txtNombre.Text = paciente.Nombre;
                        txtDireccion.Text = paciente.Dirección;
                        txtTelefono.Text = paciente.Teléfono;
                    }
                }
                else
                {
                    MessageBox.Show("No existe el paciente con ID: " + txtPacienteID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPacienteID.Text = "";
                    txtPacienteID.Focus();
                }
            } else
            {
                MessageBox.Show("No ingresaste un ID de paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPacienteID.Focus();
            }
        }
    }
}
