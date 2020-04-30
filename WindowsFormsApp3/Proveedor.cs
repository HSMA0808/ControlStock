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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            DesactivarControles();
        }

        public Proveedor(int id, bool editar)
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
            DT = conexion.ExtraeraDataSet("Select * from proveedores where idproveedor = " + id + "");
            txtIdProveedor.Text = DT.Tables[0].Rows[0]["idproveedor"].ToString();
            txtnombre.Text = DT.Tables[0].Rows[0]["nombre"].ToString();
            txtemail.Text = DT.Tables[0].Rows[0]["Email"].ToString();
            txtrnc.Text = DT.Tables[0].Rows[0]["rnc"].ToString();
            txttelefono1.Text = DT.Tables[0].Rows[0]["tel1"].ToString();
            txttelefono2.Text = DT.Tables[0].Rows[0]["tel2"].ToString();
            txtdireccion.Text = DT.Tables[0].Rows[0]["direccion"].ToString();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Proveedores proveedores = new Clases.Proveedores();
            proveedores.Nombre = txtnombre.Text;
            proveedores.RNC = txtrnc.Text;
            proveedores.Telefono1 = txttelefono1.Text;
            proveedores.Telefono2 = txttelefono2.Text;
            proveedores.Direccion = txtdireccion.Text;
            proveedores.Email = txtemail.Text;
            if (proveedores.ObjetoCompleto() == true)
            {
                txtIdProveedor.Text = proveedores.Guardar().ToString();
                Clases.ControlDeDatos.CambiosRealizados();
                DesactivarControles();
                btnNuevo.Visible = true;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }

        }

        public void LimpiarControles()
        {
            txtnombre.Clear();
            txtdireccion.Clear();
            txtrnc.Clear();
            txttelefono1.Clear();
            txttelefono2.Clear();
            txtemail.Clear();
    
        }

        public void ActivarControles()
        {
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txtrnc.Enabled = true;
            txttelefono1.Enabled = true;
            txttelefono2.Enabled = true;
            txtemail.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Visible = false;

        }
        public void DesactivarControles()
        {
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            txtrnc.Enabled = false;
            txttelefono1.Enabled = false;
            txttelefono2.Enabled = false;
            txtemail.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();
            LimpiarControles();
            btnNuevo.Visible = false;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {     
        }

        private void txtemail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Clases.Proveedores proveedores = new Clases.Proveedores();
            proveedores.Nombre = txtnombre.Text;
            proveedores.RNC = txtrnc.Text;
            proveedores.Telefono1 = txttelefono1.Text;
            proveedores.Telefono2 = txttelefono2.Text;
            proveedores.Direccion = txtdireccion.Text;
            proveedores.Email = txtemail.Text;
            proveedores.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
            if (proveedores.ObjetoCompleto() == true)
            {
                proveedores.Actualizar();
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

        private void Proveedor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
