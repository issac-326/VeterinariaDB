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
    public partial class ControlMascota : Form
    {
        int idMascota = 0;
        public ControlMascota(int idMascotas)
        {
            InitializeComponent();
            this.idMascota = idMascotas;
        }

        private void ControlMascota_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Citas citasForm = new Citas(idMascota);
            citasForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
