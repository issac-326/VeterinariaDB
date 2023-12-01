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
    public partial class Farmacia : Form
    {
        private List<string> permisos;
        private int idSucursal;
        private int idPersona;
        public Farmacia(List<string> permisos, int idSucursal, int idPersona)
        {
            InitializeComponent();
            this.permisos = permisos;
            this.idSucursal = idSucursal;
            this.idPersona = idPersona;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Registros form2 = new Registros(permisos, idSucursal, idPersona);

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Recetas form2 = new Recetas(permisos, idSucursal, idPersona);

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(permisos, idSucursal, idPersona);
            modulos.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
