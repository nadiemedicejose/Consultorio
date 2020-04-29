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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Consultorio objRegresar = new Consultorio();
            objRegresar.Show();
            this.Hide();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConsultorioTodosDataSet.CitasMostrarTodos' table. You can move, or remove it, as needed.
            this.CitasMostrarTodosTableAdapter.Fill(this.CitasTodasDS.CitasMostrarTodos);

            this.reportViewer1.RefreshReport();
        }
    }
}
