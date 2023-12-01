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
    public partial class InformacionEmpresa : Form
    {
        private int idSucursal;
        private List<string> permisos;
        public InformacionEmpresa(int idSucursal, List<string> permisos)
        {
            InitializeComponent();
            mostrarInfoEmpresa(idSucursal);
            this.idSucursal = idSucursal;
            this.permisos = permisos;

        }

        private void InformacionEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(permisos, idSucursal);
            modulos.Visible = true;
            this.Close();
        }


        private void mostrarInfoEmpresa(int idSucursal)
        {

            ConexionSqlServer conn = new ConexionSqlServer();

            try
            {
                string query = "SELECT em.Nombre, em.Img, em.RTN, em.Correo_1, em.Correo_2, tef.Numero as 'Numero de la Sucursal', suc.Nombre as 'Sucursal', dep.Nombre as 'Departamento', ciu.Nombre as 'Ciudad', dir.Referencia\r\nFROM Empresas em\r\nINNER JOIN Sucursales suc ON em.Id = suc.Id_Empresa\r\nINNER JOIN Empleados emp ON emp.Id_Sucursal = suc.Id\r\nINNER JOIN Personas per ON per.Id = emp.Id_Persona\r\nINNER JOIN Direcciones dir ON dir.Id = suc.Id_Direccion\r\nINNER JOIN Ciudades ciu ON ciu.Id = dir.Id_Ciudad\r\nINNER JOIN Departamentos dep ON dep.Id = ciu.Id_Departamento\r\nINNER JOIN Usuarios us ON us.Id_Empleado = emp.Id\r\nINNER JOIN Telefonos_Sucursales tef ON suc.Id = tef.Id_Sucursal\r\n WHERE suc.Id = " + idSucursal +"";

                SqlCommand comando = new SqlCommand(query, conn.establecerConexion());
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    if (!reader.IsDBNull(reader.GetOrdinal("Img")))
                    {
                        string nombreImagen = $"{reader.GetString(reader.GetOrdinal("Img"))}";
                        pbEmpresa.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nombreImagen);
                    }
                    else
                    {
                        pbEmpresa.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("logoerp.png");
                    }

                    nombreEmpresa.Text = $"{reader.GetString(reader.GetOrdinal("Nombre"))}";
                    RTN.Text = $"{reader.GetString(reader.GetOrdinal("RTN"))}";
                    Correo1.Text = $"{reader.GetString(reader.GetOrdinal("Correo_1"))}";
                    Correo2.Text = $"{reader.GetString(reader.GetOrdinal("Correo_2"))}";
                    nombreSucursal.Text = $"{reader.GetString(reader.GetOrdinal("Sucursal"))}";
                    Telefono.Text = $"{reader.GetString(reader.GetOrdinal("Numero de la Sucursal"))}";
                    Direccion.Text = $"{reader.GetString(reader.GetOrdinal("Referencia"))}, {reader.GetString(reader.GetOrdinal("Ciudad"))}, {reader.GetString(reader.GetOrdinal("Departamento"))}";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error." + ex);
            }

            conn.cerrarConexion();

        }
    }
}
