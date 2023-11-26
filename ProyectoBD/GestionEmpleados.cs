using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class GestionEmpleados : Form
    {
        public GestionEmpleados()
        {
            InitializeComponent();
        }



        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH();
            submodulosRRHH.Show();
            this.Hide();
        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
