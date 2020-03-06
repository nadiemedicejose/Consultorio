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
    public partial class Form1 : Form
    {
        Dentistas objDentista = new Dentistas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTodos_txt_Click(object sender, EventArgs e)
        {
            string resultados = objDentista.MostrarTodosTxtBox();
            txtDentistas.Text = resultados;
        }

        private void btnMostrarTodos_dgv_Click(object sender, EventArgs e)
        {
            var resultados = objDentista.MostrarTodosDGV();
            dgvDentistas.DataSource = resultados;
        }
    }
}
