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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBD
{
    public partial class GestionMascotas : Form
    {
        String tabla = "Mascotas";
        public GestionMascotas()
        {
            InitializeComponent();
            cargarGeneros();
            cargarEstados();
            cargarEspecies();
        }


        public void cargarEspecies()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Especies";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEspecie.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selEspecie.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las especies: " + ex.Message);
            }
        }

        public void cargarEstados()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Estados";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEstado.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selEstado.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados: " + ex.Message);
            }
        }
        public void cargarGeneros()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Generos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selGenero.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selGenero.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los generos: " + ex.Message);
            }
        }

        private int ObtenerIdEspecie(String nombreEspecie)
        {
            int idEspecie = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Especies where Nombre = '" + nombreEspecie + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idEspecie = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idEspecie: " + ex.Message);
            }
            return idEspecie;
        }

        private int ObtenerIdEstado(String nombreEstado)
        {
            int idEstado = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Estados where Nombre = '" + nombreEstado + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idEstado = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idEstado: " + ex.Message);
            }
            return idEstado;
        }

        private int ObtenerIdGenero(String nombreGenero)
        {
            int idGenero = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Generos where Nombre = '" + nombreGenero + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idGenero = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idGenero: " + ex.Message);
            }
            return idGenero;
        }

        private int ObtenerIdRaza(string nombreRaza)
        {
            int idRaza = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Razas where Nombre = '" + nombreRaza + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idRaza = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idRaza: " + ex.Message);
            }
            return idRaza;
        }

        private void selEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la especie seleccionada
            string especieSeleccionada = selEspecie.SelectedItem.ToString();

            selRaza.SelectedItem = null;

            // Cargar las razas correspondientes a la especie seleccionada
            CargarRazasPorEspecie(especieSeleccionada);
        }

        void CargarRazasPorEspecie(String especieSeleccionada)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Razas WHERE Id_Especie = (SELECT Id FROM Especies WHERE Nombre = '" + especieSeleccionada + "')";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selRaza.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selRaza.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los generos: " + ex.Message);
            }
        }
        private void GestionMascotas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idEspecie = -1;
            int idGenero = 1;
            int idRaza = 1;
            int idEstado = 1;
            Class.Crud objetoCrud = new Class.Crud();
            if (selEspecie.SelectedItem != null)
            {
                idEspecie = ObtenerIdEspecie(selEspecie.SelectedItem.ToString());
            }
            if (selRaza.SelectedItem != null)
            {
                idRaza = ObtenerIdRaza(selRaza.SelectedItem.ToString());
            }
            if (selGenero.SelectedItem != null)
            {
                idGenero = ObtenerIdGenero(selGenero.SelectedItem.ToString());
            }
            if (selEstado.SelectedItem != null)
            {
                idEstado = ObtenerIdEstado(selEstado.SelectedItem.ToString());
            }
            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            int esterilizado = txtEsterilizacion.Checked ? 1 : 0;
            int agresivo = txtAgresivo.Checked ? 1 : 0;

            String cadena = $"'{txtNombre.Text}', '{txtCaracteristicas.Text}', '{fechaFormateada}', {esterilizado}, {agresivo},'{txtPeso.Text}', '{txtTamano.Text}', {idEspecie}, {idRaza}, {idGenero}, {idEstado}";
            objetoCrud.guardar(tabla, cadena);
        }
    }
}
