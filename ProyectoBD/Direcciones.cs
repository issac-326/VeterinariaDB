using ProyectoBD.Class;
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
    public partial class Direcciones : Form
    {
        String tabla = "Direcciones";
        public Direcciones()
        {
            InitializeComponent();
            CargarDatos();
            CargarCiudades();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView2.Rows[e.RowIndex];

                txtReferencia.Text = filaSeleccionada.Cells["Referencia"].Value.ToString();
                txtCiudad.Text = filaSeleccionada.Cells["Ciudad"].Value.ToString();

            }
        }

        private void CargarDatos()
        {
            Crud crud = new Crud();

            string instruccion = "\r\nSELECT d.Referencia, c.Nombre AS Ciudad, dep.Nombre AS Departamento FROM Direcciones d\r\nINNER JOIN Ciudades c ON d.Id_Ciudad = c.Id\r\nINNER JOIN Departamentos dep ON c.Id_Departamento = dep.Id";

            crud.mostrarData(dataGridView2, instruccion);

        }

        private void CargarCiudades()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT c.Nombre AS Ciudad, d.Nombre AS Departamento  FROM Ciudades c\r\nINNER JOIN Departamentos d ON c.Id_Departamento = d.Id;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtCiudad.Items.Clear();

                            while (reader.Read())
                            {

                                string infoCiudad = $"{reader["Ciudad"]}, {reader["Departamento"]}";

                                txtCiudad.Items.Add($"{infoCiudad}");
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ciudades: " + ex.Message);
            }
        }


        private int ObtenerIdCiudad(String nombreCiudad)
        {
            int idCiudad = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Ciudades WHERE Nombre = '" + nombreCiudad + "'; ";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idCiudad = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }                
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idDireccion: " + ex.Message);
            }
            return idCiudad;
        }

        private string ObtenerCiudad(string selectedItem)
        {
            string[] partes = selectedItem.Split(',');
            if (partes.Length > 0)
            {
                return partes[0];
            }
            else
            {

                return selectedItem;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();

            sucursales.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idCiudad = 0;
            int idDepartamento = 0;


            Class.Crud objetoCrud = new Class.Crud();

            try
            {
                string ciudad = ObtenerCiudad(txtCiudad.SelectedItem.ToString());

                if (txtCiudad.SelectedItem != null)
                {
                    idCiudad = ObtenerIdCiudad(ciudad);
                }
                String cadena = $"'{txtReferencia.Text}', '{idCiudad}'";

                objetoCrud.guardar(tabla, cadena);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarDatos();

        }
    }
}
