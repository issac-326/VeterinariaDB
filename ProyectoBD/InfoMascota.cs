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
    public partial class InfoMascota : Form
    {
        int idMascota = 0;
        public InfoMascota(int id)
        {
            InitializeComponent();
            cargarVacunas();
            cargarEnfermedades();
            idMascota = id;
            int idExpediente = 0;
            idExpediente = ObtenerIdExpediente("Expedientes", idMascota);
            Class.Crud objetoCrud = new Class.Crud();
            String cadenaResponsables = "SELECT Personas.Primer_Nombre AS Nombre, Personas.Primer_Apellido AS Apellido, Personas.DNI AS Dni FROM Mascotas  JOIN Responsables_Mascotas ON Mascotas.Id = Responsables_Mascotas.Id_Mascota JOIN Personas ON Responsables_Mascotas.Id_Persona = Personas.Id WHERE Mascotas.Id = " + idMascota + ";";
            objetoCrud.mostrarData(mostradorResponsables, cadenaResponsables);
            String cadenaVacunas = $"SELECT Mascotas.Nombre AS NombreMascota, Productos.Nombre AS NombreVacuna, Vacunas_Aplicadas.Fecha AS FechaAplicacion FROM Carnet_Vacunas JOIN Mascotas ON Carnet_Vacunas.Id_Macota = Mascotas.Id JOIN Vacunas_Aplicadas ON Carnet_Vacunas.Id = Vacunas_Aplicadas.Id_Carnet JOIN Productos ON Vacunas_Aplicadas.Id_Vacuna = Productos.Id JOIN Formas_Farmaceuticas ON Productos.Id_Forma = Formas_Farmaceuticas.Id WHERE Mascotas.Id = {idMascota} AND Formas_Farmaceuticas.Id = 3;";
            objetoCrud.mostrarData(mostradorVacunas, cadenaVacunas);
            String cadenaConsultas = $"SELECT Consultas.Diagnostico, Consultas.Fecha, Consultas.Hora, Consultas.Sintomas, Personas.Primer_Nombre AS Responsable FROM  Consultas JOIN Personas ON Consultas.Id_Persona_Ingreso = Personas.Id where Consultas.Id_Expediente = {idExpediente};";
            objetoCrud.mostrarData(mostradorConsultas, cadenaConsultas);
            String cadenaEnfermedades = $"SELECT Enfermedades_Bases.Id_Expediente AS Numero_Expediente, Enfermedades.Nombre AS Nombre from Enfermedades_Bases JOIN Enfermedades ON Enfermedades_Bases.Id_Enfermedad = Enfermedades.Id  WHERE Enfermedades_Bases.Id_Expediente = {idExpediente};";
            objetoCrud.mostrarData(mostradorEnfermedades, cadenaEnfermedades);
        }

        private void InfoMascota_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idPersona = 0;
            String tabla = "Responsables_Mascotas";
            idPersona = ObtenerIdDni(txtDni.Text);
            Class.Crud objetoCrud = new Class.Crud();


            String cadena = $"{idPersona}, {idMascota}";
            objetoCrud.guardar(tabla, cadena);
            String cadenaResponsables = "SELECT Personas.Primer_Nombre AS Nombre, Personas.Primer_Apellido AS Apellido, Personas.DNI AS Dni FROM Mascotas  JOIN Responsables_Mascotas ON Mascotas.Id = Responsables_Mascotas.Id_Mascota JOIN Personas ON Responsables_Mascotas.Id_Persona = Personas.Id WHERE Mascotas.Id = " + idMascota + ";";
            objetoCrud.mostrarData(mostradorResponsables, cadenaResponsables);

        }

        private int ObtenerIdDni(String dni)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Personas where DNI = '" + dni + "';";
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
                MessageBox.Show("Error DNI persona: " + ex.Message);
            }
            return id;
        }

        public void cargarVacunas()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT * FROM Productos where Id_Forma = 3;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selVacuna.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selVacuna.Items.Add(reader["Nombre"].ToString());
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

        public void cargarEnfermedades()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT * FROM Enfermedades;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEnferdad.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selEnferdad.Items.Add(reader["Nombre"].ToString());
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

        private int ObtenerIdVacuna(String tabla, String nombreVacuna)
        {
            int idVacuna = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM " + tabla + " where Nombre = '" + nombreVacuna + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idVacuna = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idVacuna: " + ex.Message);
            }
            return idVacuna;
        }
        private int ObtenerIdExpediente(String tabla, int mascota)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM " + tabla + " where Id_Mascota = " + mascota + ";";
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
                MessageBox.Show("Error idVacuna: " + ex.Message);
            }
            return id;
        }


        private int ObtenerIdCarnet(String tabla, int id)
        {
            int idVacuna = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM " + tabla + " where Id_Macota = '" + id + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idVacuna = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idVacuna: " + ex.Message);
            }
            return idVacuna;
        }

        private void btnAgregarVacuna_Click(object sender, EventArgs e)
        {
            int idVacuna = 0;
            int idCarnet = 0;
            String tabla = "Vacunas_Aplicadas";
            idVacuna = ObtenerIdVacuna("Productos", selVacuna.SelectedItem.ToString());
            idCarnet = ObtenerIdCarnet("Carnet_Vacunas", idMascota);
            Class.Crud objetoCrud = new Class.Crud();


            String cadena = $"{idVacuna}, {idCarnet}, GETDATE()";
            objetoCrud.guardar(tabla, cadena);
            String cadenaVacunas = $"SELECT Mascotas.Nombre AS NombreMascota, Productos.Nombre AS NombreVacuna, Vacunas_Aplicadas.Fecha AS FechaAplicacion FROM Carnet_Vacunas JOIN Mascotas ON Carnet_Vacunas.Id_Macota = Mascotas.Id JOIN Vacunas_Aplicadas ON Carnet_Vacunas.Id = Vacunas_Aplicadas.Id_Carnet JOIN Productos ON Vacunas_Aplicadas.Id_Vacuna = Productos.Id JOIN Formas_Farmaceuticas ON Productos.Id_Forma = Formas_Farmaceuticas.Id WHERE Mascotas.Id = {idMascota} AND Formas_Farmaceuticas.Id = 3;";
            objetoCrud.mostrarData(mostradorVacunas, cadenaVacunas);
        }

        private void btnAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            int idEnfermedad = 0;
            int idExpediente = 0;
            String tabla = "Enfermedades_Bases";
            idEnfermedad = ObtenerIdEnfermedad("Enfermedades", selEnferdad.SelectedItem.ToString());
            idExpediente = ObtenerIdExpediente("Expedientes", idMascota);
            Class.Crud objetoCrud = new Class.Crud();


            String cadena = $"{idExpediente}, {idEnfermedad}";
            objetoCrud.guardar(tabla, cadena);
            String cadenaEnfermedades = $"SELECT Enfermedades_Bases.Id_Expediente AS Numero_Expediente, Enfermedades.Nombre AS Nombre from Enfermedades_Bases JOIN Enfermedades ON Enfermedades_Bases.Id_Enfermedad = Enfermedades.Id  WHERE Enfermedades_Bases.Id_Expediente = {idExpediente};";
            objetoCrud.mostrarData(mostradorEnfermedades, cadenaEnfermedades);
        }

        private int ObtenerIdEnfermedad(String tabla, String enfermedad)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM " + tabla + " where Id_Enfermedad = " + enfermedad + ";";
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
                MessageBox.Show("Error idVacuna: " + ex.Message);
            }
            return id;
        }

        private void mostradorResponsables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
