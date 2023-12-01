using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProyectoBD
{
    public partial class FormularioFactura : Form
    {
        decimal totalF = 0;
        decimal subtotalF = 0;
        decimal isv15F = 0;
        decimal isv18lF = 0;
        int idSucursal;
        int idInscripcion = 0;
        public FormularioFactura(int idSucursal)
        {
            InitializeComponent();

            this.idSucursal = idSucursal;
            cargarDetalle();
        }
        public void cargarDetalle()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int ObtenerId()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma

                    string query = "SELECT TOP 1 * FROM Inscripcion_SAR WHERE Id_Sucursal = " + idSucursal + " AND activo = 1 ORDER BY Fecha_Limite DESC;";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idInscripcion = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idMedicmento: " + ex.Message);
            }
            return idInscripcion;
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
            detalleFactura.Rows.Clear();
            txtdni.Text = "";
            txtCantidad.Text = "";
            txtProducto.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

                    if (impuestoSeleccionado == 15)
                    {
                        isv15F = isv15F + (precio * 0.15m);
                    }
                    else
                    {
                        isv18lF = isv18lF + (precio * 0.18m);
                    }
                    totalF = subtotalF + isv15F + isv18lF;
                    subtotal.Text = subtotalF.ToString(CultureInfo.InvariantCulture);
                    total.Text = totalF.ToString(CultureInfo.InvariantCulture);
                    isv18.Text = isv18lF.ToString(CultureInfo.InvariantCulture);
                    ivs15.Text = isv15F.ToString(CultureInfo.InvariantCulture);
                    rowData[4] = impuesto.SelectedItem;
                    detalleFactura.Rows.Add(rowData);

                }
                else
                {
                    MessageBox.Show("Cantidad a vender mayor que existencia en el inventario.");
                }
                txtCantidad.Text = "";
                txtProducto.Text = "";

            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Agregar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //muestra el producto
        private void button4_Click(object sender, EventArgs e)
        {

            Class.Crud objetoCrud = new Class.Crud();
            String productos = $"SELECT P.Id AS Id, P.Nombre AS Nombre, P.Precio, R.Cantidad FROM Productos P JOIN Registros R ON P.Id = R.Id_Producto WHERE R.Id_Tipo = 5 AND P.Nombre LIKE '%{txtProducto.Text}%';";
            objetoCrud.mostrarData(mostrarProducto, productos);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //elimar medicamento
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
                // Buscar id de la persona 
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
            idSucursal = 1;

            // Formatea la fecha en el formato deseado para SQL Server (puedes ajustar esto según tu configuración)
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Class.Crud objetoCrud = new Class.Crud();
           
            String cadena = $"'', '{fecha}', {totalF.ToString(CultureInfo.InvariantCulture)} , {isv15F.ToString(CultureInfo.InvariantCulture)}, {isv18lF.ToString(CultureInfo.InvariantCulture)}, {ObtenerId()} , {idSucursal} ,{dni}, 1, 1";
            objetoCrud.guardar("Facturas (RTN_Cliente, Fecha, Total, Impuesto_15, Impuesto_18, Id_Inscripcion, Id_Scursal, Id_Cliente, Id_Tipo_Documento, Id_Punto_Emision )", cadena);
            int idF = ObtenerIdFactura(fecha, dni);
            IngresarProducto(idF);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioFactura_Load(object sender, EventArgs e)
        {

        }
        private int ObtenerIdFactura(string fecha, int idCliente)
        {
            int idF = 0;
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {
                    // Buscar el id de la forma

                    string query = "SELECT TOP 1 * FROM Facturas WHERE Id_Cliente = " + idCliente + " AND Fecha = '" + fecha + "' ORDER BY Id DESC;";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            reader.Read(); // Solo necesitas leer la primera fila

                            // Obtener el valor del ID
                            idF = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idMedicmento: " + ex.Message);
            }
            return idF;
        }
        private void IngresarProducto(int idF)
        {
            int totalFilas = detalleFactura.Rows.Count;
            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in detalleFactura.Rows)
            {
                // Obtener el índice de la fila actual
                int indiceFila = fila.Index;

                // Verificar si la fila actual no es la última
                if (indiceFila < totalFilas-1)
                {
                    // Obtener los valores de cada celda
                    int id = Convert.ToInt32(fila.Cells["ID"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                    decimal impuestos = Convert.ToDecimal(fila.Cells["isv"].Value);

                    Class.Crud objetoCrud = new Class.Crud();

                    if (impuestos == 15)
                    {
                        // Insertar en la base de datos 
                        String cadena = $"{precio.ToString(CultureInfo.InvariantCulture)} , {cantidad}, {impuestos.ToString(CultureInfo.InvariantCulture)}, NULL, {idF} , {id} ";
                        objetoCrud.guardar("Detalles_Facturas", cadena);
                        //bajamos el inventario
                        RegistroVenta(id, cantidad);
                    }
                    else
                    {
                        String cadena = $"{precio.ToString(CultureInfo.InvariantCulture)} , {cantidad}, NULL, {impuestos.ToString(CultureInfo.InvariantCulture)}, {idF} , {id} ";
                        objetoCrud.guardar("Detalles_Facturas", cadena);
                        //bajamos el inventario 
                        RegistroVenta(id, cantidad);

                    }
                   
                }

            }

            // Limpiar el DataGridView después de agregar las filas a la base de datos
            subtotal.Text = "00.00";
            total.Text = "00.00";
            isv18.Text = "00.00";
            ivs15.Text = "00.00";
            detalleFactura.Rows.Clear();
            txtdni.Text = "";
            txtCantidad.Text = "";
            txtProducto.Text = "";
        }
        public void RegistroVenta(int idProducto, int Cantidad)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {

                String query = $"EXEC movimientoVenta {idProducto}, 5, {Cantidad}, -1;";

                SqlCommand comando = new SqlCommand(query, objectConexion.establecerConexion());
                SqlDataReader myReader;

                myReader = comando.ExecuteReader();

                while (myReader.Read())
                {

                }
                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Registrar el movimiento Venta");
            }
        }

    }
}
