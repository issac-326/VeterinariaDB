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
        private List<string> permisos;
        private int idSucursal;
        private int idPersona;
        public ControlMascota(int idMascotas, List<string>permisos, int idSucursal, int idPersona)
        {
            InitializeComponent();
            this.idMascota = idMascotas;
            this.permisos = permisos;
        }

        private void ControlMascota_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Citas citasForm = new Citas(idMascota, permisos, idSucursal,idPersona);
            citasForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroConsulta consultasForm = new RegistroConsulta(0, idMascota, permisos, idSucursal, idPersona);
            consultasForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoMascota infForm = new InfoMascota(idMascota, permisos, idSucursal, idPersona);
            infForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionMascotas vista = new GestionMascotas(permisos, idSucursal, idPersona);
            vista.Show();
            this.Hide();
        }
    }
}
