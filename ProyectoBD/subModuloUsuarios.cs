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
    public partial class subModuloUsuarios : Form
    {
        public subModuloUsuarios()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos();
            modulos.Visible = true;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios();
            registrarUsuarios.Visible = true;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OtorgarPermisosUsuarios otorgarPermisos = new OtorgarPermisosUsuarios();
            otorgarPermisos.Visible = true; 
            this.Close();
        }
    }
}
