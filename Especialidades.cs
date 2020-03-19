using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Especialidades : Form
    {
        Especialidad objEspecialidad = new Especialidad();
        public Especialidades()
        {
            InitializeComponent();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            objEspecialidad.MostrarEspecialidades(dgvEspecialidades);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objEspecialidad.BuscarEspecialidad(txtEspecialidadID, txtEspecialidad);
        }
    }
}
