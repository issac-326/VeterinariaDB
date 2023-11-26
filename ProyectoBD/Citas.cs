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

    public partial class Citas : Form
    {
        String tabla1 = "Citas";
        String tabla2 = "Estados_Citas";

        public Citas()
        {
            InitializeComponent();
            cargarTipoEstados();
            cargarMascotas();
            cargarEmpleados();
            CargarDatos();

            //Contador para que al hacer clic en el datGridView se muestren los datos en los TextBox.
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        ///Estados de las citas
        public void cargarTipoEstados()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de los estados
                    string query = "SELECT Nombre FROM Tipo_estados";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEstadoCitas.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selEstadoCitas.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados de las citas: " + ex.Message);
            }
        }

        private int ObtenerIdTipoEstado(String nombreEstado)
        {
            int idTipoEstado = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Tipo_estados where Nombre = '" + nombreEstado + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idTipoEstado = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idTipoEstado: " + ex.Message);
            }
            return idTipoEstado;
        }

        ///Mascotas de las citas 
        public void cargarMascotas()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de las mascotas
                    string query = "SELECT Nombre FROM Mascotas";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selMascotaCita.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selMascotaCita.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Mascotas: " + ex.Message);
            }
        }

        private int ObtenerIdMascotas(String nombreMascota)
        {
            int idMascota = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Mascotas where Nombre = '" + nombreMascota + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idMascota = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ver la Mascota: " + ex.Message);
            }
            return idMascota;
        }

        ///Empleados de las citas
        public void cargarEmpleados()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de los Empleados
                    string query = "select Personas.Primer_Nombre as Nombre from Personas INNER JOIN Empleados ON Personas.Id = Empleados.Id_Persona";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEmpleadoCitas.Items.Clear();

                            // Agregar cada nombre del empleado al ComboBox
                            while (reader.Read())
                            {
                                selEmpleadoCitas.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Empleados: " + ex.Message);
            }
        }

        private int ObtenerIdEmpleado(String nombreEmpleado)
        {
            int idEmpleado = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id del empleado 
                    string query = "select Empleados.Id as Id from Empleados INNER JOIN Personas ON Empleados.Id_Persona = Personas.Id WHERE personas.Primer_Nombre = '" + nombreEmpleado + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idEmpleado = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ver el Empleado: " + ex.Message);
            }
            return idEmpleado;
        }

<<<<<<< Updated upstream
=======
        //Codigo Empleado para traer el Id de la citas y luego utilizarlo para actualizar los Estados_Citas
        private int ObtenerIdCitaPorNombreEmpleado(string nombreEmpleado)
        {
            int idCitaE = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();

            try
            {
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Utilizamos JOIN para relacionar las tablas Empleados y Citas
                    string query = "SELECT Citas.Id " +
                                   "FROM Citas " +
                                   "INNER JOIN Empleados ON Citas.Id_Empleado = Empleados.Id " +
                                   "INNER JOIN Personas ON Empleados.Id_Persona = Personas.Id " +
                                   "WHERE Personas.Primer_Nombre = '" + nombreEmpleado + "';";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read()) // Verificar si hay datos antes de intentar leer
                            {
                                // Obtener el valor del ID
                                idCitaE = Convert.ToInt32(reader["Id"]);
                            }
                        }
                    }
                }

                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la Cita por nombre de Empleado: " + ex.Message);
            }

            return idCitaE;
        }

>>>>>>> Stashed changes
        private void Citas_Load(object sender, EventArgs e)
        {

        }

        //Metodo para mostrar los datos de la tabla
        private void CargarDatos()
        {
            CrudCitas objetoCrud = new Class.CrudCitas();
            // Define la instrucción SQL para seleccionar datos.
            string instruccionSql = "EXEC ObtenerDatosCitas;";

            // Llama al método mostrarData para cargar y mostrar los datos en el DataGridView
            objetoCrud.mostrarData(dataGridView1, instruccionSql);
        }

        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            int idTipoEstado = -1;
            int idEmpleado = 1;
            int idMascota = 1;
            CrudCitas objetoCrud1 = new Class.CrudCitas();
            if (selEstadoCitas.SelectedItem != null)
            {
                idTipoEstado = ObtenerIdTipoEstado(selEstadoCitas.SelectedItem.ToString());
            }
            if (selMascotaCita.SelectedItem != null)
            {
                idMascota = ObtenerIdMascotas(selMascotaCita.SelectedItem.ToString());
            }
            if (selEmpleadoCitas.SelectedItem != null)
            {
                idEmpleado = ObtenerIdEmpleado(selEmpleadoCitas.SelectedItem.ToString());
            }

            DateTime fechaSeleccionada = txtFechaCita.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");


            String cadenaC = $"'{fechaFormateada}', {idEmpleado}, {idMascota}";
            objetoCrud1.guardarCitas(tabla1, cadenaC);


            // Ahora, obtén el ID de la cita recién insertada
            int idCita = objetoCrud1.ObtenerIdCitaReciente();

            // Luego, inserta en la tabla citas_estados
            if (idCita != -1)
            {

                DateTime fechaSeleccionada1 = txtFechaInicio.Value;
                DateTime fechaSeleccionada2 = txtFechaFin.Value;
                // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
                string fechaFormateada1 = fechaSeleccionada1.ToString("yyyy-MM-dd");
                string fechaFormateada2 = fechaSeleccionada2.ToString("yyyy-MM-dd");

                // Insertar los datos en la tabla Citas_Estados
                String cadenaE = $"'{fechaFormateada1}','{fechaFormateada}', {idCita}, {idTipoEstado}";
                objetoCrud1.guardarCitas(tabla2, cadenaE);
            }


        }

        private void Limpiar()
        {
            //Para limpiar los ComboBox
            selEmpleadoCitas.Text = "";
            selEstadoCitas.Text = "";
            selMascotaCita.Text = "";
        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificarCitas_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para que se muestren los datos en los TextBox
            selEmpleadoCitas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFechaCita.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value).ToString();
            selMascotaCita.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            selEstadoCitas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFechaInicio.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value).ToString();
            txtFechaFin.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value).ToString();
        }

        private void txtFechaCita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}