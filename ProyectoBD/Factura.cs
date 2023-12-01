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
using ProyectoBD.Class;
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
            CargarDatos();
            //lblEmpresa.Text = null;
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

        private void CargarDatos()
        {
            Crud crud = new Crud();

            string instruccion = "SELECT TOP 1 e.Nombre as Empresa, d.Referencia, c.Nombre AS Ciudad, de.Nombre AS Departamento,\r\ne.Correo_1 AS Correo, e.RTN AS RTNEmpresa, ins.CAI, f.Num_Factura, p.Primer_Nombre, p.Primer_Apellido,\r\nf.Fecha, f.RTN_Cliente AS RTNCliente, f.Impuesto_15, f.Impuesto_18, f.Total FROM Facturas f \r\nINNER JOIN Inscripcion_SAR ins ON f.Id_Inscripcion = ins.Id\r\nINNER JOIN Responsables_Mascotas rm ON f.Id_Cliente = rm.Id\r\nINNER JOIN Personas p ON rm.Id_Persona = p.Id\r\nINNER JOIN Sucursales s ON f.Id_Scursal = s.Id\r\nINNER JOIN Empresas e ON s.Id_Empresa = e.Id\r\nINNER JOIN Direcciones d ON s.Id_Direccion = d.Id\r\nINNER JOIN Ciudades c ON d.Id_Ciudad = c.Id\r\nINNER JOIN Departamentos de ON c.Id_Departamento = d.Id\r\nORDER BY f.Id DESC;";

            crud.mostrarData(dataGridView1, instruccion);

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
            FormularioFactura win = new FormularioFactura(permisos, idSucursal);
            win.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                lblEmpresa.Text = filaSeleccionada.Cells["Empresa"].Value.ToString();
                lblDireccion.Text = filaSeleccionada.Cells["Referencia"].Value.ToString() + ", " + filaSeleccionada.Cells["Ciudad"].Value.ToString() + ", " + filaSeleccionada.Cells["Departamento"].Value.ToString();
                lblCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                lblRtn.Text = filaSeleccionada.Cells["RTNEmpresa"].Value.ToString();
                lblCai.Text = filaSeleccionada.Cells["CAI"].Value.ToString();
                lblNumero.Text = filaSeleccionada.Cells["Num_Factura"].Value.ToString();
                lblCliente.Text = filaSeleccionada.Cells["Primer_Nombre"].Value.ToString() + " " + filaSeleccionada.Cells["Primer_Apellido"].Value.ToString();
                lblFecha.Text = filaSeleccionada.Cells["Fecha"].Value.ToString();
                lblRtnCliente.Text = filaSeleccionada.Cells["RTNCliente"].Value.ToString();
                lblIsv15.Text = filaSeleccionada.Cells["Impuesto_15"].Value.ToString();
                lblIsv18.Text = filaSeleccionada.Cells["Impuesto_18"].Value.ToString();
                lblTotal.Text = filaSeleccionada.Cells["Total"].Value.ToString();

            }
        }
    }
}
