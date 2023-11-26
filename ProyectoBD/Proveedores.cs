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
    public partial class Proveedores : Form
    {
        String tabla = "Proveedores";
        int idDepartamento = 0;
        public Proveedores()
        {
            InitializeComponent();
            cargarDepartamento();
            cargarCiudad();
            Class.Crud objetoCrud = new Class.Crud();
        }
        public void cargarDepartamento()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de formas farmaceuticas
                    string query = "SELECT Nombre FROM Departamentos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            departamento.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                departamento.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las formas: " + ex.Message);
            }
        }
        public void cargarCiudad()
        {
            if (departamento.SelectedItem != null)
            {
                idDepartamento = ObtenerIdDepartamento(departamento.SelectedItem.ToString());
            }
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de formas farmaceuticas
                    string query = "SELECT Nombre FROM Ciudades WHERE Id = '" + idDepartamento + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxCuidad.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxCuidad.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las formas: " + ex.Message);
            }
        }
        private int ObtenerIdDepartamento(String nombreDepartamento)
        {
            int idDepartamento = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM Departamentos where Nombre = '" + nombreDepartamento + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idDepartamento = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idForma: " + ex.Message);
            }
            return idDepartamento;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Registros form2 = new Registros();

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verificar si se ha seleccionado algo en el ComboBox
            if (departamento.SelectedItem != null)
            {
                comboBoxCuidad.Items.Clear(); 
                cargarCiudad();
            }
        }
        private int ObtenerIdDireccion(String buscarReferencia)
        {
            int idDireccion = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM Direcciones where Referencia = '" + buscarReferencia + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idDireccion = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idDireccion: " + ex.Message);
            }
            return idDireccion;
        }
        private int ObtenerIdCiudad(String nombre)
        {
            int idCiudad = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM Ciudades where Nombre = '" + nombre + "';";
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

        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            //guardamos la direccion del proveedor 
            int idCiudad = -1;
            int idDireccion = -1;

            Class.Crud objetoCrud = new Class.Crud();
            if (comboBoxCuidad.SelectedItem != null)
            {
                idCiudad = ObtenerIdCiudad(comboBoxCuidad.SelectedItem.ToString());
            }

            String cadena = $"'{txtReferencia.Text}', '{idCiudad}' ";
            objetoCrud.guardar("Direcciones", cadena);
            //obtenemos el id de la direccion que creamos
            idDireccion = ObtenerIdDireccion(txtReferencia.Text);

            //creamos el proveedor 
            String cadena2 = $"'{txtNombre.Text}', '{txtCorreo.Text}', '{idDireccion}'";
            objetoCrud.guardar(tabla, cadena2);
        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            comboBoxCuidad.SelectedIndex = -1;
            departamento.SelectedIndex = -1;
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtReferencia.Text = "";
        }
    }

}
