using ProyectoBD.Class;
using ProyectoBD.SQLConexion;
using System.Data.SqlClient;

namespace ProyectoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            ctrlUsuarios controlador = new ctrlUsuarios();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Debe llenar todos los campos");

            }
            else
            {
                if (controlador.existeUsuario(usuario, contrasenia))
                {
                    // Las credenciales son v�lidas, puedes permitir el acceso
                    List<string> permisos = controlador.ObtenerPermisos(usuario);
                    int idSucursal = controlador.ObtenerIdSucursal(usuario);

                    if (permisos.Count > 0 && idSucursal != -1)
                    {

                    Modulos principal = new Modulos(permisos, idSucursal);
                    principal.Visible = true;
                    this.Hide();
                    }
                    else
                    {
                        // Si el usuario no tiene ning�n permiso
                        MessageBox.Show("El usuario no tiene permisos asignados");
                    }
                }
                else
                {
                    // Las credenciales son inv�lidas, muestra un mensaje de error
                    MessageBox.Show("Usuario o contrase�a incorrectos");
                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}