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
            txtPacienteID.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objPaciente.BuscarPaciente(txtPacienteID, txtNombre, txtDireccion, txtTelefono);
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo puedes ingresar números en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void CerrarForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Consultorio objConsultorio = new Consultorio();
            objConsultorio.Show();
            this.Hide();
        }
    }
}
