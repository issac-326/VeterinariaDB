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
    public partial class InfoMascota : Form
    {
        int idMascota = 0;
        public InfoMascota(int id)
        {
            InitializeComponent();
            idMascota = id;
            String cadenaResponsables = "SELECT Personas.Primer_Nombre AS Nombre, Personas.Primer_Apellido AS Apellido, Personas.DNI AS Dni FROM Mascotas  JOIN Responsables_Mascotas ON Mascotas.Id = Responsables_Mascotas.Id_Mascota JOIN Personas ON Responsables_Mascotas.Id_Persona = Personas.Id WHERE Mascotas.Id = " + idMascota + ";";
            Class.Crud objetoCrud = new Class.Crud();
            String cadenaVacunas = $"SELECT Mascotas.Nombre AS NombreMascota, Productos.Nombre AS NombreVacuna, Carnet_Vacunas.Fecha AS FechaAplicacion FROM Carnet_Vacunas JOIN Mascotas ON Carnet_Vacunas.Id_Macota = Mascotas.Id JOIN Vacunas_Aplicadas ON Carnet_Vacunas.Id = Vacunas_Aplicadas.Id_Carnet JOIN Productos ON Vacunas_Aplicadas.Id_Vacuna = Productos.Id JOIN Formas_Farmaceuticas ON Productos.Id_Forma = Formas_Farmaceuticas.Id WHERE Mascotas.Id = {idMascota} AND Formas_Farmaceuticas.Id = 3;";
            objetoCrud.mostrarData(mostradorResponsables, cadenaResponsables);
            objetoCrud.mostrarData(mostradorVacunas, cadenaVacunas);
        }

        private void InfoMascota_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
