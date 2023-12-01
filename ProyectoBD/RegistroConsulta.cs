﻿using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBD
{
    public partial class RegistroConsulta : Form
    {
        int idCita = 0;
        int idTipo = 2;
        int idMascota = 0;
        private List<string> permisos;
        private int idSucursal;
        private int idPersona;
        public RegistroConsulta(int idCita, int idMascota, List<string>permisos, int idSucursal, int idPersona)
        {
            InitializeComponent();
            CargarEmpleado();
            this.permisos = permisos;
            this.idMascota = idMascota;
            int idExpediente = ObtenerIdExpediente("Expedientes", idMascota);
            txtExpendiente.Text = $"{idExpediente}";
            this.idCita = idCita;
            if (idCita == 0)
            {
                this.idTipo = 2;
                txtTipo.Text = "Sin cita";
            }
            else
            {
                this.idTipo = 1;
                txtTipo.Text = "Con cita";
            }
            CargarMedicamentos();

        }

        private void CargarEmpleado()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT DNI AS Medico FROM Empleados JOIN Personas ON Empleados.Id_Persona = Personas.Id JOIN Contratos ON Empleados.Id_Contrato = Contratos.Id JOIN Tipos_Empleados ON Contratos.Id_Tipo = Tipos_Empleados.Id WHERE Tipos_Empleados.Nombre = 'Veterinario';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selMedico.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selMedico.Items.Add(reader["Medico"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los medicos: " + ex.Message);
            }
        }

        private void CargarMedicamentos()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT Nombre FROM Productos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selMedicamento.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selMedicamento.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los medicos: " + ex.Message);
            }
        }

        private void RegistroConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ultimaConsulta = ObtenerIdUltimoRegistro();
            int idMedicamento = 0;
            if (selMedicamento.SelectedItem != null)
            {
                idMedicamento = ObtenerIdMedicamento("Productos", selMedicamento.SelectedItem.ToString());
            }
            Class.Crud objetoCrud = new Class.Crud();
            String cadenaReceta = $"{idMedicamento}, '{txtDosis.Text}', {ultimaConsulta}";
            objetoCrud.guardar("Recetas_Medicamentos", cadenaReceta);
            string instruccion = $"SELECT CM.Id AS Id_Receta, P.Nombre AS Nombre_Medicamento, CM.Dosis, C.Fecha AS Fecha_Consulta, C.Hora AS Hora_Consulta, C.Sintomas, C.Diagnostico FROM Recetas_Medicamentos CM JOIN Consultas C ON CM.Id_Consulta = C.Id JOIN Productos P ON CM.Id_Productos = P.Id WHERE CM.Id_Consulta = {ultimaConsulta}";
            objetoCrud.mostrarData(mostradorMedicamentos, instruccion);
        }

        public int ObtenerIdUltimoRegistro()
        {
            int id = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id
                    string query = "SELECT MAX(Id) AS Id FROM Consultas;";
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
                MessageBox.Show("Error id: " + ex.Message);
            }

            return id;
        }



        private int ObtenerIdMedicamento(String tabla, String medicamento)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM " + tabla + " where Nombre = '" + medicamento + "';";
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
                MessageBox.Show("Error id Medicamentos: " + ex.Message);
            }
            return id;
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
                    string query = "SELECT Id FROM " + tabla + " where Id_Mascota = '" + mascota + "';";
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
                MessageBox.Show("Error id Medicamentos: " + ex.Message);
            }
            return id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = txtFecha.Value;
            // Formatea la fecha en el formato deseado (DATE)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            DateTime horaSeleccionada = txtHora.Value;
            // Formato 24H, y formatea la hora en el formato deseado (TIME)
            string horaFormateada = horaSeleccionada.ToString("HH:mm:ss");

            int idMedico = 0;
            int idResponsable = 0;

            if (selMedico.SelectedItem != null)
            {
                idMedico = ObtenerIdEmpleado(selMedico.SelectedItem.ToString());
            }

            idResponsable = ObtenerIdEmpleado(txtResponsable.Text);
            int idMascotaResponsable = 0;
            idMascotaResponsable = ObtenerIdRelacion(idResponsable);

            Class.Crud objetoCrud = new Class.Crud();

            if (idCita == 0)
            {
                // Insertar nueva consulta
                String cadenaSin = $"'{fechaFormateada}', '{horaFormateada}', '{txtSintoma.Text}', '{txtDiagnostico.Text}', NULL, {idMedico}, {idMascotaResponsable}, {idTipo}, '{txtExpendiente.Text}'";
                objetoCrud.guardar("Consultas", cadenaSin);
            }
            else
            {
                // Actualizar consulta existente
                String cadena = $"'{fechaFormateada}', '{horaFormateada}', '{txtSintoma.Text}', '{txtDiagnostico.Text}', {idCita}, {idMedico}, {idMascotaResponsable}, {idTipo}, '{txtExpendiente.Text}'";
                objetoCrud.guardar("Consultas", cadena);
            }



        }
        private int ObtenerIdRelacion(int idRes)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Responsables_Mascotas where Id_Persona = " + idRes + " AND Id_Mascota = " + idMascota + ";";
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
                MessageBox.Show("Error idEmpleado: " + ex.Message);
            }
            return id;
        }

        private int ObtenerIdEmpleado(string dni)
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
                MessageBox.Show("Error idEmpleado: " + ex.Message);
            }
            return id;
        }

        private void mostradorMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            InfoMascota vista = new InfoMascota(idMascota, permisos, idSucursal, idPersona);
            vista.Show();
            this.Hide();
        }
    }

}

