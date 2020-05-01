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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LinkEntrada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Entrada abre = new Entrada();
            abre.ShowDialog();
        }

        private void LinkSalida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Salidacs abre = new Salidacs();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            MenuMantenimientos abre = new MenuMantenimientos();
            abre.Show();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            MenuProcesos abre = new MenuProcesos();
            abre.Show();
        }

        private void DGVProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVDepto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            MenuConsultas mnuconsultas = new MenuConsultas();
            mnuconsultas.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

            MenuReportes mnureportes = new MenuReportes();
            mnureportes.Show();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormularioConsultas ConsultaArticulos = new FormularioConsultas(btnStock.Text);
            ConsultaArticulos.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios(Convert.ToInt32(Login.ID_Usuario), true);
            usuario.Show();
        }

        private void LinkEntrada_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.Show();
        }

        private void LinkSalida_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Salidacs salida = new Salidacs();
            salida.Show();
        }

        private void LinkDevEntrada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DevolucionEntrada DevEntrada = new DevolucionEntrada();
            DevEntrada.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.CerrarAplicacion();        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.MinimizarVentana(this);
        }
    }
}
