﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.SQLConexion
{
    internal class ConexionSqlServer
    {
        SqlConnection conex = new SqlConnection();

        static String servidor = "localhost";
        static String usuario = "root";
        static String contrasenia = "root";
        static String puerto = "1433";
        static String db = "Veterinarias";
        String cadenaConexion;

        public ConexionSqlServer()
        {
            cadenaConexion = $"Data Source={servidor},{puerto};User ID={usuario};Password={contrasenia};Initial Catalog={db};Persist Security Info=True";
        }

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conexion a la bd");
            }

            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
