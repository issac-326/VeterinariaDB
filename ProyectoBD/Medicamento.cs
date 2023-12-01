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
    public partial class Medicamento : Form
    {
        String tabla = "Productos";
        private List<string> permisos;
        public Medicamento(List<string> permisos)
        {
            InitializeComponent();
            cargarFormas();
            Class.Crud objetoCrud = new Class.Crud();
            this.permisos = permisos;

        }

        public Medicamento()
        {
            InitializeComponent();
            cargarFormas();
            Class.Crud objetoCrud = new Class.Crud();

        }

        public void cargarFormas()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de formas farmaceuticas
                    string query = "SELECT Nombre FROM Formas_Farmaceuticas";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            formulaFarmaceutica.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                formulaFarmaceutica.Items.Add(reader["Nombre"].ToString());
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
        private void tipoFormula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Medicamento_Load(object sender, EventArgs e)
        {

        }
        private int ObtenerIdForma(String nombreForma)
        {
            int idForma = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM Formas_Farmaceuticas where Nombre = '" + nombreForma + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idForma = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idForma: " + ex.Message);
            }
            return idForma;
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            int idForma = -1;
            Class.Crud objetoCrud = new Class.Crud();
            Class.Crud objetoCrud1 = new Class.Crud();
            if (formulaFarmaceutica.SelectedItem != null)
            {
                idForma = ObtenerIdForma(formulaFarmaceutica.SelectedItem.ToString());
            }

            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            String cadena = $"'{txtNombre.Text}', '{fechaFormateada}', 0 , '{idForma}' , 1 ";
            objetoCrud.guardar(tabla, cadena);

            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM Productos where Nombre = '"+txtNombre.Text +"';";
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
                MessageBox.Show("Error idMEDICAMENTO: " + ex.Message);
            }


            String cadena1 = $"'{fechaFormateada}', 0 , 0, 0 , 5, '{id}' , NULL ";
            objetoCrud1.guardar("Registros", cadena1);

        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            formulaFarmaceutica.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Registros form2 = new Registros(permisos);

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }
    }
}
