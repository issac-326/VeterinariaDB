using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class SubmodulosAtencionCliente : Form
    {
        private List<string> permisos;
        public SubmodulosAtencionCliente()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos win = new Modulos(permisos);
            win.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GestionMascotas form = new GestionMascotas();
            form.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            GestionMascotas form = new GestionMascotas();
            form.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos(permisos);
            modulos.Show(); 
            this.Hide();
        }
    }
}
