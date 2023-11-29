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
                    // Las credenciales son válidas, puedes permitir el acceso
                    string permiso = controlador.ObtenerPermiso(usuario);

                    Modulos principal = new Modulos(permiso);
                    principal.Visible = true;
                    this.Hide();

                }
                else
                {
                    // Las credenciales son inválidas, muestra un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

            
        }
    }

}