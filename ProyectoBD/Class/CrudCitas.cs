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
    internal class CrudCitas : ConexionSqlServer
    {

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
                MessageBox.Show("Error al cargar los registros: " + e.ToString());
            }
        }

        public void guardarCitas(String tabla1, String cadenaC)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {

                String query = "Insert INTO " + tabla1 + " values (" + cadenaC + ");";

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


        public int ObtenerIdCitaReciente()
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                string query = "SELECT MAX(Id) FROM Citas;"; 

                using (SqlCommand cmd = new SqlCommand(query, objectConexion.establecerConexion()))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;  // Si no se encuentra ningún valor, devolver -1
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al obtener el ID de la cita reciente: " + e.ToString());
                return -1;
            }
            finally
            {
                objectConexion.cerrarConexion();
            }
        }


        public void guardarEstadosCitas(String tabla2, String cadenaE)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {

                String query = "Insert INTO " + tabla2 + " values (" + cadenaE + ");";

                SqlCommand comando = new SqlCommand(query, objectConexion.establecerConexion());
                SqlDataReader myReader;

                myReader = comando.ExecuteReader();

                while (myReader.Read())
                {

                }
                //MessageBox.Show("Registro guardado");
                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el registro: " + e.ToString());
            }
        }


        public void editarCitas(String tabla, String cadena, int id)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                String query = "UPDATE " + tabla + " set " + cadena + " WHERE Id = " + id + ";";
                SqlCommand comando = new SqlCommand(query, objectConexion.establecerConexion());
                SqlDataReader myReader;
                myReader = comando.ExecuteReader();
                while (myReader.Read())
                {

                }
                MessageBox.Show("Se modifico la cita" + query +"");
                objectConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al modificar el registro: " + e.ToString());
            }
        }

    }
}
