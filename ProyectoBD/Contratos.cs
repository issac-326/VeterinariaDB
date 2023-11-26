using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBD
{
    public partial class Contratos : Form
    {
        String nombreTabla = "Contratos";
        public Contratos()
        {
            InitializeComponent();
            cargarCargos();
            cargarHorarios();
            cargarPeriodoslab();
            cargarPeriodosPago();
            mostrarInfo();

            mostradorContratos.CellDoubleClick += mostradorContratos_CellDoubleClick;

        }

        private void mostradorContratos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que el clic se haya realizado en una fila válida
            {
                DataGridViewRow row = mostradorContratos.Rows[e.RowIndex];

                // Obtenemso el valor del id del selecinado
                int idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

                // Crear e mostrar el nuevo formulario pasando el ID
                BonosDeducciones nuevoFormulario = new BonosDeducciones(idSeleccionado);
                nuevoFormulario.Show();
                this.Hide();
            }
        }

        public void mostrarInfo()
        {
            Class.Crud objetoCrud = new Class.Crud();
            String instruccion = "SELECT Contratos.Id, Fecha_Inicio, Fecha_Final, Periodo_Laboral, Hora_Inicial, Hora_Final, Nombre as Cargo, Salario_Bruto, Salario_Neto, Periodo as Periodo_Pago " +
                                  "FROM Contratos " +
                                  "INNER JOIN Periodos_Laborales ON(Contratos.Id_Periodo_Laboral = Periodos_Laborales.Id)" +
                                  "INNER JOIN Horarios ON(Contratos.Id_Horario = Horarios.Id) " +
                                  "INNER JOIN Tipos_Empleados ON(Contratos.Id_Tipo = Tipos_Empleados.Id)" +
                                  "INNER JOIN Salarios ON(Contratos.Id_Salario = Salarios.Id)" +
                                  "INNER JOIN Periodos_Pago ON (Salarios.Id_Periodo_Pago = Periodos_Pago.Id)";
            objetoCrud.mostrarData(mostradorContratos, instruccion);
        }

        public void cargarCargos()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre  FROM Tipos_Empleados";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxCargos.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxCargos.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cargos");
            }
        }

        public void cargarPeriodoslab()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Periodo_Laboral  FROM Periodos_laborales";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxPeriodoLaboral.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxPeriodoLaboral.Items.Add(reader["Periodo_Laboral"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los periodos laborales");
            }
        }

        public void cargarPeriodosPago()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Periodo  FROM Periodos_Pago";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxPeriodoPago.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxPeriodoPago.Items.Add(reader["Periodo"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los periodos de pago");
            }
        }

        public void cargarHorarios()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Id  FROM Horarios";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxHorario.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxHorario.Items.Add(reader["Id"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los horarios");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH();
            submodulosRRHH.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static int ObtenerId(String nombreTabla, String nombreFiltro, String valorFiltro)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM " + nombreTabla + " WHERE " + nombreFiltro + " = '" + valorFiltro + "';";
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
                MessageBox.Show("Error al encontrar el id de " + nombreTabla);
            }
            return id;
        }

        public int ObtenerIdUltimoRegistro(String nombreTabla)
        {
            int id = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id
                    string query = "SELECT IDENT_CURRENT('" + nombreTabla + "') AS Id;";
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

        /*
        * Metodo para ingresar Nuevo Contrato.
        */
        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            int idPeriodoPago = 0;
            int idPeriodoLab = 0;
            int idHorario = 0;
            int idCargo = 0;
            int idSalario = 0;
            double salarioBruto = Double.Parse(textBoxSalarioBruto.Text);

            Class.Crud objetoCrud = new Class.Crud();
            if (comboBoxPeriodoPago.SelectedItem != null)
            {
                idPeriodoPago = ObtenerId("Periodos_Pago", "Periodo", comboBoxPeriodoPago.SelectedItem.ToString());
            }
            if (comboBoxHorario.SelectedItem != null)
            {
                idHorario = ObtenerId("Horarios", "Id", comboBoxHorario.SelectedItem.ToString());
            }
            if (comboBoxCargos.SelectedItem != null)
            {
                idCargo = ObtenerId("Tipos_Empleados", "Nombre", comboBoxCargos.SelectedItem.ToString());
            }
            if (comboBoxPeriodoLaboral.SelectedItem != null)
            {
                idPeriodoLab = ObtenerId("Periodos_Laborales", "Periodo_Laboral", comboBoxPeriodoLaboral.SelectedItem.ToString());
            }

            DateTime fechaInicio = dateTimePickerFechaI.Value;
            string fechaInicioFormateada = fechaInicio.ToString("yyyy-MM-dd");

            DateTime fechaFin = dateTimePickerFechaFin.Value;
            string fechaFinFormateada = fechaFin.ToString("yyyy-MM-dd");

            //Insertar Salario
            String values = " " + salarioBruto + ", " + idPeriodoPago + " ";
            objetoCrud.guardar("Salarios (Salario_Bruto, Id_Periodo_Pago) ", values);

            //Obtener Id del salario registrado recién
            idSalario = ObtenerIdUltimoRegistro("Salarios");

            //Insertar Contrato
            String values1 = $"'{fechaInicioFormateada}', '{fechaFinFormateada}', {idPeriodoLab}, {idHorario}, {idCargo},{idSalario}";
            objetoCrud.guardar(nombreTabla, values1);

            mostrarInfo();

        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            textBoxSalarioBruto.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH();
            submodulosRRHH.Show();
            this.Hide();
        }

        private void btnModificarCitas_Click(object sender, EventArgs e)
        {

        }
    }
}
