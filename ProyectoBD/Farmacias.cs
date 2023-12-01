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
    public partial class Farmacias : Form
    {
        String tabla = "Farmacias";
        public Farmacias()
        {
            InitializeComponent();
            CargarDatos();
            CargarEmpleados();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView2.Rows[e.RowIndex];

                txtEncargado.Text = filaSeleccionada.Cells["DNI"].Value.ToString();

            }
        }
        private void CargarDatos()
        {
            Crud crud = new Crud();

            string instruccion = "SELECT f.Id AS Farmacia, p.Primer_Nombre, p.Primer_Apellido, p.DNI FROM Farmacias f\r\nINNER JOIN Empleados e ON f.Id_Encargado = e.id\r\nINNER JOIN Personas p ON e.Id_Persona = p.Id;";

            crud.mostrarData(dataGridView2, instruccion);

        }

        private void CargarEmpleados()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT p.Primer_Nombre, p.Primer_Apellido, p.DNI FROM Empleados e\r\nINNER JOIN Personas p ON e.Id_Persona = p.Id;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtEncargado.Items.Clear();

                            while (reader.Read())
                            {
                                // Concatenar Primer_Nombre, Segundo_Nombre y DNI
                                string infoEmpleado = $"{reader["Primer_Nombre"]} {reader["Primer_Apellido"]} - {reader["DNI"]}";


                                txtEncargado.Items.Add($"{infoEmpleado}");
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
        }

        private int ObtenerIdEmpleado(String DNI)
        {
            int idEmpleado = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    string query = "SELECT e.Id FROM Empleados e INNER JOIN Personas p ON e.Id_Persona = p.Id WHERE p.DNI LIKE '" + DNI + "'; ";
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
                MessageBox.Show("Error idEmpleado: " + ex.Message);
            }
            return idEmpleado;
        }

        private string ObtenerDNI(string selectedItem)
        {
            // Aquí puedes implementar la lógica para obtener el primer nombre de la cadena
            // Por ejemplo, puedes dividir la cadena por espacio y tomar el primer elemento
            string[] partes = selectedItem.Split(' ');
            if (partes.Length > 0)
            {
                return partes[3];
            }
            else
            {
                // Si no hay partes, devolver la cadena completa
                return selectedItem;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();

            sucursales.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int idEmpleado = 0;

            Class.Crud objetoCrud = new Class.Crud();

            try
            {
                string dni = ObtenerDNI(txtEncargado.SelectedItem.ToString());

                if (txtEncargado.SelectedItem != null)
                {
                    idEmpleado = ObtenerIdEmpleado(dni); ;
                }
                String cadena = $"{idEmpleado}";

                objetoCrud.guardar(tabla, cadena);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEncargado.Text = null;
        }
    }
}
