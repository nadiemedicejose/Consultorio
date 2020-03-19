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

            var registros = from valor in dbConsultorio.BuscarEspecialidad(Convert.ToInt32(txtEspecialidadID.Text))
                            select valor;
            foreach (var especialidad in registros)
            {
                txtEspecialidad.Text = especialidad.Especialidad;
            }

            //if (registros.Any())
            //{
                
            //} else
            //{
            //    MessageBox.Show("No se encontró ninguna especialidad con el ID: " + txtEspecialidadID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
