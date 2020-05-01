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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            DesactivarControles();
        }

        public Empleado(int id, bool editar)
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
            DT = conexion.ExtraeraDataSet("Select * from empleados where idempleado = " + id + "");
            txtnombre.Text = DT.Tables[0].Rows[0]["nombre"].ToString();
            txtapellido.Text = DT.Tables[0].Rows[0]["apellido"].ToString();
            txtcedula.Text = DT.Tables[0].Rows[0]["cedula"].ToString();
            txtEmail.Text = DT.Tables[0].Rows[0]["email"].ToString();
            richtxtDireccion.Text = DT.Tables[0].Rows[0]["Direccion"].ToString();
            txtTelefono.Text = DT.Tables[0].Rows[0]["Telefono"].ToString();
            txtcargo.Text = DT.Tables[0].Rows[0]["Cargo"].ToString();
            txtidempleado.Text = DT.Tables[0].Rows[0]["idempleado"].ToString();
            if (DT.Tables[0].Rows[0]["Sexo"].ToString() == "F")
            {
                radiofemenino.Checked = true;
            }
            else if(DT.Tables[0].Rows[0]["Sexo"].ToString() == "M")
            {
                radiomasculino.Checked = true;
            }
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Empleado empleado = new Clases.Empleado();
            empleado.Nombre = txtnombre.Text;
            empleado.Apellido = txtapellido.Text;
            empleado.Cedula = txtcedula.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.Cargo = txtcargo.Text;
            empleado.Direccion = richtxtDireccion.Text;
            empleado.Email = txtEmail.Text;
            if (radiofemenino.Checked)
            {
                empleado.Sexo = radiofemenino.Text;
            }
            else if (radiomasculino.Checked)
            {
                empleado.Sexo = radiomasculino.Text;
            }
            if (empleado.ObjetoCompleto() == true)
            {
                txtidempleado.Text = empleado.Guardar().ToString();
                Clases.ControlDeDatos.CambiosRealizados();
                DesactivarControles();
                btnNuevo.Visible = true;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }

        }

        private void Empleado_Load(object sender, EventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();
            Limpiar();
            btnNuevo.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcargo.Clear();
            txtcedula.Clear();
            txtEmail.Clear();
            richtxtDireccion.Clear();
            txtidempleado.Clear();
            txtTelefono.Clear();
            richtxtDireccion.Clear();
            if (radiofemenino.Checked)
            {
                radiofemenino.Checked = false;
            }
            else if (radiomasculino.Checked)
            {
                radiomasculino.Checked = false;
            }
        }

        public void DesactivarControles()
        {
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtcargo.Enabled = false;
            txtcedula.Enabled = false;
            txtEmail.Enabled = false;
            richtxtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            radiomasculino.Enabled = false;
            radiofemenino.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Visible = true;
        }

        public void ActivarControles()
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtcargo.Enabled = true;
            txtcedula.Enabled = true;
            txtEmail.Enabled = true;
            richtxtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            radiomasculino.Enabled = true;
            radiofemenino.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Visible = false;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Empleado empleado = new Clases.Empleado();
            empleado.Nombre = txtnombre.Text;
            empleado.Apellido = txtapellido.Text;
            empleado.Cedula = txtcedula.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.Cargo = txtcargo.Text;
            empleado.Direccion = richtxtDireccion.Text;
            empleado.Email = txtEmail.Text;
            empleado.IdEmpleado = Convert.ToInt32(txtidempleado.Text);
            if (radiofemenino.Checked)
            {
                empleado.Sexo = radiofemenino.Text;
            }
            else if (radiomasculino.Checked)
            {
                empleado.Sexo = radiomasculino.Text;
            }
            if (empleado.ObjetoCompleto() == true)
            {
                empleado.Actualizar();
                Clases.ControlDeDatos.CambiosRealizados();
                DesactivarControles();
                btnNuevo.Visible = false;
                btnActualizar.Enabled = false;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
        }

        private void Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.MinimizarVentana(this);
        }
    }
}
