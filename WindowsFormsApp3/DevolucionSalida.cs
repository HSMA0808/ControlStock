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
    public partial class DevolucionSalida : Form
    {
        public DevolucionSalida()
        {
            InitializeComponent();
            ControlesEstado(false);
        }

        public DevolucionSalida(int id, bool editar)
        {
            InitializeComponent();
            ControlesEstado(editar);
            btnNuevo.Visible = false;
            DataSet DT = new DataSet();
            Clases.Conexion conexion = new Clases.Conexion();
            DT = conexion.ExtraeraDataSet("Select devolucion_Salida.iddevolucionsalida, devolucion_salida.numsalida, departamentos.iddepartamento, departamentos.nombredepto, devolucion_salida.cant_articulos, devolucion_salida.descripcion, " +
            "empleados.nombre + ' ' +  empleados.Apellido as 'Supervisor' from devolucion_salida join salidas on devolucion_salida.numsalida = salidas.idsalida join departamentos on salidas.iddepartamento = " +
            "departamentos.iddepartamento join empleados on departamentos.idempleado = empleados.idempleado where devolucion_salida.iddevolucionsalida = " + id + "");
            if (DT.Tables[0].Rows.Count > 0)
            {
                lblContador.Text = DT.Tables[0].Rows[0]["cant_articulos"].ToString();
                txtSupervisor.Text = DT.Tables[0].Rows[0]["supervisor"].ToString();
                txtNoSalida.Text = DT.Tables[0].Rows[0]["numsalida"].ToString();
                txtdepartamento.Text = DT.Tables[0].Rows[0]["nombredepto"].ToString();
                txtIDDepto.Text = DT.Tables[0].Rows[0]["iddepartamento"].ToString();
                txtIdDevSalida.Text = DT.Tables[0].Rows[0]["iddevolucionsalida"].ToString();
                txtDescripcion.Text = DT.Tables[0].Rows[0]["descripcion"].ToString();
                DT = conexion.ExtraeraDataSet("Select salidadetail.idarticulo as 'ID Articulo', articulos.nombre_articulo as 'Articulo', " +
                "salidadetail.cantidad as 'Cantidad' from salidadetail join articulos on salidadetail.idarticulo = articulos.idarticulo where salidadetail.numsalida = " + DT.Tables[0].Rows[0]["numsalida"].ToString() + "");
                Clases.ControlDeDatos.CargarDetails(dataGridView1, DT);
            }
            else
            {
                Clases.ControlDeDatos.NoEncontrado();
            }

        }

        private void btnnoarticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlesEstado(true);
            LimpiarControles();
        }

        private void ControlesEstado(bool criterio)
        {
            if (criterio == false)
            {
                btnbuscar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                txtNoSalida.Enabled = criterio;
                txtDescripcion.Enabled = criterio;
                btnNuevo.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                txtNoSalida.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                txtDescripcion.Enabled = criterio;
                btnNuevo.Enabled = false;
            }

        }

        private void LimpiarControles()
        {
            txtNoSalida.Clear();
            txtSupervisor.Clear();
            txtIDDepto.Clear();
            txtdepartamento.Clear();
            txtDescripcion.Clear();
            lblContador.Text = "0";
            dataGridView1.DataSource = null;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

                if (txtdepartamento.Text == string.Empty || txtIDDepto.Text == string.Empty || txtSupervisor.Text == string.Empty || txtDescripcion.Text == string.Empty || dataGridView1.Rows.Count < 1)
                {
                    Clases.ControlDeDatos.CompleteLosCampos();
                }
                else if (dataGridView1.Rows.Count < 1)
                {
                    Clases.ControlDeDatos.SinRegistros();
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro que desea aplicar una devoluacion a este entrada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Clases.ControlDeDatos controldedatos = new Clases.ControlDeDatos();
                        Clases.Conexion conexion = new Clases.Conexion();//guardar
                        conexion.EjecutarScript("insert into devolucion_salida (numsalida, idusuario, fecha, cant_articulos, descripcion ) " +
                        "values (" + txtNoSalida.Text + ", " + Login.ID_Usuario + ", Convert(char(19), '" + dateTimePicker1.Value.ToShortDateString() + "'), " + lblContador.Text + ", '" + txtDescripcion.Text + "')");
                        int i = dataGridView1.Rows.Count;
                        for (int x = 0; x < i; x++)
                        {
                            conexion.EjecutarScript("update articulos set cantidad = cantidad + " + dataGridView1.Rows[x].Cells[2].Value.ToString() + " where idarticulo = " + dataGridView1.Rows[x].Cells[0].Value.ToString() + "");
                        }
                        ControlesEstado(false);
                    }
                }
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtNoSalida.Text == string.Empty)
            {
                Clases.ControlDeDatos.LleneelCampos();
            }
            else
            {
                DataSet DS;
                Clases.Conexion Conexion = new Clases.Conexion();
                DS = Conexion.ExtraeraDataSet("select salidas.iddepartamento as 'ID Departamento', Departamentos.nombredepto as 'Departamento', empleados.nombre+' '+empleados.apellido as 'Supervisor', " +
                "salidas.fecha as 'Fecha', salidas.cant_total as 'Total' from salidas join departamentos on salidas.iddepartamento = departamentos.iddepartamento join empleados on departamentos.idempleado = empleados.idempleado " +
                "where salidas.idsalida = '" + txtNoSalida.Text + "'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    txtIDDepto.Text = DS.Tables[0].Rows[0]["ID Departamento"].ToString();
                    txtdepartamento.Text = DS.Tables[0].Rows[0]["Departamento"].ToString();
                    txtSupervisor.Text = DS.Tables[0].Rows[0]["Supervisor"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]);
                    lblContador.Text = DS.Tables[0].Rows[0]["Total"].ToString();
                    DS = Conexion.ExtraeraDataSet("select salidadetail.idarticulo as 'ID Articulo', articulos.nombre_articulo as 'Articulo', salidadetail.cantidad as 'Cantidad' " +
                    "from salidadetail join articulos on articulos.idarticulo = salidadetail.idarticulo where salidadetail.numsalida = '" + txtNoSalida.Text + "'");
                    Clases.ControlDeDatos.CargarDetails(dataGridView1, DS);
                }
                else
                {
                    Clases.ControlDeDatos.NoEncontrado();
                }
            }
        }

        private void DevolucionSalida_FormClosing(object sender, FormClosingEventArgs e)
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