using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    class Appointment
    {
        conexionConsultorioDBDataContext dbConsultorio = new conexionConsultorioDBDataContext();

        public void MostrarCitas(DataGridView dgvCitas)
        {
            var registros = dbConsultorio.CitasMostrarTodos();
            dgvCitas.DataSource = registros;
        }

        public void BuscarCita(TextBox txtCitaID, TextBox txtDentista, TextBox txtEspecialidad, TextBox txtPaciente, TextBox txtDescripcion)
        {
            txtDentista.Text = "";
            txtEspecialidad.Text = "";
            txtPaciente.Text = "";
            txtDescripcion.Text = "";

            if (txtCitaID.Text != "")
            {
                var registros = dbConsultorio.BuscarCita(Convert.ToInt32(txtCitaID.Text)).ToList();

                if (registros.Any())
                {
                    foreach (var cita in registros)
                    {
                        txtDentista.Text = cita.Dentista;
                        txtEspecialidad.Text = cita.Especialidad;
                        txtPaciente.Text = cita.Paciente;
                        txtDescripcion.Text = cita.Descripción;
                    }
                } else
                {
                    MessageBox.Show("No existe la cita con ID: " + txtCitaID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCitaID.Text = "";
                    txtCitaID.Focus();
                }
            }
            else
            {
                MessageBox.Show("No ingresaste un ID de cita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCitaID.Focus();
            }

        }
    }
}
