using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.Class;
namespace ProyectoBD
{
    public partial class FormularioFactura : Form
    {
        decimal totalF = 0;
        decimal subtotalF = 0;
        decimal isv15F = 0;
        decimal isv18lF = 0;
        private List<string> permisos;
        private int idPersona;
        private int idSucursal;
        private int puntoEmision;

        private decimal pagoEfectivo;
        private decimal cambio;

        public FormularioFactura(List<string> permisos, int idSucursal, int idPersona)
        {
            InitializeComponent();
            this.permisos = permisos;
            this.idSucursal = idSucursal;

            cargarDetalle();
            cargarPuntosEmision();

        }
        public void cargarDetalle()
        {

        }

        public void cargarPuntosEmision()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    // Consulta SQL para obtener nombres de especies
                    string query = $"SELECT Codigo  FROM Puntos_Emision WHERE Id_Sucursal = {idSucursal} ";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxPuntoEmision.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxPuntoEmision.Items.Add(reader["Codigo"].ToString());
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            subtotal.Text = "00.00";
            total.Text = "00.00";
            isv18.Text = "00.00";
            ivs15.Text = "00.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulos win = new Modulos(permisos, idSucursal, idPersona);
            win.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada en el primer DataGridView
            if (mostrarProducto.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = mostrarProducto.SelectedRows[0];

                // Crea un arreglo para almacenar los datos de la fila seleccionada
                object[] rowData = new object[selectedRow.Cells.Count + 1];

                // Copia los datos de la fila seleccionada al arreglo
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }
                // Agrega el dato desde el TextBox a la última celda del arreglo

                int existencia = (int)selectedRow.Cells[selectedRow.Cells.Count - 1].Value;
                int cantidadVenta = int.Parse(txtCantidad.Text);
                if (existencia > cantidadVenta)
                {
                    rowData[selectedRow.Cells.Count - 1] = cantidadVenta;
                    decimal precio = (Convert.ToDecimal(selectedRow.Cells[2].Value) * cantidadVenta);
                    subtotalF = subtotalF + precio;
                    decimal impuestoSeleccionado = Convert.ToDecimal(impuesto.SelectedItem);

                    if (impuestoSeleccionado == 0.15m)
                    {
                        isv15F = isv15F + (precio * 0.15m);
                    }
                    else
                    {
                        isv18lF = isv18lF + (precio * 0.18m);
                    }
                    totalF = subtotalF + isv15F + isv18lF;
                    subtotal.Text = subtotalF.ToString();
                    total.Text = totalF.ToString();
                    isv18.Text = isv18lF.ToString();
                    ivs15.Text = isv15F.ToString();
                    rowData[4] = impuesto.SelectedItem;
                    detalleFactura.Rows.Add(rowData);

                }
                else
                {
                    MessageBox.Show("Cantidad a vender mayor que existencia en el inventario.");
                }


            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Agregar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Class.Crud objetoCrud = new Class.Crud();
            String productos = $"SELECT P.Id AS Id, P.Nombre AS Nombre, P.Precio, R.Cantidad FROM Productos P JOIN Registros R ON P.Id = R.Id_Producto WHERE R.Id_Tipo = 5 AND P.Nombre LIKE '%{txtProducto.Text}%';";
            objetoCrud.mostrarData(mostrarProducto, productos);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada en el DataGridView
            if (detalleFactura.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = detalleFactura.SelectedRows[0];

                // Elimina la fila seleccionada del DataGridView
                detalleFactura.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Eliminar.");
            }
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            int dni = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Obtener id del cliente
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la especie 
                    string query = "SELECT Id FROM Personas where DNI = '" + txtdni.Text + "';";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            dni = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener nombre: " + ex.Message);
            }

            try
            {
                Class.Crud objetoCrud = new Class.Crud();

                // Id Del punto de Emisión
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id
                    string query = $"SELECT Id FROM Puntos_Emision WHERE Id_Sucursal = {idSucursal} AND Codigo = '{comboBoxPuntoEmision.Text}'";
                    using (SqlCommand comand = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comand.ExecuteReader())
                        {
                            reader.Read();
                            puntoEmision = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();


                //Verificacion de Rango SAR

                int disponibleSAR = -1;

                // Id Del punto de Emisión
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id
                    string query1 = $"EXEC verificarSAR {idSucursal}";
                    using (SqlCommand comand = new SqlCommand(query1, conexion))
                    {
                        using (SqlDataReader reader = comand.ExecuteReader())
                        {
                            reader.Read();
                            disponibleSAR = Convert.ToInt32(reader["Disponible"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();

                //Verificacion de Rango SAR

                if (disponibleSAR == 1)
                {
                    ConexionSqlServer conn = new ConexionSqlServer();
                    string query0 = $"INSERT INTO Facturas (RTN_Cliente, Fecha, Total, Impuesto_15, Impuesto_18," +
                        $" Id_Scursal, Id_Cliente, Id_Tipo_Documento, Id_Punto_Emision) VALUES " +
                        $" ( '{textBoxRTN.Text}', GETDATE(), {totalF}, {isv15F}, {isv18lF}, {idSucursal}, {dni}, 1, {puntoEmision});";

                    SqlCommand comando = new SqlCommand(query0, conn.establecerConexion());
                    comando.ExecuteNonQuery();
                    conn.cerrarConexion();

                    pagoEfectivo = decimal.Parse(textBoxEfectivo.Text);
                    cambio = pagoEfectivo - totalF;

                    if (pagoEfectivo != null)
                    {
                        if (cambio >= 0)
                        {
                            Factura win = new Factura(permisos, pagoEfectivo, cambio, idSucursal, idPersona);
                            win.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El efectivo no es suficiente para pagar la cuenta.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Efectivo.");
                    }
                }
                else
                {
                    MessageBox.Show("Necesita una nueva inscripción a la SAR para la sucursal " + idSucursal);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error" + ex);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioFactura_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
