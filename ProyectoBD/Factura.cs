using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.SQLConexion;

namespace ProyectoBD
{
    public partial class Factura : Form
    {
        private List<string> permisos;
        private int idSucursal;

        public Factura(List<string> permisos, decimal efectivo, decimal cambio, int idSucursal)
        {
            InitializeComponent();
            this.permisos = permisos;
            this.idSucursal = idSucursal;
            cargarInfo();
        }

        private void cargarInfo()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            // Id Del punto de Emisión
            using (SqlConnection conexion = objectConexion.establecerConexion())
            {
                // Buscar el id
                string query = $"SELECT * FROM Empresas WHERE Id = 1";
                using (SqlCommand comand = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comand.ExecuteReader())
                    {
                        reader.Read();
                        //puntoEmision = Convert.ToInt32(reader["Id"]);
                    }
                }
            }
            objectConexion.cerrarConexion();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormularioFactura win = new FormularioFactura(permisos,idSucursal);
            win.Show();
            this.Hide();        }
    }
}
