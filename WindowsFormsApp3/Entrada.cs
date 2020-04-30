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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
            ControlesActivos(false);
            lblContador.Text = "0";
        }

        public Entrada(int id, bool editar)
        {
            InitializeComponent();
            ControlesActivos(editar);
            btnNuevo.Visible = false;
            DataSet DT = new DataSet();
            Clases.Conexion conexion = new Clases.Conexion();
            DT = conexion.ExtraeraDataSet("Select entradas.identrada, entradas.idproveedor, entradas.conduce, "+
            "entradas.cant_total, proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor where entradas.identrada = " + id + "");
            lblContador.Text = DT.Tables[0].Rows[0]["cant_total"].ToString();
            txtconduce.Text = DT.Tables[0].Rows[0]["conduce"].ToString();
            txtIdEntrada.Text = DT.Tables[0].Rows[0]["identrada"].ToString();
            txtIDProveedor.Text = DT.Tables[0].Rows[0]["idproveedor"].ToString();
            txtproveedor.Text = DT.Tables[0].Rows[0]["proveedor"].ToString();
            DT = conexion.ExtraeraDataSet("Select entradadetail.idarticulo as 'ID Articulo', articulos.nombre_articulo as 'Articulo', " +
            "entradadetail.cantidad as 'Cantidad' from entradadetail join articulos on entradadetail.idarticulo = articulos.idarticulo where entradadetail.numentrada = " + id + "");
            Clases.ControlDeDatos.CargarDetails(dataGridView1, DT);
        }

        private void btnbuscarProveedor_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Proveedores", "Select idproveedor as 'ID', nombre as 'Nombre' from Proveedores");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtproveedor.Text = seleccion.NombreEntidad;
                txtIDProveedor.Text = seleccion.IDEntidad.ToString();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Articulos", "Select idarticulo as 'ID', nombre_articulo as 'Articulo', cantidad as 'Cantidad', " +
          " marca as 'Marca' from articulos where cantidad > 0 ");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtNoArticulo.Text = seleccion.IDEntidad.ToString();
                txtDescripcion.Text = seleccion.NombreEntidad;
                txtcantidad.Text = "1";
                txtcantidad.Focus();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }


        private void LimpiarControles()
        {
            txtIDProveedor.Clear();
            txtproveedor.Clear();
            txtNoArticulo.Clear();
            txtDescripcion.Clear();
            txtcantidad.Clear();
            txtconduce.Clear();
            lblContador.Text = "0";
            Clases.ControlDeDatos.LimpiarDGV(dataGridView1);
        }

        private void LimpiarDataArticulo()
        {
            txtNoArticulo.Clear();
            txtDescripcion.Clear();
            txtcantidad.Clear();
        }

        private void ControlesActivos(bool criterio)
        {
            if (criterio == true)
            {
                txtcantidad.Enabled = criterio;
                btnagregar.Enabled = criterio;
                btnbuscararticulo.Enabled = criterio;
                btnbuscarProveedor.Enabled = criterio;
                btnguardar.Enabled = criterio;
                txtconduce.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                btnNuevo.Enabled = false;
            }
            else
            {
                txtcantidad.Enabled = criterio;
                btnagregar.Enabled = criterio;
                btnbuscararticulo.Enabled = criterio;
                btnbuscarProveedor.Enabled = criterio;
                btnguardar.Enabled = criterio;
                txtconduce.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                btnNuevo.Enabled = true;
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlesActivos(true);
            LimpiarControles();
            txtIdEntrada.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text == string.Empty || txtNoArticulo.Text == string.Empty || txtcantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los datos relacionados al articulo antes de agregarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clases.ControlDeDatos ControlDeDatos = new Clases.ControlDeDatos();
                bool valido;
                valido = ControlDeDatos.YaFueAgregado(txtNoArticulo.Text, txtcantidad.Text, dataGridView1);
                if (valido != true)
                {
                    dataGridView1.Rows.Add(txtNoArticulo.Text, txtDescripcion.Text, txtcantidad.Text);
                }
                lblContador.Text = ControlDeDatos.TotalRegistrado(dataGridView1).ToString();
                LimpiarDataArticulo();   
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Clases.Entrada Entrada = new Clases.Entrada();
            Clases.ControlDeDatos ControlDeDatos = new Clases.ControlDeDatos();
            if (txtIDProveedor.Text == string.Empty || lblContador.Text == string.Empty || txtconduce.Text == string.Empty || dateTimePicker1.Value == null)
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
            else
            {
                Entrada.IdProveedor = Convert.ToInt32(txtIDProveedor.Text);
                Entrada.Fecha = dateTimePicker1.Value;
                Entrada.Conduce = txtconduce.Text;
                Entrada.CantidadTotal = Convert.ToInt32(lblContador.Text);
                Entrada.IdUsuario = Convert.ToInt32(Login.ID_Usuario);
                if (Entrada.ObjetoCompleto() == true)
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        txtIdEntrada.Text = Entrada.Guardar().ToString();
                        ControlDeDatos.GuardarDetails(dataGridView1, Convert.ToInt32(txtIdEntrada.Text), "Entrada");
                        Clases.ControlDeDatos.CambiosRealizados();
                        ControlesActivos(false);
                    }
                    else
                    {
                        MessageBox.Show("Debe registrarse al menos un articulo en la ventana", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Clases.ControlDeDatos.CompleteLosCampos();
                }
            }
        }

        private void Entrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
