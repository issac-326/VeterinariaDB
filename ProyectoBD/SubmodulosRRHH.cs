namespace ProyectoBD
{
    public partial class SubmodulosRRHH : Form
    {
        private int idSucursal; 
        public SubmodulosRRHH()
        {
            InitializeComponent();
            this.idSucursal = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos();
            modulos.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Modulos modulos1 = new Modulos();
            modulos1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Contratos contratos = new Contratos(2, "", 0);
            contratos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Empleados win = new Empleados(idSucursal);
            win.Show();
            this.Hide();
        }
    }
}
