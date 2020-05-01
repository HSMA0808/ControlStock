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
    public partial class DevolucionEntrada : Form
    {
        public DevolucionEntrada()
        {
            InitializeComponent();
            ControlesEstado(false);
        }

        public DevolucionEntrada(int id, bool editar)
        {
            InitializeComponent();
            ControlesEstado(editar);
            btnNuevo.Visible = false;
            DataSet DT = new DataSet();
            Clases.Conexion conexion = new Clases.Conexion();
            DT = conexion.ExtraeraDataSet("Select devolucion_entrada.iddevolucionentrada, devolucion_entrada.numentrada, proveedores.idproveedor, proveedores.nombre, devolucion_entrada.cant_articulos, devolucion_entrada.descripcion, " +
            "entradas.conduce from devolucion_entrada join entradas on devolucion_entrada.numentrada = entradas.identrada join proveedores on entradas.idproveedor = " +
            "proveedores.idproveedor where devolucion_entrada.iddevolucionentrada = " + id + "");
            if (DT.Tables[0].Rows.Count > 0)
            {
                lblContador.Text = DT.Tables[0].Rows[0]["cant_articulos"].ToString();
                txtConduce.Text = DT.Tables[0].Rows[0]["conduce"].ToString();
                txtNoEntrada.Text = DT.Tables[0].Rows[0]["numentrada"].ToString();
                txtProveedor.Text = DT.Tables[0].Rows[0]["nombre"].ToString();
                txtIDProveedor.Text = DT.Tables[0].Rows[0]["idproveedor"].ToString();
                txtIdDevEntrada.Text = DT.Tables[0].Rows[0]["iddevolucionentrada"].ToString();
                txtDescripcion.Text = DT.Tables[0].Rows[0]["descripcion"].ToString();
                DT = conexion.ExtraeraDataSet("Select entradadetail.idarticulo as 'ID Articulo', articulos.nombre_articulo as 'Articulo', " +
                "entradadetail.cantidad as 'Cantidad' from entradadetail join articulos on entradadetail.idarticulo = articulos.idarticulo where entradadetail.numentrada = " + DT.Tables[0].Rows[0]["numentrada"].ToString() + "");
                Clases.ControlDeDatos.CargarDetails(dataGridView2, DT);
            }
            else
            {
                Clases.ControlDeDatos.NoEncontrado();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSupervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtNoEntrada.Text == string.Empty)
            {
                Clases.ControlDeDatos.LleneelCampos();
            }
            else
            {
                DataSet DS;
                Clases.Conexion Conexion = new Clases.Conexion();
                DS = Conexion.ExtraeraDataSet("select entradas.idproveedor as 'ID Proveedor', proveedores.nombre as 'Proveedor', entradas.conduce as 'Conduce', " +
                "entradas.fecha as 'Fecha', entradas.cant_total as 'Total' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor " +
                "where entradas.identrada = '"+txtNoEntrada.Text+"'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    txtIDProveedor.Text = DS.Tables[0].Rows[0]["ID Proveedor"].ToString();
                    txtProveedor.Text = DS.Tables[0].Rows[0]["Proveedor"].ToString();
                    txtConduce.Text = DS.Tables[0].Rows[0]["Conduce"].ToString();
                    dateTimePicker2.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]);
                    txtConduce.Text = DS.Tables[0].Rows[0]["Conduce"].ToString();
                    lblContador.Text = DS.Tables[0].Rows[0]["Total"].ToString();
                    DS = Conexion.ExtraeraDataSet("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Articulo', entradadetail.cantidad as 'Cantidad' " +
                    "from entradadetail join articulos on articulos.idarticulo = entradadetail.idarticulo where entradadetail.numentrada = '" + txtNoEntrada.Text + "'");
                    Clases.ControlDeDatos.CargarDetails(dataGridView2, DS);
                }
                else
                {
                    Clases.ControlDeDatos.NoEncontrado();
                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlesEstado(true);
        }

        private void ControlesEstado(bool criterio)
        {
            if (criterio == false)
            {
                btnbuscar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                txtNoEntrada.Enabled = criterio;
                txtDescripcion.Enabled = criterio;
                btnNuevo.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                txtNoEntrada.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                txtDescripcion.Enabled = criterio;
                btnNuevo.Enabled = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Colocar validacion de un supervisor
            
                if (txtIDProveedor.Text == string.Empty || txtProveedor.Text == string.Empty || txtConduce.Text == string.Empty || txtDescripcion.Text == string.Empty)
                {
                    Clases.ControlDeDatos.CompleteLosCampos();
                }
                else if (dataGridView2.Rows.Count < 1)
                {
                    Clases.ControlDeDatos.SinRegistros();
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro que desea aplicar una devolucion a este entrada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Clases.ControlDeDatos controldedatos = new Clases.ControlDeDatos();
                        Clases.Conexion conexion = new Clases.Conexion();//guardar
                        conexion.EjecutarScript("insert into devolucion_entrada (numentrada, idusuario, fecha, cant_articulos, descripcion ) " +
                        "values (" + txtNoEntrada.Text + ", " + Login.ID_Usuario + ", Convert(char(19), '" + dateTimePicker1.Value.ToShortDateString() + "'), " + Convert.ToInt32(lblContador.Text) + ", '" + txtDescripcion.Text + "')");
                        int i = dataGridView2.Rows.Count;
                        for (int x = 0; x < i; x++)
                        {
                            conexion.EjecutarScript("update articulos set cantidad = cantidad - " + dataGridView2.Rows[x].Cells[2].Value.ToString() + " where idarticulo = " + dataGridView2.Rows[x].Cells[0].Value.ToString() + "");
                        }
                        ControlesEstado(false);
                    }
                }
            
        }

        private void LimpiarControles()
        {
            txtNoEntrada.Clear();
            txtConduce.Clear();
            txtProveedor.Clear();
            txtIDProveedor.Clear();
            txtDescripcion.Clear();
            lblContador.Text = "0";
            dataGridView2.DataSource = null;
        }

        private void DevolucionEntrada_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
