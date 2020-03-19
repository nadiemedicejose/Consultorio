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
            var registros = from valor in dbConsultorio.BuscarPaciente(Convert.ToInt32(txtPacienteID.Text))
                            select valor;

            foreach (var paciente in registros)
            {
                txtPacienteID.Text = paciente.PacienteID.ToString();
                txtNombre.Text = paciente.Nombre;
                txtDireccion.Text = paciente.Dirección;
                txtTelefono.Text = paciente.Teléfono;
            }
        }
    }
}
