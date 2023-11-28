using ProyectoBD.SQLConexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.Class
{
    internal class ctrlUsuarios
    {

        //Verificar si existe el usuario en la base de datos
        public bool existeUsuario(string usuario, string contrasenia)
        {
            // Encripta la contraseña antes de compararla con la base de datos
            string contraseniaEncriptada = EncriptarContrasenia(contrasenia);
            ConexionSqlServer objectConexion = new ConexionSqlServer();

            // Realiza la consulta a la base de datos
            using (SqlConnection conexion = objectConexion.establecerConexion())
            {

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = '"+usuario+"' AND Contrasenia = '"+ contrasenia + "'";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
        }


        //Encriptar la contraseña
        public string EncriptarContrasenia(string contrasenia)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasenia));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }


        public string ObtenerRol(string usuario)
        {
            ConexionSqlServer objectConexion = new ConexionSqlServer();
            {
                using (SqlConnection conexion = objectConexion.establecerConexion())
                {

                    string query = "SELECT r.Nombre FROM Roles r INNER JOIN Usuarios u ON r.Id = u.Id_Roles WHERE u.Usuario = '"+usuario+"'";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {

                        ///Ejecuta la consulta y devuelve un solo valor que en este caso es el nombre del Rol
                        object result = comando.ExecuteScalar();

                        ///Verifica si el resultado no es nulo y, en caso afirmativo, lo convierte a una cadena y lo devuelve. Si el resultado es nulo, devuelve null.
                        return result != null ? result.ToString() : null;
                    }
                }
            }
        }

    }
}
