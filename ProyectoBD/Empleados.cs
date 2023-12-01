using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.Class;

namespace ProyectoBD
{
    public partial class Empleados : Form
    {
        private int idSucursal;
        private Crud objetoCrud;
        private List<string> permisos;

        public Empleados(int idSucursal, List<string> permisos)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            this.objetoCrud = new Crud();
            this.permisos = permisos;
            mostrarInfo();

            dataGridViewEmpleados.CellDoubleClick += infoEmpleado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void mostrarInfo()
        {
            string query = $"SELECT Empleados.Id, DNI, Primer_Nombre as Nombre, Primer_Apellido as Apellido, Tipos_Empleados.Nombre as Cargo, Telefonos_Personas.Numero" +
                $" FROM Empleados " +
                $"INNER JOIN Personas ON (Empleados.Id_Persona = Personas.Id) " +
                $"INNER JOIN (Contratos INNER JOIN Tipos_Empleados ON (Contratos.Id_Tipo = Tipos_Empleados.Id)) " +
                $"ON (Empleados.Id_Contrato = Contratos.Id) " +
                $"INNER JOIN Telefonos_Personas ON (Personas.Id = Telefonos_Personas.Id_Persona) " +
                $"WHERE Id_Sucursal = {idSucursal}";
            objetoCrud.mostrarData(dataGridViewEmpleados, query);
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubmodulosRRHH win = new SubmodulosRRHH(idSucursal, permisos);
            win.Show();
            this.Hide();
        }

        private void infoEmpleado(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que el clic se haya realizado en una fila válida
            {
                DataGridViewRow row = dataGridViewEmpleados.Rows[e.RowIndex];
                int idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

                InfoEmpleados nuevoFormulario = new InfoEmpleados(idSeleccionado, idSucursal, permisos);
                nuevoFormulario.Show();
                this.Hide();
            }
        }
    }
}
