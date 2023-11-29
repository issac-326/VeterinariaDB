using ProyectoBD.SQLConexion;
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
        int idTipo = 0;
        int idMascota = 0;
        public RegistroConsulta(int idCita, int idMascota)
        {
            InitializeComponent();
            CargarEmpleado();
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
            String cadenaReceta = $"{idMedicamento}, {ultimaConsulta}, {txtDosis.Text}";
            objetoCrud.guardar("Recetas_Medicamentos", cadenaReceta);

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
            // Formatea la fecha en el formato deseado en este caso solo ocupamos año, mes, dia
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
            DateTime horaSelecionada = txtHora.Value;
            // Formato 24H
            string horaFormateada = horaSelecionada.ToString("HH:mm:ss");
            int idMedico = 0;
            int idResponsable = 0;

            if (selMedico.SelectedItem != null)
            {
                idMedico = ObtenerIdEmpleado(selMedico.SelectedItem.ToString());
            }
            idResponsable = ObtenerIdEmpleado(txtResponsable.Text);

            Class.Crud objetoCrud = new Class.Crud();
            if (idCita == 0)
            {
                String cadenaSin = $"'{fechaFormateada}', '{horaFormateada}', '{txtSintoma.Text}', '{txtDiagnostico.Text}', {null}, {idMedico}, {idResponsable}, {idTipo}, {txtExpendiente.Text}";
                objetoCrud.guardar("Consultas", cadenaSin);
            }
            else
            {
                String cadena = $"'{fechaFormateada}', '{horaFormateada}', '{txtSintoma.Text}', '{txtDiagnostico.Text}', {idCita}, {idMedico}, {idResponsable}, {idTipo}, {txtExpendiente.Text}";
                objetoCrud.guardar("Consultas", cadena);
            }




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
    }

}

