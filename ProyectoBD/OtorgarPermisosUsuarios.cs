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
    public partial class OtorgarPermisosUsuarios : Form
    {
        private List<string> permisos;
        private int idSucursal;
        public OtorgarPermisosUsuarios()
        {
            InitializeComponent();
            txtUsuario.Focus();
            mostrarPermisosUsuarios();
            CargarDatosPermisosUsuarios();
        }

        private void OtorgarPermisosUsuarios_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatosPermisosUsuarios()
        {
            CrudCitas objetoCrud = new Class.CrudCitas();
            // Define la instrucción SQL para seleccionar datos.
            string instruccionSql = "EXEC ObtenerDatosPermisosUsuarios";

            // Llama al método mostrarData para cargar y mostrar los datos en el DataGridView
            objetoCrud.mostrarData(dgvPermisosUsuarios, instruccionSql);
        }

        private int ObtenerIdPermiso(String nombrePermiso)
        {
            int idPermiso = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Permisos where Nombre = '" + nombrePermiso + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idPermiso = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ID del Permiso de Usuario: " + ex.Message);
            }
            return idPermiso;
        }

        private int ObtenerIdUsuario(String nombreUsuario)
        {
            int idUsuario = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Usuarios where Usuario = '" + nombreUsuario + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idUsuario = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ID del Usuario: " + ex.Message);
            }
            return idUsuario;
        }

        ///Funcion para mostrar los permisos existentes
        public void mostrarPermisosUsuarios()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de las mascotas
                    string query = "SELECT Nombre FROM Permisos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selPermisos.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selPermisos.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Permisos de los Usuarios: " + ex.Message);
            }
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            int idPermiso = 1;
            String tablaU = "Usuarios_Permisos";

            int idUsuario = ObtenerIdUsuario(txtUsuario.Text);
            Class.Crud objetoCrud = new Class.Crud();

            if (selPermisos.SelectedItem != null)
            {
                idPermiso = ObtenerIdPermiso(selPermisos.SelectedItem.ToString());
            }

            String cadenaU = $"{idUsuario}, {idPermiso}";
            objetoCrud.guardar(tablaU, cadenaU);
            CargarDatosPermisosUsuarios();
        }

        private void btnLimpiarUsuarios_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            selPermisos.Text = "";
            txtUsuario.Focus();
        }

        private void dgvPermisosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPermisosUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUsuario.Text = dgvPermisosUsuarios.CurrentRow.Cells[1].Value.ToString();
                selPermisos.Text = dgvPermisosUsuarios.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvPermisosUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el código desde la fila seleccionada
                DataGridViewRow selectedRow = dgvPermisosUsuarios.SelectedRows[0];
                int idCodigoU = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                int idPermiso = 1;
                String tablaU = "Usuarios_Permisos";

                int idUsuario = ObtenerIdUsuario(txtUsuario.Text);
                Class.Crud objetoCrud = new Class.Crud();

                if (selPermisos.SelectedItem != null)
                {
                    idPermiso = ObtenerIdPermiso(selPermisos.SelectedItem.ToString());
                }


                String cadena = $"Id_Usuario = '{idUsuario}', Id_Permiso = {idPermiso}";
                objetoCrud.editar(tablaU, cadena, idCodigoU);
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar modificar.");
            }
            CargarDatosPermisosUsuarios();
        }

        ///Boton eliminar permisos de usuarios
        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvPermisosUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el código desde la fila seleccionada
                DataGridViewRow selectedRow = dgvPermisosUsuarios.SelectedRows[0];
                int idCodigo = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                String tabla = "Usuarios_Permisos";

                Class.Crud objetoCrud = new Class.Crud();

                objetoCrud.eliminar(tabla, idCodigo);
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar eliminar.");
            }
            CargarDatosPermisosUsuarios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(permisos, idSucursal);
            modulos.Visible = true;
            this.Hide();
        }
    }
}
