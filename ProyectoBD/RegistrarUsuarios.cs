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
    public partial class RegistrarUsuarios : Form
    {
        public RegistrarUsuarios()
        {
            InitializeComponent();
            mostrarRolesUsuarios();
            CargarDatosUsuarios();
        }

        private void RegistrarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatosUsuarios()
        {
            CrudCitas objetoCrud = new Class.CrudCitas();
            // Define la instrucción SQL para seleccionar datos.
            string instruccionSql = "EXEC ObtenerDatosUsuarios";

            // Llama al método mostrarData para cargar y mostrar los datos en el DataGridView
            objetoCrud.mostrarData(dgvUsuarios, instruccionSql);
        }
        public void mostrarRolesUsuarios()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de las mascotas
                    string query = "SELECT Nombre FROM Roles";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selRoles.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selRoles.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Roles de los Usuarios: " + ex.Message);
            }
        }

        private int ObtenerIdRol(String nombreRol)
        {
            int idRol = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Roles where Nombre = '" + nombreRol + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idRol = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ID del Rol de Usuario: " + ex.Message);
            }
            return idRol;
        }


        private int ObtenerIdDniEmpleado(String dni)
        {
            int id = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT em.Id FROM Empleados em INNER JOIN Personas pe ON em.Id_Persona = pe.Id INNER JOIN Usuarios us ON em.Id = us.Id_Empleado WHERE pe.DNI = '" + dni + "';";
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
                MessageBox.Show("Error DNI persona: " + ex.Message);
            }
            return id;
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            int idRol = 1;
            String tablaU = "Usuarios";

            int idPersona = ObtenerIdDniEmpleado(txtDNIEmpleado.Text);
            Class.Crud objetoCrud = new Class.Crud();

            if (selRoles.SelectedItem != null)
            {
                idRol = ObtenerIdRol(selRoles.SelectedItem.ToString());
            }

            int Activo = txtActivo.Checked ? 1 : 0;

            String cadenaU = $"'{txtUsuario.Text}','{txtContrasenia.Text}','{Activo}', {idPersona}, {idRol}";
            objetoCrud.guardar(tablaU, cadenaU);
            CargarDatosUsuarios();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarUsuarios_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            txtDNIEmpleado.Text = "";
            selRoles.Text = "";
            txtActivo.Checked = false;
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtContrasenia.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtActivo.Checked = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells[3].Value);
                selRoles.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                txtDNIEmpleado.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();

            }


        }

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el código desde la fila seleccionada
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];
                int idCodigo = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                int idRol = 1;
                String tablaU = "Usuarios";

                int idPersona = ObtenerIdDniEmpleado(txtDNIEmpleado.Text);
                Class.Crud objetoCrud = new Class.Crud();

                if (selRoles.SelectedItem != null)
                {
                    idRol = ObtenerIdRol(selRoles.SelectedItem.ToString());
                }

                int Activo = txtActivo.Checked ? 1 : 0;

                String cadena = $"Usuario = '{txtUsuario.Text}', Contrasenia = '{txtContrasenia.Text}', Activo = {Activo}, Id_Empleado = {idPersona}, Id_Roles = {idRol}";
                objetoCrud.editar(tablaU, cadena, idCodigo);
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar modificar.");
            }

            CargarDatosUsuarios();
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el código desde la fila seleccionada
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];
                int idCodigo = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                String tablaU = "Usuarios";

                Class.Crud objetoCrud = new Class.Crud();

                objetoCrud.eliminar(tablaU,idCodigo);
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar eliminar.");
            }
            CargarDatosUsuarios();
        }
    }
}
