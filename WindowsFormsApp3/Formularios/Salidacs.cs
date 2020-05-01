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
    public partial class Salidacs : Form
    {
        public Salidacs()
        {
            InitializeComponent();
            ControlesActivos(false);
            lblContador.Text = "0";
        }
        public Salidacs(int id, bool editar)
        {
            InitializeComponent();
            ControlesActivos(editar);
            btnNuevo.Visible = false;
            DataSet DT = new DataSet();
            Clases.Conexion conexion = new Clases.Conexion();
            DT = conexion.ExtraeraDataSet("Select salidas.idsalida, salidas.iddepartamento, departamentos.nombredepto, salidas.cant_total, "+
            "empleados.nombre + ' ' +  empleados.Apellido as 'Supervisor' from salidas join departamentos on salidas.iddepartamento = "+
            "departamentos.iddepartamento join empleados on departamentos.idempleado = empleados.idempleado where salidas.idsalida = " + id + "");
            lblContador.Text = DT.Tables[0].Rows[0]["cant_total"].ToString();
            txtSupervisor.Text = DT.Tables[0].Rows[0]["supervisor"].ToString();
            txtIdSalida.Text = DT.Tables[0].Rows[0]["idsalida"].ToString();
            txtDepartamento.Text = DT.Tables[0].Rows[0]["nombredepto"].ToString();
            txtIDDepto.Text = DT.Tables[0].Rows[0]["iddepartamento"].ToString();
            DT = conexion.ExtraeraDataSet("Select salidadetail.idarticulo as 'ID Articulo', articulos.nombre_articulo as 'Articulo', " +
            "salidadetail.cantidad as 'Cantidad' from salidadetail join articulos on salidadetail.idarticulo = articulos.idarticulo where salidadetail.numsalida = " + id + "");
            Clases.ControlDeDatos.CargarDetails(dataGridView1, DT);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Departamentos", "Select departamentos.iddepartamento as 'ID', departamentos.nombredepto as 'Departamento', " +
            "empleados.nombre +' '+ empleados.apellido as 'Supervisor' from Departamentos join Empleados on empleados.idempleado = departamentos.idempleado");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtIDDepto.Text = seleccion.IDEntidad.ToString();
                txtDepartamento.Text = seleccion.NombreEntidad;
                txtSupervisor.Text = seleccion.CampoExtra;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Articulos", "Select idarticulo as 'ID', nombre_articulo as 'Articulo', cantidad as 'Cantidad', " +
            " marca as 'Marca', descripcion as 'Descripcion' from articulos where cantidad > 0 ");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtnoarticulo.Text = seleccion.IDEntidad.ToString();
                txtDescripcion.Text = seleccion.NombreEntidad;
                txtCantidad.Text = "1";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salidacs_Load(object sender, EventArgs e)
        {

        }

        private void ControlesActivos(bool criterio)
        {
            if (criterio == true)
            {
                txtCantidad.Enabled = criterio;
                btnagregar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                btnBuscarArticulo.Enabled = criterio;
                btnBuscarDepto.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                btnNuevo.Enabled = false;
            }
            else
            {
                txtCantidad.Enabled = criterio;
                btnagregar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                btnBuscarArticulo.Enabled = criterio;
                btnBuscarDepto.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                btnNuevo.Enabled = true;
            }
        }

        private void LimpiarControles()
        {
            txtnoarticulo.Clear();
            txtDescripcion.Clear();
            txtDepartamento.Clear();
            txtIDDepto.Clear();
            txtCantidad.Clear();
            txtSupervisor.Clear();
            Clases.ControlDeDatos.LimpiarDGV(dataGridView1);
        }

        private void LimpiarDataArticulos()
        {
            txtnoarticulo.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlesActivos(true);
            LimpiarControles();
            txtIdSalida.Clear();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty || txtnoarticulo.Text == string.Empty || txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los datos relacionados al articulo antes de agregarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clases.ControlDeDatos ControlDeDatos = new Clases.ControlDeDatos();
                bool valido;
                valido = ControlDeDatos.YaFueAgregado(txtnoarticulo.Text, txtCantidad.Text, dataGridView1);
                if (valido != true)
                {
                    dataGridView1.Rows.Add(txtnoarticulo.Text, txtDescripcion.Text, txtCantidad.Text);
                }
                lblContador.Text = ControlDeDatos.TotalRegistrado(dataGridView1).ToString();
                LimpiarDataArticulos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Salida Salida = new Clases.Salida();
            Clases.ControlDeDatos ControlDeDatos = new Clases.ControlDeDatos();
            if (txtDepartamento.Text == string.Empty || txtIDDepto.Text == string.Empty || txtSupervisor.Text == string.Empty || dateTimePicker1.Value == null)
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
            else
            {
                Salida.IdDepart = Convert.ToInt32(txtIDDepto.Text);
                Salida.Fecha = dateTimePicker1.Value;
                Salida.CantidadTotal = Convert.ToInt32(lblContador.Text);
                Salida.IdUsuario = Convert.ToInt32(Login.ID_Usuario);
                if (Salida.ObjetoCompleto() == true)
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        txtIdSalida.Text = Salida.Guardar().ToString();
                        ControlDeDatos.GuardarDetails(dataGridView1, Convert.ToInt32(txtIdSalida.Text), "Salida");
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

        private void Salidacs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
