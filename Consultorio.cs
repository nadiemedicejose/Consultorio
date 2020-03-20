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
    public partial class Consultorio : Form
    {
        public Consultorio()
        {
            InitializeComponent();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            Citas objCitas = new Citas();
            objCitas.Show();
            this.Hide();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes objPacientes = new Pacientes();
            objPacientes.Show();
            this.Hide();
        }

        private void btnDentistas_Click(object sender, EventArgs e)
        {
            Dentistas objDentistas = new Dentistas();
            objDentistas.Show();
            this.Hide();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades objEspecialidades = new Especialidades();
            objEspecialidades.Show();
            this.Hide();
        }

        private void CerrarForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
