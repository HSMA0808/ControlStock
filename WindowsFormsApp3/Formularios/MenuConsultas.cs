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
    public partial class MenuConsultas : Form
    {
        public MenuConsultas()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaEntrada = new FormularioConsultas(btnEntrada.Text);
            AbreForm(ConsultaEntrada);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaEmpleados = new FormularioConsultas(btnEmpleados.Text);
            AbreForm(ConsultaEmpleados);
        }

        public void AbreForm(Form formulario)
        {
            this.Hide();
            formulario.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaArticulos = new FormularioConsultas(btnArticulos.Text);
            AbreForm(ConsultaArticulos);
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaDepto = new FormularioConsultas(btnDepartamentos.Text);
            AbreForm(ConsultaDepto);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaProveedores = new FormularioConsultas(btnProveedores.Text);
            AbreForm(ConsultaProveedores);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaUser = new FormularioConsultas(btnUsuarios.Text);
            AbreForm(ConsultaUser);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            FormularioConsultas FormularioConsultasalida = new FormularioConsultas(btnSalida.Text);
            AbreForm(FormularioConsultasalida);
        }

        private void btnDevEntrada_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaDevEntrada = new FormularioConsultas(btnDevEntrada.Text);
            AbreForm(ConsultaDevEntrada);
        }

        private void btnDevSalida_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaDevSalida = new FormularioConsultas(btnDevSalida.Text);
            AbreForm(ConsultaDevSalida);
        }

        private void MenuConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
