using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoBD.Class;
using System.Reflection;

namespace ProyectoBD
{
    public partial class Sucursales : Form
    {
        String tabla = "Sucursales";

        public Sucursales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarDirecciones();
            CargarEstados();
            CargarEmpleados();
            CargarFarmacias();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView2.Rows[e.RowIndex];

                txtCodigo.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                txtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                txtEstado.Text = filaSeleccionada.Cells["Estado"].Value.ToString();
                txtGerente.Text = filaSeleccionada.Cells["Gerente"].Value.ToString();
                txtFarmacia.Text = filaSeleccionada.Cells["Farmacia"].Value.ToString();
                txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            }

        }


        private void CargarDatos()
        {
            Crud crud = new Crud();

            string instruccion = "SELECT s.Id, s.Codigo, s.Nombre, s.Correo, d.Referencia AS Direccion, es.Nombre AS Estado, \r\nf.Id AS Farmacia, em.Id AS Gerente FROM Sucursales s \r\nINNER JOIN Empresas e ON s.Id_Empresa = e.Id\r\nINNER JOIN Direcciones d ON s.Id_Direccion = d.Id\r\nINNER JOIN Estados_Sucursal es ON s.Id_Estado = es.Id\r\nINNER JOIN Farmacias f ON s.Id_Farmacia = f.Id\r\nINNER JOIN Empleados em ON  s.Id_Gerente = em.Id;\r\n";

            crud.mostrarData(dataGridView2, instruccion);

        }

        private void CargarDirecciones()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    string query = "SELECT d.Referencia, c.Nombre AS Ciudad, dep.Nombre AS Departamento FROM Direcciones d\r\nINNER JOIN Ciudades c ON d.Id_Ciudad = c.Id\r\nINNER JOIN Departamentos dep ON c.Id_Departamento = dep.Id;\r\n";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtDireccion.Items.Clear();


                            while (reader.Read())
                            {

                                string infoDirrecion = $"{reader["Referencia"]}, {reader["Ciudad"]}, {reader["Departamento"]}";

                                txtDireccion.Items.Add($"{infoDirrecion}");
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las direcciones: " + ex.Message);
            }
        }

        private void CargarEstados()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT Nombre FROM Estados_Sucursal;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtEstado.Items.Clear();


                            while (reader.Read())
                            {
                                txtEstado.Items.Add(reader["Nombre"].ToString());
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

        private void CargarFarmacias()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT Id FROM Farmacias;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtFarmacia.Items.Clear();


                            while (reader.Read())
                            {
                                txtFarmacia.Items.Add(reader["Id"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las farmacias: " + ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    string query = "SELECT e.Id, p.Primer_Nombre, p.Primer_Apellido, p.DNI FROM Empleados e\r\nINNER JOIN Personas p ON e.Id_Persona = p.Id;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtGerente.Items.Clear();

                            while (reader.Read())
                            {
                                // Concatenar Primer_Nombre, Segundo_Nombre y DNI
                                string infoEmpleado = $"{reader["Id"]} {reader["Primer_Nombre"]} {reader["Primer_Apellido"]} - {reader["DNI"]}";


                                txtGerente.Items.Add($"{infoEmpleado}");
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

        private int ObtenerIdDireccion(String nombreDireccion)
        {
            int idDireccion = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Direcciones WHERE Referencia LIKE '" + nombreDireccion + "%';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idDireccion = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idDireccion: " + ex.Message);
            }
            return idDireccion;
        }

        private string ObtenerRefrencia(string selectedItem)
        {

            string[] partes = selectedItem.Split(',');
            if (partes.Length > 0)
            {
                return partes[0];
            }
            else
            {
                return selectedItem;
            }
        }

        private int ObtenerIdEstado(String nombreEstado)
        {
            int idEstado = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Estados_Sucursal WHERE Nombre LIKE '" + nombreEstado + "'; ";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idEstado = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idEstado: " + ex.Message);
            }
            return idEstado;
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
                return partes[4];
            }
            else
            {
                // Si no hay partes, devolver la cadena completa
                return selectedItem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos();

            modulos.Show();
            this.Close();

        }

        private void txtDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int idDireccion = 0;
            int idEstado = 0;
            int idEmpleado = 0;
            int idFarmacia = Convert.ToInt32(txtFarmacia.Text);

            Class.Crud objetoCrud = new Class.Crud();

            try
            {
                string referencia = ObtenerRefrencia(txtDireccion.SelectedItem.ToString());
                string dni = ObtenerDNI(txtGerente.SelectedItem.ToString());

                if (txtDireccion.SelectedItem != null)
                {
                    idDireccion = ObtenerIdDireccion(referencia);
                }
                if (txtEstado.SelectedItem != null)
                {
                    idEstado = ObtenerIdEstado(txtEstado.SelectedItem.ToString());
                }
                if (txtGerente.SelectedItem != null)
                {
                    idEmpleado = ObtenerIdEmpleado(dni); ;
                }
                String cadena = $"'{txtCodigo.Text}', '{txtNombre.Text}', '{txtCorreo.Text}','{1}', {idDireccion}, {idEstado},'{idFarmacia}', {idEmpleado}";

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
            txtCodigo.Text = null;
            txtNombre.Text = null;
            txtCorreo.Text = null;
            txtDireccion.Text = null;
            txtEstado.Text = null;
            txtGerente.Text = null;
            txtFarmacia.Text = null;
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            Direcciones direcciones = new Direcciones();

            direcciones.Show();
            this.Hide();
        }

        private void btnFarmacia_Click(object sender, EventArgs e)
        {
            Farmacias farmacias = new Farmacias();

            farmacias.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int idDireccion = 0;
            int idEstado = 0;
            int idEmpleado = 0;
            int idFarmacia = Convert.ToInt32(txtFarmacia.Text);
            int idSucursal = Convert.ToInt32(txtId.Text);


            Class.Crud objetoCrud = new Class.Crud();

            try
            {
                   string referencia = ObtenerRefrencia(txtDireccion.SelectedItem.ToString());
                string dni = ObtenerDNI(txtGerente.SelectedItem.ToString());

                if (txtDireccion.SelectedItem != null)
                {
                    idDireccion = ObtenerIdDireccion(referencia);
                }
                if (txtEstado.SelectedItem != null)
                {
                    idEstado = ObtenerIdEstado(txtEstado.SelectedItem.ToString());
                }
                if (txtGerente.SelectedItem != null)
                {
                    idEmpleado = ObtenerIdEmpleado(dni); ;
                }
                String cadena = $"Codigo = '{txtCodigo.Text}', Nombre = '{txtNombre.Text}', Correo = '{txtCorreo.Text}', Id_Empresa = '{1}', Id_Direccion = {idDireccion}, Id_Estado = {idEstado}, Id_Farmacia = '{idFarmacia}', Id_Gerente = {idEmpleado}";

                objetoCrud.editar(tabla, cadena, idSucursal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            CargarDatos();
        }
    }
}

