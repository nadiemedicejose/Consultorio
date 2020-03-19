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
    public partial class Pacientes : Form
    {
        Patient objPaciente = new Patient();
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            objPaciente.MostrarPacientes(dgvPacientes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objPaciente.BuscarPaciente(txtPacienteID, txtNombre, txtDireccion, txtTelefono);
        }
    }
}
