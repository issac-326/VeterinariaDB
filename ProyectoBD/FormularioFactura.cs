using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
        int idInscripcion =0;
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
                  
                    string query = "SELECT TOP 1 * FROM Inscripcion_SAR WHERE Id_Sucursal = " +idSucursal+ " AND activo = 1 ORDER BY Fecha_Limite DESC;";

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
            String cadena = $"'', '10000', '{fecha}', {totalF.ToString(CultureInfo.InvariantCulture)} , {isv15F.ToString(CultureInfo.InvariantCulture)}, {isv18lF.ToString(CultureInfo.InvariantCulture)}, {ObtenerId()} , {idSucursal} ,{dni}, 1";
            objetoCrud.guardar("Facturas", cadena);










        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
