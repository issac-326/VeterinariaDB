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
using ProyectoBD.Class;
using ProyectoBD.SQLConexion;
using static Azure.Core.HttpHeader;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBD
{
    public partial class GestionEmpleados : Form
    {
        private int idContrato;
        private Crud objetoCrud;
        private int idSucursal;
        private ConexionSqlServer conn;
        private List<string> permisos;

        public GestionEmpleados(int idContrato, int idSucursal, List<string> permisos)
        {
            this.idContrato = idContrato;
            this.idSucursal = idSucursal;
            this.permisos = permisos;
            InitializeComponent();
            Class1.cargarComboBox("Nombre", "Ciudades", comboBoxCiudad);
            objetoCrud = new Crud();
            conn = new ConexionSqlServer();
        }


        //Función para Contratar nuevo empleado.
        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            int idCiudad = Class1.ObtenerId("Ciudades", "Nombre", comboBoxCiudad.Text);

            DateTime fechaNaci = fechaNacimiento.Value;
            string fechaFormateada = fechaNaci.ToString("yyyy-MM-dd");

            try
            {
                ConexionSqlServer conn = new ConexionSqlServer();
                string query0 =
                    $" BEGIN TRY" +
                    $"      BEGIN TRAN" +
                    $"          INSERT INTO Direcciones VALUES('{referencia.Text}', {idCiudad});" +
                    $"          DECLARE @Id_Direccion AS INT" +
                    $"          SET @Id_Direccion = (SELECT IDENT_CURRENT('Direcciones') AS Id);" +

                    $"          INSERT INTO Personas VALUES('{primerNombre.Text}', '{segundoNombre.Text}', '{primerApellido.Text}', '{segundoApellido.Text}', '{identidad.Text}', '{fechaFormateada}', @Id_Direccion);" +
                    $"          DECLARE @Id_Persona AS INT" +
                    $"          SET @Id_Persona = (SELECT IDENT_CURRENT('Personas') AS Id);" +

                    $"          INSERT INTO Correos_Personas VALUES('{correo.Text}', @Id_Persona);" +
                    $"          INSERT INTO Telefonos_Personas VALUES('{telefono.Text}', @Id_Persona); " +
                    $"          INSERT INTO Empleados VALUES ('{seguroSocial.Text}', '{foto.Text}', @Id_Persona, {idContrato}, {idSucursal});" +
                    $"      COMMIT " +
                    $"      PRINT('SE INSERTÓ UN NUEVO EMPLEADO');" +
                    $" END TRY" +
                    $" BEGIN CATCH" +
                    $"       ROLLBACK" +
                    $"       PRINT('OCURRIÓ UN ERROR EN LA TRANSACCIÓN');" +
                    $" END CATCH";

                SqlCommand comando = new SqlCommand(query0, conn.establecerConexion());
                comando.ExecuteNonQuery();
                conn.cerrarConexion();

                MessageBox.Show("Se ha contratado correctamente a " + primerNombre.Text + " " + primerApellido.Text + ". ");
                Contratos win = new Contratos(idSucursal,"", 2, permisos);
                win.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH(idSucursal, permisos);
            submodulosRRHH.Show();
            this.Hide();
        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Limpiar Pantalla
        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            primerNombre.Text = "";
            segundoNombre.Text = "";
            primerApellido.Text = "";
            segundoApellido.Text = "";
            correo.Text = "";
            referencia.Text = "";
            foto.Text = "";
            seguroSocial.Text = "";
            comboBoxCiudad.SelectedValue = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
