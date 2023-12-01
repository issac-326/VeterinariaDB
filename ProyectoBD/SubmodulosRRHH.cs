namespace ProyectoBD
{
    public partial class SubmodulosRRHH : Form
    {
        private List<string> permisos;
        private int idSucursal; 
        public SubmodulosRRHH(int idSucursal, List<string> permisos)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            this.permisos = permisos;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(permisos, idSucursal);
            modulos.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Modulos modulos1 = new Modulos(permisos, idSucursal);
            modulos1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Contratos contratos = new Contratos(idSucursal,"", 2, permisos);
            contratos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Empleados win = new Empleados(permisos, idSucursal);
            win.Show();
            this.Hide();
        }
    }
}
