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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Modulos_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            subModuloUsuarios subUsuarios  = new subModuloUsuarios();  
            subUsuarios.Visible = true;
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Login form2 = new Login();

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubmodulosAtencionCliente win = new SubmodulosAtencionCliente();
            win.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH();
            submodulosRRHH.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();

            sucursales.Show();
            this.Hide();
        }
    }
}
