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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
            Desactivarcontroles();
        }

        public Articulo(int id, bool editar)
        {
            InitializeComponent();
            if (editar == false)
            {
                Desactivarcontroles();
                BotonesVisibles(editar);
            }
            else
            {
                Activarcontroles();
                BotonesVisibles(editar);
            }
            Clases.Conexion conexion = new Clases.Conexion();
            DataSet DT = new DataSet();
            DT = conexion.ExtraeraDataSet("Select * from articulos where idarticulo = " + id + "");
            txtidarticulo.Text = DT.Tables[0].Rows[0]["idarticulo"].ToString();
            txtnombrearticulo.Text = DT.Tables[0].Rows[0]["nombre_articulo"].ToString();
            txtcantidad.Text = DT.Tables[0].Rows[0]["Cantidad"].ToString();
            txtIdProveedor.Text = DT.Tables[0].Rows[0]["idproveedor"].ToString();
            txtMarca.Text = DT.Tables[0].Rows[0]["marca"].ToString();
            txtdescripcion.Text = DT.Tables[0].Rows[0]["Descripcion"].ToString();
            DT = conexion.ExtraeraDataSet("select nombre from proveedores where idproveedor = " + txtIdProveedor.Text + "");
            txtProveedor.Text = DT.Tables[0].Rows[0]["nombre"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Articulos articulo = new Clases.Articulos();
            articulo.Nombre_Articulo = txtnombrearticulo.Text;
            articulo.IdProveedor = articulo.SiEstaVacioValeCero(txtIdProveedor.Text);
            articulo.Marca = txtMarca.Text;
            articulo.Cantidad = articulo.SiEstaVacioValeCero(txtcantidad.Text);
            articulo.Descripcion = txtdescripcion.Text;
            if (articulo.ObjetoCompleto() == true)
            {
                txtidarticulo.Text = articulo.Guardar().ToString();
                Clases.ControlDeDatos.CambiosRealizados();
                Desactivarcontroles();
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
        }
        
        public void Activarcontroles()
        {
            txtnombrearticulo.Enabled=true;
            txtMarca.Enabled = true;
            btnbuscar.Enabled = true;
            txtcantidad.Enabled = true;
            txtdescripcion.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Visible = false;

        }

        public void Desactivarcontroles()

        {
            txtnombrearticulo.Enabled = false;
            txtMarca.Enabled = false;
            btnbuscar.Enabled = false;
            txtcantidad.Enabled = false;
            txtdescripcion.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Visible = true;
        }
        public void Limpiar()

        {
            txtnombrearticulo.Clear();
            txtIdProveedor.Clear();
            txtMarca.Clear();
            txtcantidad.Clear();
            txtdescripcion.Clear();
            txtProveedor.Clear();
            txtidarticulo.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Activarcontroles();
            Limpiar();
            btnNuevo.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            //Desactivarcontroles();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Proveedores", "Select idproveedor as 'ID', nombre as 'Nombre' from Proveedores");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtProveedor.Text = seleccion.NombreEntidad;
                txtIdProveedor.Text = seleccion.IDEntidad.ToString(); ;
            }
        }

        private void BotonesVisibles(bool criterio)
        {
            if (criterio == true)
            {
                btnActualizar.Visible = criterio;
                btnCancelar.Visible = criterio;
                btnbuscar.Visible = criterio;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnLimpiar.Visible = false;
                txtcantidad.Visible = false;
                lblcantidad.Visible = false;
            }
            else
            {
                btnbuscar.Visible = criterio;
                btnNuevo.Visible = criterio;
                btnGuardar.Visible = criterio;
                btnLimpiar.Visible = criterio;
                txtcantidad.Visible = criterio;
                lblcantidad.Visible = criterio;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var articulo = new Clases.Articulos();
            articulo.IdArticulos = Convert.ToInt32(txtidarticulo.Text);
            articulo.IdProveedor = articulo.SiEstaVacioValeCero(txtIdProveedor.Text);
            articulo.Nombre_Articulo = txtnombrearticulo.Text;
            articulo.Marca = txtMarca.Text;
            articulo.Cantidad = articulo.SiEstaVacioValeCero(txtcantidad.Text);
            if (articulo.ObjetoCompleto() == true)
            {
                articulo.Actualizar();
                Clases.ControlDeDatos.CambiosRealizados();
                Desactivarcontroles();
                btnNuevo.Visible = false;
                btnActualizar.Enabled = false;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
        }

        private void Articulo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtnombrearticulo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
