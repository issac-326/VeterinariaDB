using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.Class
{
    internal class Crud
    {

        public void guardar(String tabla, String cadena)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {

                String query = "Insert INTO " + tabla + " values (" + cadena + ");";

                SqlCommand comando = new SqlCommand(query, objectConexion.establecerConexion());
                SqlDataReader myReader;

                myReader = comando.ExecuteReader();

                while (myReader.Read())
                {

                }
                MessageBox.Show("Registro guardado");
                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el registro: " + e.ToString());
            }
        }

        public void mostrarData(DataGridView mostrador, String instruccion)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                mostrador.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter(instruccion, objectConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                mostrador.DataSource = dt;

                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("error al cargar los registros: " + e.ToString());
            }
        }
    }
}
