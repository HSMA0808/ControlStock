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
    public partial class MenuProcesos : Form
    {
        public MenuProcesos()
        {
            InitializeComponent();
        }

        private void MenuProcesos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {

            Entrada formentrada = new Entrada();

            this.Hide();

            formentrada.Show();
            
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
           Salidacs formsalidacs = new Salidacs();

            this.Hide();

            formsalidacs.Show();
        }

        private void btnDevEntrada_Click(object sender, EventArgs e)
        {
            DevolucionEntrada devEntrada = new DevolucionEntrada();

            this.Hide();

            devEntrada.Show();
        }

        private void btnDevSalida_Click(object sender, EventArgs e)
        {
            DevolucionSalida devsali = new DevolucionSalida();
            this.Hide();
            devsali.Show();
        }

        private void MenuProcesos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
