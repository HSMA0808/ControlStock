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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnEmpleados.Text);
            MostrarReporte.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnArticulos.Text);
            MostrarReporte.Show();

        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnDepartamentos.Text);
            MostrarReporte.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnProveedores.Text);
            MostrarReporte.Show();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnEntrada.Text);
            MostrarReporte.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnSalida.Text);
            MostrarReporte.Show();
        }

        private void btnDevolucionEntrada_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnDevolucionEntrada.Text);
            MostrarReporte.Show();
        }

        private void btnDevolucionSalida_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnDevolucionSalida.Text);
            MostrarReporte.Show();
        }
    }
}
