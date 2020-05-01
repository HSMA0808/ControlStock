using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MenuMantenimientos : Form
    {
      
        public MenuMantenimientos()
        {
            InitializeComponent();
        }

        private void MenuMantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            this.Hide();
            empleado.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            this.Hide();
            art.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            this.Hide();
            proveedor.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            this.Hide();
            usuarios.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            Departamento depto = new Departamento();
            this.Hide();
            depto.Show();
        }

        private void MenuMantenimientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
