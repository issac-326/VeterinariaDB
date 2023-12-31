﻿using ProyectoBD.Class;
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
        public BonosDeducciones(int idContrato)
        {
            objetoCrud = new Crud();
            this.idContrato = idContrato;
            InitializeComponent();
            cargarDeducciones();
            cargarBeneficios();
            mostrarInfoBonificaciones();
            mostrarInfoDeducciones();

            mostradorBonificaciones.CellClick += mostradorBonificaciones_CellClick;
        }

        private void BonosDeducciones_Load(object sender, EventArgs e)
        {
            EncabezadoBeneficios.Text = "Beneficios y Deducciones del contrato #" + idContrato;
        }

        public void cargarDeducciones()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Deducciones";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxDeducciones.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxDeducciones.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las deducciones");
            }
        }

        public void cargarBeneficios()
        {

            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {


                    // Consulta SQL para obtener nombres de especies
                    string query = "SELECT Nombre FROM Beneficios";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            comboBoxBeneficios.Items.Clear();

                            // Agregar cada nombre de especie al ComboBox
                            while (reader.Read())
                            {
                                comboBoxBeneficios.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                objectConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los beneficios");
            }
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
            int idBeneficio = Contratos.ObtenerId("Beneficios", "Nombre", beneficio);
            objetoCrud.guardar("Contratos_Beneficios", " " + idContrato + ", " + idBeneficio + " ");
            mostrarInfoBonificaciones();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deduccion = comboBoxDeducciones.Text;
            int idDeduccion = Contratos.ObtenerId("Deducciones", "Nombre", deduccion);
            objetoCrud.guardar("Contratos_Deducciones", " " + idContrato + ", " + idDeduccion + " ");
            mostrarInfoDeducciones();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contratos contratos = new Contratos();
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
