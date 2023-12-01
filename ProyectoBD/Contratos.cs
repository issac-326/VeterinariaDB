﻿using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProyectoBD.Class;
using ProyectoBD.SQLConexion;

namespace ProyectoBD
{
    public partial class Contratos : Form
    {
        String nombreTabla = "Contratos";
        private int  idSucursal;
        private string accion;
        private int idPersona;
        private List<string> permisos;

        public Contratos( int idSucursal, string accion, int idPersona, List<string> permisos)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            this.permisos = permisos;
            this.idPersona = idPersona;
            Class1.cargarComboBox("Id", "Horarios", comboBoxHorario);
            Class1.cargarComboBox("Nombre", "Tipos_Empleados", comboBoxCargos);
            Class1.cargarComboBox("Periodo", "Periodos_Pago", comboBoxPeriodoPago);
            Class1.cargarComboBox("Periodo_Laboral", "Periodos_Laborales", comboBoxPeriodoLaboral);
            mostrarInfo();

            if (accion != "Renovar")
            {
                mostradorContratos.CellDoubleClick += mostradorContratos_CellDoubleClick;
            }
            
            this.accion = accion;
            this.idPersona = idPersona;
        }

        private void mostradorContratos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que el clic se haya realizado en una fila válida
            {
                DataGridViewRow row = mostradorContratos.Rows[e.RowIndex];

                // Obtenemso el valor del id del selecinado
                int idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

                // Crear e mostrar el nuevo formulario pasando el ID
                BonosDeducciones nuevoFormulario = new BonosDeducciones(idSeleccionado, idSucursal, permisos);
                nuevoFormulario.Show();
                this.Hide();
            }
        }

        public void mostrarInfo()
        {
            Class.Crud objetoCrud = new Class.Crud();
            String instruccion = "SELECT Contratos.Id, Fecha_Inicio, Fecha_Final, Periodo_Laboral, Hora_Inicial, Hora_Final, Nombre as Cargo, Salario_Bruto, Salario_Neto, Periodo as Periodo_Pago " +
                                  "FROM Contratos " +
                                  "INNER JOIN Periodos_Laborales ON(Contratos.Id_Periodo_Laboral = Periodos_Laborales.Id)" +
                                  "INNER JOIN Horarios ON(Contratos.Id_Horario = Horarios.Id) " +
                                  "INNER JOIN Tipos_Empleados ON(Contratos.Id_Tipo = Tipos_Empleados.Id)" +
                                  "INNER JOIN Salarios ON(Contratos.Id_Salario = Salarios.Id)" +
                                  "INNER JOIN Periodos_Pago ON (Salarios.Id_Periodo_Pago = Periodos_Pago.Id)";
            objetoCrud.mostrarData(mostradorContratos, instruccion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH(idSucursal, permisos);
            submodulosRRHH.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
        * Metodo para ingresar Nuevo Contrato.
        */
        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
            int idPeriodoPago = 0;
            int idPeriodoLab = 0;
            int idHorario = 0;
            int idCargo = 0;
            int idSalario = 0;
            double salarioBruto = Double.Parse(textBoxSalarioBruto.Text);

            Class.Crud objetoCrud = new Class.Crud();
            if (comboBoxPeriodoPago.SelectedItem != null)
            {
                idPeriodoPago = Class1.ObtenerId("Periodos_Pago", "Periodo", comboBoxPeriodoPago.SelectedItem.ToString());
            }
            if (comboBoxHorario.SelectedItem != null)
            {
                idHorario = Class1.ObtenerId("Horarios", "Id", comboBoxHorario.SelectedItem.ToString());
            }
            if (comboBoxCargos.SelectedItem != null)
            {
                idCargo = Class1.ObtenerId("Tipos_Empleados", "Nombre", comboBoxCargos.SelectedItem.ToString());
            }
            if (comboBoxPeriodoLaboral.SelectedItem != null)
            {
                idPeriodoLab = Class1.ObtenerId("Periodos_Laborales", "Periodo_Laboral", comboBoxPeriodoLaboral.SelectedItem.ToString());
            }

            DateTime fechaInicio = dateTimePickerFechaI.Value;
            string fechaInicioFormateada = fechaInicio.ToString("yyyy-MM-dd");

            DateTime fechaFin = dateTimePickerFechaFin.Value;
            string fechaFinFormateada = fechaFin.ToString("yyyy-MM-dd");

            //Insertar Salario
            String values = " " + salarioBruto + ", " + idPeriodoPago + " ";
            objetoCrud.guardar("Salarios (Salario_Bruto, Id_Periodo_Pago) ", values);

            //Obtener Id del salario registrado recién
            idSalario = Class1.ObtenerIdUltimoRegistro("Salarios");

            //Insertar Contrato
            String values1 = $"'{fechaInicioFormateada}', '{fechaFinFormateada}', {idPeriodoLab}, {idHorario}, {idCargo},{idSalario}";

            try
            {
                objetoCrud.guardar(nombreTabla, values1);
                mostrarInfo();

                if (accion.Equals("Renovar"))
                {
                    mostradorContratos.Enabled = false;
                    //obtengo el id del contrato insertado
                    int idContrato = Class1.ObtenerIdUltimoRegistro("Contratos");

                    //Actualizo el contrato del Empleado
                    string query = $"UPDATE Empleados SET Id_Contrato = {idContrato} WHERE Id = {idPersona};";

                    ConexionSqlServer conn = new ConexionSqlServer();
                    SqlCommand comando = new SqlCommand(query, conn.establecerConexion());
                    comando.ExecuteNonQuery();
                    conn.cerrarConexion();
                    MessageBox.Show("Se renovó el contrato.");

                    InfoEmpleados win = new InfoEmpleados(idPersona, idSucursal, permisos);
                    win.Show();
                    this.Hide();
                }
                else
                {
                    //Me llevo el id del contrato insertado
                    int idContrato = Class1.ObtenerIdUltimoRegistro("Contratos");

                    GestionEmpleados win = new GestionEmpleados(idContrato, idSucursal, permisos);
                    win.Show();
                    this.Hide();
                }


            }catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema.");
            }   

        }

        private void btnLimpiarCitas_Click(object sender, EventArgs e)
        {
            textBoxSalarioBruto.Text = "";
            comboBoxCargos.SelectedIndex = 0;
            comboBoxHorario.SelectedIndex = 0;
            comboBoxPeriodoLaboral.SelectedIndex = 0;   
            comboBoxPeriodoPago.SelectedIndex = 0;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SubmodulosRRHH submodulosRRHH = new SubmodulosRRHH(idSucursal, permisos);
            submodulosRRHH.Show();
            this.Hide();
        }

        private void btnModificarCitas_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPeriodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Contratos_Load(object sender, EventArgs e)
        {

        }
    }
}
