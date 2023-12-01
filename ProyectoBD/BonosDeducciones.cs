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
    public partial class BonosDeducciones : Form
    {
        private int idContrato;
        private Crud objetoCrud;
        private int idSucursal;
        private List<string> permisos;
        public BonosDeducciones(int idContrato, int idSucursal, List<string> permisos)
        {
            objetoCrud = new Crud();
            this.idContrato = idContrato;
            this.idSucursal = idSucursal;
            this.permisos = permisos;
            InitializeComponent();
            Class1.cargarComboBox("Nombre", "Deducciones", comboBoxDeducciones);
            Class1.cargarComboBox("Nombre", "Beneficios", comboBoxBeneficios);
            mostrarInfoBonificaciones();
            mostrarInfoDeducciones();

            mostradorBonificaciones.CellClick += mostradorBonificaciones_CellClick;
            
        }

        private void BonosDeducciones_Load(object sender, EventArgs e)
        {
            EncabezadoBeneficios.Text = "Beneficios y Deducciones del contrato #" + idContrato;
        }

        
        public void mostrarInfoDeducciones()
        {
            Class.Crud objetoCrud = new Class.Crud();
            String instruccion = "SELECT Contratos_Deducciones.Id, Nombre, Monto " +
                                  "FROM Contratos_Deducciones " +
                                  "INNER JOIN Contratos ON (Contratos_Deducciones.Id_Contrato = Contratos.Id) " +
                                  "INNER JOIN Deducciones ON (Contratos_Deducciones.Id_Deduccion = Deducciones.Id) " +
                                  "WHERE Contratos.Id = " + idContrato;

            objetoCrud.mostrarData(MostradorDeducciones, instruccion);
        }

        public void mostrarInfoBonificaciones()
        {
            Class.Crud objetoCrud = new Class.Crud();
            String instruccion = "SELECT Contratos_Beneficios.Id, Nombre, Monto " +
                                  "FROM Contratos_Beneficios " +
                                  "INNER JOIN Contratos ON (Contratos_Beneficios.Id_Contrato = Contratos.Id) " +
                                  "INNER JOIN Beneficios ON (Contratos_Beneficios.Id_Beneficio = Beneficios.Id) " +
                                  "WHERE Contratos.Id = " + idContrato;

            objetoCrud.mostrarData(mostradorBonificaciones, instruccion);
        }

        //Agregar Beneficios a Contratos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string beneficio = comboBoxBeneficios.Text;
            int idBeneficio = Class1.ObtenerId("Beneficios", "Nombre", beneficio);
            objetoCrud.guardar("Contratos_Beneficios", " " + idContrato + ", " + idBeneficio + " ");
            mostrarInfoBonificaciones();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deduccion = comboBoxDeducciones.Text;
            int idDeduccion = Class1.ObtenerId("Deducciones", "Nombre", deduccion);
            objetoCrud.guardar("Contratos_Deducciones", " " + idContrato + ", " + idDeduccion + " ");
            mostrarInfoDeducciones();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contratos contratos = new Contratos(idSucursal, "", 2, permisos);
            contratos.Show();
            this.Hide();
        }

        private void MostradorDeducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EncabezadoBeneficios_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCitas_Click(object sender, EventArgs e)
        {
            //
            int idEliminar = 0;
        }

        private void mostradorBonificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de la celda en la columna "IdColumn"
                object valorId = mostradorBonificaciones["Id", e.RowIndex].Value;

                // Si el valor es de tipo entero, puedes convertirlo a int
                if (valorId != null && int.TryParse(valorId.ToString(), out int id))
                {
                    // Ahora "id" contiene el valor del ID
                    MessageBox.Show("ID de la fila: " + id.ToString());
                }
            }
        }

        private void mostradorBonificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
