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
    public partial class Login : Form
    {
        public static String ID_Usuario;

        public Login()
        {
            InitializeComponent();
        }

        public Login(int i)
        {
            InitializeComponent();
            txtUser.Text = i.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MenuConsultas abre = new MenuConsultas();
            this.Hide();
            abre.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Conexion conexion = new Clases.Conexion();
            Clases.Usuarios usuario = new Clases.Usuarios();
            DataSet DS;
            bool criteriofinal;
            criteriofinal = usuario.IniciarSesion(txtUser.Text, txtPass.Text);
            if (criteriofinal == true)
            {
                DS = conexion.ExtraeraDataSet("Select * from usuarios where nm_user = '" + txtUser.Text + "'");
                ID_Usuario = DS.Tables[0].Rows[0]["idusuario"].ToString();
                Menu mnu = new Menu();
                this.Hide();
                mnu.Show();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña insertada, no existen en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clases.ControlDeDatos conexion = new Clases.ControlDeDatos();
            conexion.CerrarApp();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.CerrarAplicacion();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.MinimizarVentana(this);
        }
    }
}
