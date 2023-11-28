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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyectoBD
{
    public partial class GestionMascotas : Form
    {
        String tabla = "Mascotas";
        int codigo = 0;
        public GestionMascotas()
        {
            InitializeComponent();
            cargarGeneros();
            cargarEstados();
            cargarEspecies();
            Class.Crud objetoCrud = new Class.Crud();
            String instruccion = "SELECT Mascotas.Id, Mascotas.Nombre,  Mascotas.Carac_Distintiva, Mascotas.Fecha_Nacimiento, Mascotas.Esterilizacion, Mascotas.Agresivo, Mascotas.Peso, Mascotas.Tamanio, Especies.Nombre AS Especie, Razas.Nombre AS Raza, Generos.Nombre AS Genero, Estados.Nombre AS Estado FROM  Mascotas JOIN Especies ON Mascotas.Id_Especie = Especies.Id JOIN Razas ON Mascotas.Id_Raza = Razas.Id JOIN Generos ON Mascotas.Id_Genero = Generos.Id JOIN Estados ON Mascotas.Id_Estado = Estados.Id;";
            objetoCrud.mostrarData(mostradorMascotas, instruccion);
        }


        public void cargarEspecies()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Especies";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEspecie.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selEspecie.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las especies: " + ex.Message);
            }
        }

        public void cargarEstados()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Estados";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selEstado.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selEstado.Items.Add(reader["Nombre"].ToString());
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
        public void cargarGeneros()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Generos";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selGenero.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selGenero.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los generos: " + ex.Message);
            }
        }

        private int ObtenerIdEspecie(String nombreEspecie)
        {
            int idEspecie = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Especies where Nombre = '" + nombreEspecie + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idEspecie = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idEspecie: " + ex.Message);
            }
            return idEspecie;
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
                    string query = "SELECT Id FROM Estados where Nombre = '" + nombreEstado + "';";
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

        private int ObtenerIdGenero(String nombreGenero)
        {
            int idGenero = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Generos where Nombre = '" + nombreGenero + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idGenero = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idGenero: " + ex.Message);
            }
            return idGenero;
        }

        private int ObtenerIdRaza(string nombreRaza)
        {
            int idRaza = -1;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Razas where Nombre = '" + nombreRaza + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idRaza = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idRaza: " + ex.Message);
            }
            return idRaza;
        }

        private void selEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la especie seleccionada
            string especieSeleccionada = selEspecie.SelectedItem.ToString();

            selRaza.SelectedItem = null;

            // Cargar las razas correspondientes a la especie seleccionada
            CargarRazasPorEspecie(especieSeleccionada);
        }

        void CargarRazasPorEspecie(String especieSeleccionada)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    // Consulta SQL para obtener nombres 
                    string query = "SELECT Nombre FROM Razas WHERE Id_Especie = (SELECT Id FROM Especies WHERE Nombre = '" + especieSeleccionada + "')";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            selRaza.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                selRaza.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los generos: " + ex.Message);
            }
        }
        private void GestionMascotas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idEspecie = -1;
            int idGenero = 1;
            int idRaza = 1;
            int idEstado = 1;
            Class.Crud objetoCrud = new Class.Crud();
            if (selEspecie.SelectedItem != null)
            {
                idEspecie = ObtenerIdEspecie(selEspecie.SelectedItem.ToString());
            }
            if (selRaza.SelectedItem != null)
            {
                idRaza = ObtenerIdRaza(selRaza.SelectedItem.ToString());
            }
            if (selGenero.SelectedItem != null)
            {
                idGenero = ObtenerIdGenero(selGenero.SelectedItem.ToString());
            }
            if (selEstado.SelectedItem != null)
            {
                idEstado = ObtenerIdEstado(selEstado.SelectedItem.ToString());
            }
            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado en este caso solo ocupamos año, mes, dia
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            int esterilizado = txtEsterilizacion.Checked ? 1 : 0;
            int agresivo = txtAgresivo.Checked ? 1 : 0;

            String cadena = $"'{txtNombre.Text}', '{txtCaracteristicas.Text}', '{fechaFormateada}', {esterilizado}, {agresivo},'{txtPeso.Text}', '{txtTamano.Text}', {idEspecie}, {idRaza}, {idGenero}, {idEstado}";
            objetoCrud.guardar(tabla, cadena);
            String instruccion = "SELECT Mascotas.Id, Mascotas.Nombre,  Mascotas.Carac_Distintiva, Mascotas.Fecha_Nacimiento, Mascotas.Esterilizacion, Mascotas.Agresivo, Mascotas.Peso, Mascotas.Tamanio, Especies.Nombre AS Especie, Razas.Nombre AS Raza, Generos.Nombre AS Genero, Estados.Nombre AS Estado FROM  Mascotas JOIN Especies ON Mascotas.Id_Especie = Especies.Id JOIN Razas ON Mascotas.Id_Raza = Razas.Id JOIN Generos ON Mascotas.Id_Genero = Generos.Id JOIN Estados ON Mascotas.Id_Estado = Estados.Id;";
            objetoCrud.mostrarData(mostradorMascotas, instruccion);
        }

        private void mostradorMascotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valorCelda = mostradorMascotas.CurrentRow.Cells[0].Value;
                codigo = Convert.ToInt32(valorCelda);
                DataGridViewRow filaSeleccionada = mostradorMascotas.Rows[e.RowIndex];

                // Asigna los valores de la fila seleccionada a los controles
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtCaracteristicas.Text = filaSeleccionada.Cells["Carac_Distintiva"].Value.ToString();

                // Para CheckBox, verifica si el valor es true o false
                txtEsterilizacion.Checked = (bool)filaSeleccionada.Cells["Esterilizacion"].Value;
                txtAgresivo.Checked = (bool)filaSeleccionada.Cells["Agresivo"].Value;

                txtPeso.Text = filaSeleccionada.Cells["Peso"].Value.ToString();
                txtTamano.Text = filaSeleccionada.Cells["Tamanio"].Value.ToString();

                selEspecie.SelectedItem = filaSeleccionada.Cells["Especie"].Value.ToString();
                selRaza.SelectedItem = filaSeleccionada.Cells["Raza"].Value.ToString();
                selGenero.SelectedItem = filaSeleccionada.Cells["Genero"].Value.ToString();
                selEstado.SelectedItem = filaSeleccionada.Cells["Estado"].Value.ToString();

                object valorFecha = filaSeleccionada.Cells["Fecha_Nacimiento"].Value;
                if (valorFecha != null && valorFecha != DBNull.Value)
                {
                    if (DateTime.TryParse(valorFecha.ToString(), out DateTime fecha))
                    {
                        txtFecha.Value = fecha;
                    }
                }
            }

        }

        private String obtenerNombrePorId(String tabla, int codigo)
        {
            String nombre = " ";
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Nombre FROM" + tabla + " where Id = '" + codigo + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            nombre = reader["Nombre"].ToString();
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener nombre: " + ex.Message);
            }
            return nombre;
        }

        private void mostradorMascotas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que el clic se haya realizado en una fila válida
            {
                DataGridViewRow row = mostradorMascotas.Rows[e.RowIndex];

                // Obtenemso el valor del id del selecinado
                int idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

                // Crear e mostrar el nuevo formulario pasando el ID
                ControlMascota nuevoFormulario = new ControlMascota(idSeleccionado);
                nuevoFormulario.Show();
                this.Hide();

            }
        }

        private void mostradorMascotas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int idEspecie = -1;
            int idGenero = 1;
            int idRaza = 1;
            int idEstado = 1;
            if (selEspecie.SelectedItem != null)
            {
                idEspecie = ObtenerIdEspecie(selEspecie.SelectedItem.ToString());
            }
            if (selRaza.SelectedItem != null)
            {
                idRaza = ObtenerIdRaza(selRaza.SelectedItem.ToString());
            }
            if (selGenero.SelectedItem != null)
            {
                idGenero = ObtenerIdGenero(selGenero.SelectedItem.ToString());
            }
            if (selEstado.SelectedItem != null)
            {
                idEstado = ObtenerIdEstado(selEstado.SelectedItem.ToString());
            }
            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            int esterilizado = txtEsterilizacion.Checked ? 1 : 0;
            int agresivo = txtAgresivo.Checked ? 1 : 0;

            Class.Crud objetoCrud = new Class.Crud();
            String cadena = $"Nombre = '{txtNombre.Text}', Carac_Distintiva = '{txtCaracteristicas.Text}', Fecha_Nacimiento = '{fechaFormateada}',Esterilizacion = {esterilizado}, Agresivo = {agresivo}, Peso = '{txtPeso.Text}', Tamanio = '{txtTamano.Text}', Id_Especie = {idEspecie}, Id_Raza = {idRaza}, Id_Genero = {idGenero}, Id_Estado = {idEstado}";
            objetoCrud.editar("Mascotas", cadena, codigo);
            String instruccion = "SELECT Mascotas.Id, Mascotas.Nombre,  Mascotas.Carac_Distintiva, Mascotas.Fecha_Nacimiento, Mascotas.Esterilizacion, Mascotas.Agresivo, Mascotas.Peso, Mascotas.Tamanio, Especies.Nombre AS Especie, Razas.Nombre AS Raza, Generos.Nombre AS Genero, Estados.Nombre AS Estado FROM  Mascotas JOIN Especies ON Mascotas.Id_Especie = Especies.Id JOIN Razas ON Mascotas.Id_Raza = Razas.Id JOIN Generos ON Mascotas.Id_Genero = Generos.Id JOIN Estados ON Mascotas.Id_Estado = Estados.Id;";
            objetoCrud.mostrarData(mostradorMascotas, instruccion);
            codigo = 0;
            txtNombre.Text = "";
            txtCaracteristicas.Text = "";
            txtEsterilizacion.Checked = false;
            txtAgresivo.Checked = false;
            txtPeso.Text = "";
            txtTamano.Text = "";
            selEspecie.SelectedIndexChanged -= selEspecie_SelectedIndexChanged;
            selEspecie.SelectedIndex = -1;
            selEspecie.SelectedIndexChanged += selEspecie_SelectedIndexChanged;
            selRaza.SelectedIndex = -1;
            selGenero.SelectedIndex = -1;
            selEstado.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            codigo = 0;
            txtNombre.Text = "";
            txtCaracteristicas.Text = "";
            txtEsterilizacion.Checked = false;
            txtAgresivo.Checked = false;
            txtPeso.Text = "";
            txtTamano.Text = "";
            selEspecie.SelectedIndexChanged -= selEspecie_SelectedIndexChanged;
            selEspecie.SelectedIndex = -1;
            selEspecie.SelectedIndexChanged += selEspecie_SelectedIndexChanged;
            selRaza.SelectedIndex = -1;
            selGenero.SelectedIndex = -1;
            selEstado.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idEspecie = -1;
            int idGenero = 1;
            int idRaza = 1;
            int idEstado = 1;
            Class.Crud objetoCrud = new Class.Crud();
            if (selEspecie.SelectedItem != null)
            {
                idEspecie = ObtenerIdEspecie(selEspecie.SelectedItem.ToString());
            }
            if (selRaza.SelectedItem != null)
            {
                idRaza = ObtenerIdRaza(selRaza.SelectedItem.ToString());
            }
            if (selGenero.SelectedItem != null)
            {
                idGenero = ObtenerIdGenero(selGenero.SelectedItem.ToString());
            }
            if (selEstado.SelectedItem != null)
            {
                idEstado = ObtenerIdEstado(selEstado.SelectedItem.ToString());
            }

            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            int esterilizado = txtEsterilizacion.Checked ? 1 : 0;
            int agresivo = txtAgresivo.Checked ? 1 : 0;

            String cadena = $"'{txtNombre.Text}', '{txtCaracteristicas.Text}', '{fechaFormateada}', {esterilizado}, {agresivo},'{txtPeso.Text}', '{txtTamano.Text}', {idEspecie}, {idRaza}, {idGenero}, {idEstado}";
            objetoCrud.guardar(tabla, cadena);
            String instruccion = "SELECT Mascotas.Id, Mascotas.Nombre,  Mascotas.Carac_Distintiva, Mascotas.Fecha_Nacimiento, Mascotas.Esterilizacion, Mascotas.Agresivo, Mascotas.Peso, Mascotas.Tamanio, Especies.Nombre AS Especie, Razas.Nombre AS Raza, Generos.Nombre AS Genero, Estados.Nombre AS Estado FROM  Mascotas JOIN Especies ON Mascotas.Id_Especie = Especies.Id JOIN Razas ON Mascotas.Id_Raza = Razas.Id JOIN Generos ON Mascotas.Id_Genero = Generos.Id JOIN Estados ON Mascotas.Id_Estado = Estados.Id;";
            objetoCrud.mostrarData(mostradorMascotas, instruccion);
            int idUltimoRegistro = 0;
            idUltimoRegistro = ObtenerIdUltimoRegistro();
            String cadenaExpediente = $"GETDATE(), {idUltimoRegistro}";
            objetoCrud.guardarSinNotificacion("Expedientes", cadenaExpediente);
            String cadenaCarnet = $"{idUltimoRegistro}";
            objetoCrud.guardarSinNotificacion("Carnet_Vacunas", cadenaCarnet);
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
                    string query = "SELECT IDENT_CURRENT('Mascotas') AS Id;";
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEspecie = -1;
            int idGenero = 1;
            int idRaza = 1;
            int idEstado = 1;
            if (selEspecie.SelectedItem != null)
            {
                idEspecie = ObtenerIdEspecie(selEspecie.SelectedItem.ToString());
            }
            if (selRaza.SelectedItem != null)
            {
                idRaza = ObtenerIdRaza(selRaza.SelectedItem.ToString());
            }
            if (selGenero.SelectedItem != null)
            {
                idGenero = ObtenerIdGenero(selGenero.SelectedItem.ToString());
            }
            if (selEstado.SelectedItem != null)
            {
                idEstado = ObtenerIdEstado(selEstado.SelectedItem.ToString());
            }
            DateTime fechaSeleccionada = txtFecha.Value;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            int esterilizado = txtEsterilizacion.Checked ? 1 : 0;
            int agresivo = txtAgresivo.Checked ? 1 : 0;

            Class.Crud objetoCrud = new Class.Crud();
            String cadena = $"Nombre = '{txtNombre.Text}', Carac_Distintiva = '{txtCaracteristicas.Text}', Fecha_Nacimiento = '{fechaFormateada}',Esterilizacion = {esterilizado}, Agresivo = {agresivo}, Peso = '{txtPeso.Text}', Tamanio = '{txtTamano.Text}', Id_Especie = {idEspecie}, Id_Raza = {idRaza}, Id_Genero = {idGenero}, Id_Estado = {idEstado}";
            objetoCrud.editar("Mascotas", cadena, codigo);
            String instruccion = "SELECT Mascotas.Id, Mascotas.Nombre,  Mascotas.Carac_Distintiva, Mascotas.Fecha_Nacimiento, Mascotas.Esterilizacion, Mascotas.Agresivo, Mascotas.Peso, Mascotas.Tamanio, Especies.Nombre AS Especie, Razas.Nombre AS Raza, Generos.Nombre AS Genero, Estados.Nombre AS Estado FROM  Mascotas JOIN Especies ON Mascotas.Id_Especie = Especies.Id JOIN Razas ON Mascotas.Id_Raza = Razas.Id JOIN Generos ON Mascotas.Id_Genero = Generos.Id JOIN Estados ON Mascotas.Id_Estado = Estados.Id;";
            objetoCrud.mostrarData(mostradorMascotas, instruccion);

            codigo = 0;
            txtNombre.Text = "";
            txtCaracteristicas.Text = "";
            txtEsterilizacion.Checked = false;
            txtAgresivo.Checked = false;
            txtPeso.Text = "";
            txtTamano.Text = "";
            selEspecie.SelectedIndexChanged -= selEspecie_SelectedIndexChanged;
            selEspecie.SelectedIndex = -1;
            selEspecie.SelectedIndexChanged += selEspecie_SelectedIndexChanged;
            selRaza.SelectedIndex = -1;
            selGenero.SelectedIndex = -1;
            selEstado.SelectedIndex = -1;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            codigo = 0;
            txtNombre.Text = "";
            txtCaracteristicas.Text = "";
            txtEsterilizacion.Checked = false;
            txtAgresivo.Checked = false;
            txtPeso.Text = "";
            txtTamano.Text = "";
            selEspecie.SelectedIndexChanged -= selEspecie_SelectedIndexChanged;
            selEspecie.SelectedIndex = -1;
            selEspecie.SelectedIndexChanged += selEspecie_SelectedIndexChanged;
            selRaza.SelectedIndex = -1;
            selGenero.SelectedIndex = -1;
            selEstado.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SubmodulosAtencionCliente submodulosAtencionCliente = new SubmodulosAtencionCliente();
            submodulosAtencionCliente.Show();
            this.Hide();
        }

        private void mostradorMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
