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
                    string rol = controlador.ObtenerRol(usuario);

                    if (rol == "Administrador")
                    {
                        // Usuario es un administrador
                        MessageBox.Show("Inicio de sesi�n exitoso como Administrador");
                        Modulos principal = new Modulos();
                        principal.Visible = true;
                        this.Hide();
                    }
                    else if (rol == "Usuario Normal")
                    {
                        // Usuario es un usuario normal
                        MessageBox.Show("Inicio de sesi�n exitoso como Usuario Normal");
                    }
                    else
                    {
                        // Rol desconocido
                        MessageBox.Show("Inicio de sesi�n exitoso, pero rol desconocido");
                    }
                }
                else
                {
                    // Las credenciales son inv�lidas, muestra un mensaje de error
                    MessageBox.Show("Usuario o contrase�a incorrectos");
                }
            }

            
        }
    }

}