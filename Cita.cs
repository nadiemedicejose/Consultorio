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

            var registros = from valor in dbConsultorio.BuscarCita(Convert.ToInt32(txtCitaID.Text))
                            select valor;

            foreach (var cita in registros)
            {
                txtDentista.Text = cita.Dentista;
                txtEspecialidad.Text = cita.Especialidad;
                txtPaciente.Text = cita.Paciente;
                txtDescripcion.Text = cita.Descripción;
            }
        }
    }
}
