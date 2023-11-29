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
        ///Variable de instancia
        int identificador = 0;
        String tabla1 = "Citas";
        String tabla2 = "Estados_Citas";
        public Citas(int id)
        {
            InitializeComponent();
            ///Asignamos el valor a la variable de instancia.
            identificador = id;
            cargarTipoEstados();
            cargarMascotas();
            cargarEmpleados();
            CargarDatos();

            //Contador para que al hacer clic en el datGridView se muestren los datos en los TextBox.
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
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
                    string query = "SELECT Id FROM Tipo_Estados where Nombre = '" + nombreEstado + "';";
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

        private void Citas_Load(object sender, EventArgs e)
        {

        }

        //Metodo para mostrar los datos de la tabla
        private void CargarDatos()
        {
            CrudCitas objetoCrud = new Class.CrudCitas();
            // Define la instrucción SQL para seleccionar datos.
            string instruccionSql = "    SELECT est.Id AS 'ID', pe.Primer_Nombre AS 'Nombre del Empleado', ci.Fecha, ma.Nombre AS 'Nombre de la Mascota', ti.Nombre AS 'Estado', est.FechaInicio AS 'Fecha Inicial del Estado', est.FechaFinal AS 'Fecha Final del Estado' FROM Estados_Citas est INNER JOIN Tipo_estados ti ON est.Id_Tipo_Estado = ti.Id INNER JOIN Citas ci ON ci.Id = est.Id_Cita INNER JOIN Mascotas ma ON ma.Id = ci.Id_Mascota INNER JOIN Empleados em ON em.Id = ci.Id_Empleado INNER JOIN Personas pe ON pe.Id = em.Id_Persona WHERE ci.Id_Mascota =" + identificador + "";

            // Llama al método mostrarData para cargar y mostrar los datos en el DataGridView
            objetoCrud.mostrarData(dataGridView1, instruccionSql);
        }

        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            int idTipoEstado = -1;
            int idEmpleado = 1;
            CrudCitas objetoCrud1 = new Class.CrudCitas();
            if (selEstadoCitas.SelectedItem != null)
            {
                idTipoEstado = ObtenerIdTipoEstado(selEstadoCitas.SelectedItem.ToString());
            }
            if (selEmpleadoCitas.SelectedItem != null)
            {
                idEmpleado = ObtenerIdEmpleado(selEmpleadoCitas.SelectedItem.ToString());
            }

            DateTime fechaSeleccionada = txtFechaCita.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");


            String cadenaC = $"'{fechaFormateada}', {idEmpleado}, {identificador}";
            objetoCrud1.guardarCitas(tabla1, cadenaC);


            // Ahora, obtén el ID de la cita recién insertada para luego insertar en la tabla Estados_Citas.
            int idCita = objetoCrud1.ObtenerIdCitaReciente();

            // Luego, inserta en la tabla citas_estados
            if (idCita != -1)
            {

                // Insertar los datos en la tabla Citas_Estados
                String cadenaE = $"'{txtFechaInicio.Text}','{txtFechaFinal.Text}', {idCita}, {idTipoEstado}";
                objetoCrud1.guardarCitas(tabla2, cadenaE);
            }

            //Refrescar en el DataGreedView.
            CargarDatos();


        }


        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            //Para limpiar los ComboBox
            txtFechaCita.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFinal.Text = "";
            selEmpleadoCitas.Text = "";
            selEstadoCitas.Text = "";
            selMascotaCita.Text = "";
        }

        private void btnModificarCitas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el código desde la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int idCodigo = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Resto del código de tu lógica de modificación
                int idCitaE = 1;
                int idTipoEstado = -1;
                int idEmpleado = 1;
                CrudCitas objetoCrud1 = new Class.CrudCitas();

                if (selEstadoCitas.SelectedItem != null)
                {
                    idTipoEstado = ObtenerIdTipoEstado(selEstadoCitas.SelectedItem.ToString());
                }

                if (selEmpleadoCitas.SelectedItem != null)
                {
                    idEmpleado = ObtenerIdEmpleado(selEmpleadoCitas.SelectedItem.ToString());
                }
                if (selEmpleadoCitas.SelectedItem != null)
                {
                    idCitaE = ObtenerIdCitaPorNombreEmpleado(selEmpleadoCitas.SelectedItem.ToString());
                }

                DateTime fechaSeleccionada = txtFechaCita.Value;
                // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

                // Modificar en la tabla Citas
                String cadenaC = $"Fecha = '{fechaFormateada}', Id_Empleado = {idEmpleado}, Id_Mascota = {identificador}";
                objetoCrud1.editarCitas("Citas", cadenaC, idCitaE);


                // Modificar en la tabla Estados de las Citas
                String cadenaE = $" FechaInicio= '{txtFechaInicio.Text}',FechaFinal= '{txtFechaFinal.Text}', Id_Cita = {idCitaE}, Id_Tipo_Estado= {idTipoEstado}";
                objetoCrud1.editarCitas("Estados_Citas", cadenaE, idCodigo);

            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar modificar.");
            }

            //Refrescar en el DataGreedView.
            CargarDatos();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            selEmpleadoCitas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFechaCita.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value).ToString();
            selMascotaCita.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            selEstadoCitas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFechaInicio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtFechaFinal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlMascota ctrlMascotas = new ControlMascota(identificador);
            ctrlMascotas.Show();
            this.Hide();
        }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaCita_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

