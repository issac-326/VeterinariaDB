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
        private List<string> permisos;
        private int idSucursal;
        public Modulos(List<string> permisos, int idSucursal)
        {
            InitializeComponent();
            this.permisos = permisos;
            this.idSucursal = idSucursal;
            btnAtencion.Enabled = false;
            btnFacturas.Enabled = false;
            btnFarmacia.Enabled = false;
            btnInfoPersonal.Enabled = false;
            btnInformacion.Enabled = false;
            btnRHH.Enabled = false;
            btnSucursal.Enabled = false;
            btnUsuarios.Enabled = false;
            btnInfoPersonal.Enabled = false;


            foreach (string permiso in permisos)
            {
                switch (permiso)
                {
                    case "Informacion de la Empresa":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnInformacion.Enabled = true;
                        break;

                    case "Sucursales":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnSucursal.Enabled = true;
                        break;

                    case "Recursos Humanos":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnRHH.Enabled = true;
                        break;

                    case "Farmacia":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnFarmacia.Enabled = true;
                        break;

                    case "Atencion al Cliente":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnAtencion.Enabled = true;
                        break;

                    case "Facturas":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnFacturas.Enabled = true;
                        break;

                    case "Usuarios del Sistema":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnUsuarios.Enabled = true;
                        break;

                    case "Informacion Personal":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnInfoPersonal.Enabled = true;
                        break;
                    case "Todos":
                        MessageBox.Show("Felicidades usted puede editar: " + permiso + "");
                        btnAtencion.Enabled = true;
                        btnFacturas.Enabled = true;
                        btnFarmacia.Enabled = true;
                        btnInfoPersonal.Enabled = true;
                        btnInformacion.Enabled = true;
                        btnRHH.Enabled = true;
                        btnSucursal.Enabled = true;
                        btnUsuarios.Enabled = true;
                        btnInfoPersonal.Enabled = true;
                        break;
                    default:
                        // Manejar el caso por defecto si el permiso no coincide con ninguno de los casos anteriores.
                        break;
                }
            }
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
            Login login = new Login();  
            login.Visible = true;
            this.Hide();
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
