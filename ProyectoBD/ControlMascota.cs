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
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroConsulta consultasForm = new RegistroConsulta(0, idMascota);
            consultasForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoMascota infForm = new InfoMascota(idMascota);
            infForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionMascotas vista = new GestionMascotas();
            vista.Show();
            this.Hide();
        }
    }
}
