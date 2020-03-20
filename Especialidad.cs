using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    class Especialidad
    {
        conexionConsultorioDBDataContext dbConsultorio = new conexionConsultorioDBDataContext();

        public void MostrarEspecialidades(DataGridView dgvEspecialidades)
        {
            var registros = dbConsultorio.EspecialidadesMostrarTodos();
            dgvEspecialidades.DataSource = registros;
        }

        public void BuscarEspecialidad(TextBox txtEspecialidadID, TextBox txtEspecialidad)
        {
            txtEspecialidad.Text = "";

            if (txtEspecialidadID.Text != "")
            {
                var registros = dbConsultorio.BuscarEspecialidad(Convert.ToInt32(txtEspecialidadID.Text)).ToList();

                if (registros.Any())
                {
                    foreach (var especialidad in registros)
                    {
                        txtEspecialidad.Text = especialidad.Especialidad;
                    }
                }
                else
                {
                    MessageBox.Show("No existe la especialidad con ID: " + txtEspecialidadID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEspecialidadID.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No ingresaste un ID de especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
