namespace ProyectoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            Modulos form2 = new Modulos();

            // Mostrar el segundo formulario
            form2.Show();

            // Opcionalmente, ocultar el primer formulario
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}