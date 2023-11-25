﻿using ProyectoBD.Class;
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
        int codigo = 0;

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

            //Modificar en la tabla Citas
            String cadenaC = $" Fecha= '{fechaFormateada}',Id_Empleado= {idEmpleado}, Id_Mascota= {idMascota}";
            objetoCrud1.editarCitas("Citas", cadenaC, codigo);


            //Modificar en la tabla Estados de las Citas
            String cadenaE = $" FechaInicio= '{txtFechaInicio.Text}',FechaFinal= '{txtFechaFinal.Text}',Id_Cita = {codigo}, Id_Tipo_Estado= {idTipoEstado}";
            objetoCrud1.editarCitas("Estados_Citas", cadenaE, codigo);

            //Refrescar en el DataGreedView.
            CargarDatos();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

                //Para que se muestren los datos en los TextBox
                object valorCelda = dataGridView1.CurrentRow.Cells[0].Value;
                codigo = Convert.ToInt32(valorCelda);
                selEmpleadoCitas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtFechaCita.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value).ToString();
                selMascotaCita.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                selEstadoCitas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtFechaInicio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtFechaFinal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               
    }
}
}
