using Microsoft.VisualBasic;
using ProyectoBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using ProyectoBD.SQLConexion;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class InfoEmpleados : Form
    {
        private int idEmpleado;
        private int idSucursal;
        private List<string> permisos;
        public InfoEmpleados(int idEmpleado, int idSucursal, List<string> permisos)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            this.idSucursal = idSucursal;
            this.permisos = permisos;
            mostrarInfoEmpleado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrarInfoEmpleado()
        {
            MessageBox.Show("id"+ idEmpleado);

            ConexionSqlServer conn = new ConexionSqlServer();

            try
            {
                string query = $"SELECT Empleados.Id, DNI, Primer_Nombre, Segundo_Nombre, Img, " +
                                $"Primer_Apellido, Segundo_Apellido, Edad, Referencia, Ciudades.Nombre as Ciudad, " +
                                $"Departamentos.Nombre as Departamento, Tipos_Empleados.Nombre as Cargo, Telefonos_Personas.Numero, " +
                                $"Correos_Personas.Correo, Num_Seguro, Salarios.Salario_Neto, Salarios.Salario_Bruto, Hora_Inicial, Hora_Final, Periodo_Laboral, Periodo " +
                                $"FROM Empleados " +
                                $"INNER JOIN (Personas " +
                                $"              INNER JOIN (Direcciones " +
                                $"                          INNER JOIN (Ciudades " +
                                $"                                      INNER JOIN Departamentos ON Ciudades.Id_Departamento = Departamentos.Id) " +
                                $"" +
                                $"                                       ON Direcciones.Id_Ciudad = Ciudades.Id) " +
                                $"                          ON Personas.Id_Direccion = Direcciones.Id) " +
                                $"           ON (Empleados.Id_Persona = Personas.Id) " +
                                $"INNER JOIN (Contratos " +
                                $"            INNER JOIN Tipos_Empleados ON (Contratos.Id_Tipo = Tipos_Empleados.Id) " +
                                $"            INNER JOIN (Salarios " +
                                $"                          INNER JOIN Periodos_Pago ON Salarios.Id_Periodo_Pago = Periodos_Pago.Id) " +
                                $"                      ON Contratos.Id_Salario = Salarios.Id " +
                                $"            INNER JOIN Horarios ON Contratos.Id_Horario = Horarios.Id) " +
                                $"            INNER JOIN Periodos_Laborales ON (Contratos.Id_Periodo_Laboral = Periodos_Laborales.Id) " +
                                $" ON (Empleados.Id_Contrato = Contratos.Id) " +
                                $"INNER JOIN Correos_Personas ON (Personas.Id = Correos_Personas.Id_Persona) " +
                                $"INNER JOIN Telefonos_Personas ON (Personas.Id = Telefonos_Personas.Id_Persona) " +
                                $"WHERE Empleados.Id = {idEmpleado}";

                    SqlCommand comando = new SqlCommand(query, conn.establecerConexion());
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {

                        if (!reader.IsDBNull(reader.GetOrdinal("Img")))
                        {
                             string nombreImagen = $"{reader.GetString(reader.GetOrdinal("Img"))}";
                             pictureBoxPerfil.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nombreImagen);
                        }
                        else
                        {
                            pictureBoxPerfil.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("porDefecto.jpg");
                        }

                        nombreCompleto.Text = $"{reader.GetString(reader.GetOrdinal("Primer_Nombre"))} {reader.GetString(reader.GetOrdinal("Segundo_Nombre"))} {reader.GetString(reader.GetOrdinal("Primer_Apellido"))} {reader.GetString(reader.GetOrdinal("Segundo_Apellido"))}";
                        identidad.Text = $"{reader.GetString(reader.GetOrdinal("DNI"))}";
                        telefono.Text = $"{reader.GetString(reader.GetOrdinal("Numero"))}";
                        correo.Text = $"{reader.GetString(reader.GetOrdinal("Correo"))}";
                        edad.Text = $"{reader.GetInt32(reader.GetOrdinal("Edad"))}";
                        direccion.Text = $"{reader.GetString(reader.GetOrdinal("Referencia"))}, {reader.GetString(reader.GetOrdinal("Ciudad"))}, {reader.GetString(reader.GetOrdinal("Departamento"))}";
                        cargo.Text = $"{reader.GetString(reader.GetOrdinal("Cargo"))}";
                        ss.Text = $"{reader.GetString(reader.GetOrdinal("Num_Seguro"))}";
                        salarioB.Text = $"{reader.GetDecimal(reader.GetOrdinal("Salario_Bruto"))}";
                        salario.Text = $"{reader.GetDecimal(reader.GetOrdinal("Salario_Neto"))}";
                        horario.Text = $"{reader.GetTimeSpan(reader.GetOrdinal("Hora_Inicial"))} - {reader.GetTimeSpan(reader.GetOrdinal("Hora_Final"))}";
                        periodoPago.Text = $"{reader.GetString(reader.GetOrdinal("Periodo"))}";
                        periodoLab.Text = $"{reader.GetString(reader.GetOrdinal("Periodo_Laboral"))}";
                    }


            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error." + ex);
            }
           
            conn.cerrarConexion();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Corregir IdSucursal
            Empleados win = new Empleados(idSucursal, permisos);
            win.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InfoEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            Contratos win = new Contratos(idSucursal, "Renovar", idEmpleado, permisos);
            win.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void periodoLab_Click(object sender, EventArgs e)
        {

        }
    }
}
