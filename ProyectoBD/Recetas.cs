using ProyectoBD.SQLConexion;
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

namespace ProyectoBD
{
    public partial class Recetas : Form
    {
        private List<string> permisos;
        private int idSucursal;
        private int idPersona;
        String tabla = "Detalles_Facturas";
        public Recetas(List<string> permisos, int idSucursal, int idPersona)
        {
            InitializeComponent();
            cargarMedicamentos();

            Class.Crud objetoCrud = new Class.Crud();
            this.permisos = permisos;
            this.idPersona = idPersona;
            this.idSucursal = idSucursal;
        }
        public void cargarMedicamentos()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Productos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            nombreMedicamento.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                nombreMedicamento.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos: " + ex.Message);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private int ObtenerId(String nombreTabla, String busqueda, String nombre)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM " + nombreTabla + " where " + busqueda + " = '" + nombre + "';";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            id = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idMedicmento: " + ex.Message);
            }
            return id;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Class.Crud objetoCrud = new Class.Crud();

            int idMedicamento = 0;

            int cantidad = Convert.ToInt32(txtCantidad.Text);
            if (nombreMedicamento.SelectedItem != null)
            {
                idMedicamento = ObtenerId("Productos", "Nombre", nombreMedicamento.SelectedItem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Farmacia form2 = new Farmacia(permisos, idSucursal, idPersona);

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }
    }
}
