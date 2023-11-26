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
    public partial class Registros : Form
    {
        String tabla = "Registros";
        public Registros()
        {
            InitializeComponent();
            cargarMedicamentos();
            cargarProveedores();
            cargarTipoRegistro();
            Class.Crud objetoCrud = new Class.Crud();
        }
        public void cargarMedicamentos()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Productos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            nombreMedicamento.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                nombreMedicamento.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos: " + ex.Message);
            }
        }
        public void cargarProveedores()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Proveedores";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboProveedores.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboProveedores.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }
        public void cargarTipoRegistro()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Tipo FROM Tipos_Registros";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboTipo.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboTipo.Items.Add(reader["Tipo"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos: " + ex.Message);
            }
        }
        private int ObtenerId(String nombreTabla, String busqueda, String nombre)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Id FROM " + nombreTabla + " where " + busqueda + " = '" + nombre + "';";

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
                MessageBox.Show("Error idMedicmento: " + ex.Message);
            }
            return id;
        }

        private void nombreMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarCitas_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Medicamento form2 = new Medicamento();

            // Mostrar el segundo formulario
            form2.Show();
            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores form2 = new Proveedores();

            // Mostrar el segundo formulario
            form2.Show();
            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void Registros_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            int idMedicamento = 1;
            int idProveedor = 1;
            int idTipo = 1;
            decimal suma = 0;
            decimal total = 0;
            int cantidadTotal = 0;
            decimal precioTotal = 0;


            Class.Crud objetoCrud = new Class.Crud();

            if (nombreMedicamento.SelectedItem != null)
            {
                idMedicamento = ObtenerId("Productos", "Nombre", nombreMedicamento.SelectedItem.ToString());
            }
            if (comboProveedores.SelectedItem != null)
            {
                idProveedor = ObtenerId("Proveedores", "Nombre", comboProveedores.SelectedItem.ToString());
            }
            if (comboTipo.SelectedItem != null)
            {
                idTipo = ObtenerId("Tipos_Registros", "Tipo", comboTipo.SelectedItem.ToString());
            }
            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
            if (EsNumero(txtCantidad.Text) && EsNumero(txtPrecio.Text))
            {
                // Convertir los valores a números enteros
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precio = Convert.ToInt32(txtPrecio.Text);

                // Realizar la suma
                suma = cantidad + precio;
                String cadena = $"'{fechaFormateada}', {cantidad}, {precio}, {suma}, {idTipo},{idMedicamento}, {idProveedor}";
                objetoCrud.guardar(tabla, cadena);
                MessageBox.Show("Se realizo una " + comboTipo.SelectedItem.ToString());

                cantidadTotal = TotalCantidad(cantidad, idTipo);

                total = TotalRegistro(suma, idTipo, cantidadTotal);
                if (idTipo == 1 || idTipo == 3)
                {
                    precioTotal = total / cantidadTotal;
                }
                else
                {
                    precioTotal = ObtenerUltimoRegistro("Precio_Unitario");
                }


                String cadena1 = $"'{fechaFormateada}', {cantidadTotal}, {precioTotal}, {total}, 5 ,{idMedicamento}, {idProveedor}";
                objetoCrud.guardar(tabla, cadena1);

            }
            else
            {
                MessageBox.Show("Por favor ingrese números válidos en los campos Precio y Cantidad.");
            }



        }



        private bool EsNumero(string cadena)
        {
            return int.TryParse(cadena, out _);
        }
        private decimal TotalRegistro(decimal total, int id, int cantidad)
        {
            int factor;
            factor = Obtenerfactor(id);
            decimal TotalR = 0;
            decimal ultimoTotal = ObtenerUltimoRegistro("Total");
            if (id == 1 || id == 3)
            {
                TotalR = ultimoTotal + (total * factor);
            }
            else
            {
                TotalR = ObtenerUltimoRegistro("Precio_Unitario") * (cantidad);

            }
            return TotalR;
        }
        private int TotalCantidad(int total, int id)
        {
            int factor;
            int cantidaT = 0;
            factor = Obtenerfactor(id);
            int ultimoTotal = ObtenerUltimoRegistroCantidad("Cantidad");
            if (ultimoTotal == 0 && factor == -1)
            {
                return cantidaT;
            }
            cantidaT = ultimoTotal + (total * factor);
            return cantidaT;
        }
        private int Obtenerfactor(int id)
        {
            int factor = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma
                    string query = "SELECT Factor FROM Tipos_Registros where Id = " + id + ";";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            factor = Convert.ToInt32(reader["Factor"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error factor: " + ex.Message);
            }
            return factor;
        }

        private decimal ObtenerUltimoRegistro(String nombre)
        {
            decimal dato = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT TOP 1 " + nombre + " FROM Registros where id = '5' ORDER BY Fecha DESC;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                reader.Read(); // Solo necesitas leer la primera fila

                                // Obtener el valor del ID
                                dato = Convert.ToDecimal(reader[nombre]);
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error se encontro dato : " + ex.Message);
            }
            return dato;
        }
        private int ObtenerUltimoRegistroCantidad(String nombre)
        {
            int dato = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT TOP 1 " + nombre + " FROM Registros where id = '5' ORDER BY Fecha DESC;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                reader.Read(); // Solo necesitas leer la primera fila

                                // Obtener el valor del ID
                                dato = Convert.ToInt32(reader[nombre]);
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error se encontro dato : " + ex.Message);
            }
            return dato;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Farmacia form2 = new Farmacia();

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
             comboProveedores.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
            nombreMedicamento.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }
    }
}
