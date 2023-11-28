using ProyectoBD.SQLConexion;
using System;
using System.Collections;
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

                String query = "Insert INTO " + tabla + " Values (" + cadena + ");";

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
                MessageBox.Show("Error al guardar el registro");
            }
        }

        public void guardarSinNotificacion(String tabla, String cadena)
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
                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el registro:");

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

        public void editar(String tabla, String cadena, int id)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                String query = "UPDATE " + tabla +" set " + cadena + " WHERE Id = " + id +";";

                SqlCommand comando = new SqlCommand(query, objectConexion.establecerConexion());
                SqlDataReader myReader;

                myReader = comando.ExecuteReader();

                while (myReader.Read())
                {

                }
                MessageBox.Show("Se modifico "+ tabla + " con codigo: " + id);
                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("error al modificar el registro: " + e.ToString());
            }
        }

        public void eliminar(String tabla, int id)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            try
            {
                String query = "DELETE FROM " + tabla + " WHERE Id = " + id + ";";

                SqlCommand comando = new SqlCommand(query, objectConexion.establecerConexion());
                SqlDataReader myReader;

                myReader = comando.ExecuteReader();

                while (myReader.Read())
                {

                }
                MessageBox.Show("Se elimino " + tabla + " con codigo: " + id);
                objectConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("error al eliminar el registro: " + e.ToString());
            }
        }


    }
}
