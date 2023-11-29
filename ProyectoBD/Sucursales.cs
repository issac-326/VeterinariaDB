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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Security.Principal;
using System.Security.Cryptography.Xml;

namespace ProyectoBD
{
    public partial class Sucursales : Form
    {
        private string permiso;
        String tablaSucursales = "Sucursales";
        String tablaDirecciones = "Direcciones";

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
            CargarEstados();
            CargarCiudades();
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
                txtFarmacia.Text = filaSeleccionada.Cells["Farmacia"].Value.ToString();
                txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                txtIdDireccion.Text = filaSeleccionada.Cells["IdDireccion"].Value.ToString();
            }

        }


        private void CargarDatos()
        {
            Crud crud = new Crud();

            string instruccion = "SELECT s.Id, s.Codigo, s.Nombre, s.Correo, d.Id AS IdDireccion, d.Referencia AS Direccion, es.Nombre AS Estado, \r\nf.Id AS Farmacia FROM Sucursales s \r\nINNER JOIN Empresas e ON s.Id_Empresa = e.Id\r\nINNER JOIN Direcciones d ON s.Id_Direccion = d.Id\r\nINNER JOIN Estados_Sucursal es ON s.Id_Estado = es.Id\r\nINNER JOIN Farmacias f ON s.Id_Farmacia = f.Id;";

            crud.mostrarData(dataGridView2, instruccion);

        }


        private void CargarCiudades()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    string query = "SELECT c.Nombre AS Ciudad, d.Nombre AS Departamento FROM Ciudades c\r\nINNER JOIN Departamentos d ON c.Id_Departamento = d.Id;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            txtCiudad.Items.Clear();


                            while (reader.Read())
                            {

                                string infoDirrecion = $"{reader["Ciudad"]}, {reader["Departamento"]}";

                                txtCiudad.Items.Add($"{infoDirrecion}");
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



        private int ObtenerIdCiudad(String nombreCiudad)
        {
            int idCiudad = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Ciudades WHERE Nombre LIKE '" + nombreCiudad + "%';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idCiudad = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idCiudad: " + ex.Message);
            }
            return idCiudad;
        }


        private string ObtenerReferencia(string selectedItem)
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



        private void button1_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(permiso);

            modulos.Show();
            this.Close();

        }

        private void txtDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();

            int idEstado = 0;
            int idCiudad = 0;

            string referencia = ObtenerReferencia(txtCiudad.SelectedItem.ToString());


            if (txtCiudad != null)
            {
                idCiudad = ObtenerIdCiudad(referencia);
            }
            if (txtEstado != null)
            {
                idEstado = ObtenerIdEstado(txtEstado.SelectedItem.ToString());
            }

            string consulta = $"BEGIN TRY\tBEGIN TRAN INSERT INTO Farmacias(codigo) VALUES (NULL); DECLARE @Id_Farmacia AS INT SET @Id_Farmacia = (SELECT IDENT_CURRENT('Farmacias') AS Id); INSERT INTO Direcciones(Referencia, Id_Ciudad) VALUES ('{txtDireccion.Text}', {idCiudad}); DECLARE @Id_Direccion AS INT SET @Id_Direccion = (SELECT IDENT_CURRENT('Direcciones') AS Id); INSERT INTO Sucursales(Codigo, Nombre, Correo, Id_Empresa, Id_Direccion, Id_Estado, Id_Farmacia) VALUES ('{txtCodigo}', '{txtNombre}', '{txtCorreo}', 1, @Id_Direccion, {idEstado}, @Id_Farmacia); \tCOMMIT \tPRINT('SE INSERTO LA SUCURSAL'); END TRY BEGIN CATCH ROLLBACK PRINT('NO SE INSERTO LA SUCURSAL'); END CATCH";


            SqlCommand comando = new SqlCommand(consulta, objectConexion.establecerConexion());
            comando.ExecuteNonQuery();
            objectConexion.cerrarConexion();
            CargarDatos();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            txtNombre.Text = null;
            txtCorreo.Text = null;
            txtDireccion.Text = null;
            txtEstado.Text = null;
            txtFarmacia.Text = null;
            txtCiudad.Text = null;
            txtId.Text = null;
            txtIdDireccion.Text = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int idEstado = 0;
            int idDireccion = Convert.ToInt32(txtIdDireccion.Text);
            int idSucursal = Convert.ToInt32(txtId.Text);



            Class.Crud objetoCrud = new Class.Crud();

            try
            {
                //string referencia = ObtenerReferencia(txtCiudad.SelectedItem.ToString());

                if (txtEstado != null)
                {
                    idEstado = ObtenerIdEstado(txtEstado.SelectedItem.ToString());
                }

                String cadena = $"Codigo = '{txtCodigo.Text}', Nombre = '{txtNombre.Text}', Correo = '{txtCorreo.Text}', Id_Empresa = '{1}', Id_Estado = {idEstado}";
                String cadena2 = $"Referencia = '{txtDireccion.Text}'";
                objetoCrud.editar(tablaSucursales, cadena, idSucursal);
                objetoCrud.editar(tablaDirecciones, cadena2, idDireccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            CargarDatos();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtFarmacia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

