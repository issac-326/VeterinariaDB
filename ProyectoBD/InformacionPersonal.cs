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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoBD
{
    public partial class InformacionPersonal : Form
    {
        private int idPersona;
        private List<string> Permisos;
        private int idSucursal;
        public InformacionPersonal(List<string> permisos, int idSucursal, int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.Permisos = permisos;
            mostrarInfoPersona(idPersona);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(Permisos, idSucursal, idPersona);
            modulos.Visible = true;
            this.Hide();
        }

        private void mostrarInfoPersona(int idPersona)
        {
            ConexionSqlServer conn = new ConexionSqlServer();

            try
            {
                string query = "SELECT per.DNI, us.Usuario, rol.Nombre as 'Rol', perm.Nombre as 'Permisos', per.Primer_Nombre, per.Segundo_Nombre, emp.Img, per.Primer_Apellido, per.Segundo_Apellido, per.Edad, dir.Referencia, ciu.Nombre as 'Ciudad', dep.Nombre as 'Departamento', tip.Nombre as 'Cargo', tel.Numero, corp.Correo, emp.Num_Seguro, sal.Salario_Neto, sal.Salario_Bruto, hor.Hora_Final, hor.Hora_Inicial, pel.Periodo_Laboral, perp.Periodo\r\nFROM Empleados emp\r\nINNER JOIN Personas per ON emp.Id_Persona = per.Id\r\nINNER JOIN Direcciones dir ON per.Id_Direccion = dir.Id\r\nINNER JOIN Ciudades ciu ON ciu.Id = dir.Id_Ciudad\r\nINNER JOIN Departamentos dep ON ciu.Id_Departamento = dep.Id\r\nINNER JOIN Contratos con ON emp.Id_Contrato = con.Id\r\nINNER JOIN Tipos_Empleados tip ON con.Id_Tipo = tip.Id\r\nINNER JOIN Salarios sal ON con.Id_Salario = sal.Id\r\nINNER JOIN Periodos_Pago perp ON sal.Id_Periodo_Pago = perp.Id\r\nINNER JOIN Periodos_Laborales pel ON con.Id_Periodo_Laboral = pel.Id\r\nINNER JOIN Horarios hor ON con.Id_Horario = hor.Id\r\nINNER JOIN Correos_Personas corp ON per.Id = corp.Id\r\nINNER JOIN Telefonos_Personas tel ON per.Id = tel.Id\r\nINNER JOIN Usuarios us ON emp.Id = us.Id_Empleado\r\nINNER JOIN Roles rol ON us.Id_Roles = rol.Id\r\nINNER JOIN Usuarios_Permisos usp ON usp.Id_Usuario = us.Id\r\nINNER JOIN Permisos perm ON perm.Id = usp.Id_Permiso\r\nWHERE per.Id = " + idPersona + "";

                SqlCommand comando = new SqlCommand(query, conn.establecerConexion());
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    if (!reader.IsDBNull(reader.GetOrdinal("Img")))
                    {
                        string nombreImagen = $"{reader.GetString(reader.GetOrdinal("Img"))}";
                        pbPersona.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nombreImagen);
                    }
                    else
                    {
                        pbPersona.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("porDefecto.jpg");
                    }

                    nombreCompleto.Text = $"{reader.GetString(reader.GetOrdinal("Primer_Nombre"))} {reader.GetString(reader.GetOrdinal("Segundo_Nombre"))} {reader.GetString(reader.GetOrdinal("Primer_Apellido"))} {reader.GetString(reader.GetOrdinal("Segundo_Apellido"))}";
                    identidad.Text = $"{reader.GetString(reader.GetOrdinal("DNI"))}";
                    usuario.Text = $"{reader.GetString(reader.GetOrdinal("Usuario"))}";
                    tpUsuario.Text = $"{reader.GetString(reader.GetOrdinal("Rol"))}";

                    permiso.Text = $"{reader.GetString(reader.GetOrdinal("Permisos"))}";
                    telefono.Text = $"{reader.GetString(reader.GetOrdinal("Numero"))}";

                    correo.Text = $"{reader.GetString(reader.GetOrdinal("Correo"))}";
                    edad.Text = $"{reader.GetInt32(reader.GetOrdinal("Edad"))}";
                    direccion.Text = $"{reader.GetString(reader.GetOrdinal("Referencia"))}, {reader.GetString(reader.GetOrdinal("Ciudad"))}, {reader.GetString(reader.GetOrdinal("Departamento"))}";
                    cargo.Text = $"{reader.GetString(reader.GetOrdinal("Cargo"))}";
                    ss.Text = $"{reader.GetString(reader.GetOrdinal("Num_Seguro"))}";
                    salarioB.Text = $"{reader.GetDecimal(reader.GetOrdinal("Salario_Bruto"))}";
                    salario.Text = $"{reader.GetDecimal(reader.GetOrdinal("Salario_Neto"))}";
                    horario.Text = $"{reader.GetTimeSpan(reader.GetOrdinal("Hora_Inicial"))} - {reader.GetTimeSpan(reader.GetOrdinal("Hora_Final"))}";
                    periodoLab.Text = $"{reader.GetString(reader.GetOrdinal("Periodo_Laboral"))}";
                    periodoPago.Text = $"{reader.GetString(reader.GetOrdinal("Periodo"))}";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error." + ex);
            }

            conn.cerrarConexion();
        }

        private void InformacionPersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
