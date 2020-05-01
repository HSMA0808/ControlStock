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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            DesactivarControles();
        }

        public Usuarios(int id, bool editar)
        {
            InitializeComponent();
            if (editar == false)
            {
                DesactivarControles();
                BotonesVisibles(editar);
            }
            else
            {
                ActivarControles();
                BotonesVisibles(editar);
            }
            Clases.Conexion conexion = new Clases.Conexion();
            DataSet DT = new DataSet();
            DT = conexion.ExtraeraDataSet("Select * from usuarios where idusuario = " + id + "");
            txtidusuario.Text = DT.Tables[0].Rows[0]["idusuario"].ToString();
            txtUsuario.Text = DT.Tables[0].Rows[0]["nm_user"].ToString();
            txtcontraseña.Text = DT.Tables[0].Rows[0]["pass_word"].ToString();
            txtidempleado.Text = DT.Tables[0].Rows[0]["idempleado"].ToString();
            combocategoria.Text = DT.Tables[0].Rows[0]["categoria"].ToString();
            DT = conexion.ExtraeraDataSet("select nombre from empleados where idempleado = " + txtidempleado.Text + "");
            txtEmpleado.Text = DT.Tables[0].Rows[0]["nombre"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Usuarios usuarios = new Clases.Usuarios();
            usuarios.nm_user = txtUsuario.Text;
            usuarios.IdEmpleado = usuarios.SiEstaVacioValeCero(txtidempleado.Text);
            usuarios.Categoria = combocategoria.Text;
            usuarios.pass_word = txtcontraseña.Text;
            if (usuarios.ObjetoCompleto() == true)
            {
                txtidusuario.Text = usuarios.Guardar().ToString();
                Clases.ControlDeDatos.CambiosRealizados();
                DesactivarControles();
                btnNuevo.Visible = true;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
        }

        public void ActivarControles()
        {
            txtUsuario.Enabled = true;
            combocategoria.Enabled = true;
            btnbuscar.Enabled = true;
            txtcontraseña.Enabled = true;
            combocategoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Visible = false;
        }

        public void DesactivarControles()
        {
            txtUsuario.Enabled = false;
            combocategoria.Enabled = false;
            txtcontraseña.Enabled = false;
            btnbuscar.Enabled = false;
            combocategoria.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        public void Limpiar()
        {
            txtUsuario.Clear();
            txtidempleado.Clear();
            txtEmpleado.Clear();
            txtcontraseña.Clear();
            txtidusuario.Clear();
        }

        private void BotonesVisibles(bool criterio)
        {
            if (criterio == true)
            {
                btnActualizar.Visible = criterio;
                btnCancelar.Visible = criterio;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnLimpiar.Visible = false;
            }
            else
            {
                btnNuevo.Visible = criterio;
                btnGuardar.Visible = criterio;
                btnLimpiar.Visible = criterio;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();
            btnNuevo.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Empleados", "Select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', cargo as 'Cargo'" +
            ", Telefono as 'Telefono' from empleados");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtEmpleado.Text = seleccion.NombreEntidad;
                txtidempleado.Text = seleccion.IDEntidad.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Usuarios usuarios = new Clases.Usuarios();
            usuarios.nm_user = txtUsuario.Text;
            usuarios.IdEmpleado = usuarios.SiEstaVacioValeCero(txtidempleado.Text);
            usuarios.Categoria = combocategoria.Text;
            usuarios.pass_word = txtcontraseña.Text;
            usuarios.IdUsuario = Convert.ToInt32(txtidusuario.Text);
            if (usuarios.ObjetoCompleto() == true)
            {
                usuarios.Actualizar();
                Clases.ControlDeDatos.CambiosRealizados();
                DesactivarControles();
                btnNuevo.Visible = false;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.MinimizarVentana(this);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
