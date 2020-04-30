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
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
            ControlesActivos(false);
        }

        public Departamento(int id, bool Editar)
        {
            InitializeComponent();
            ControlesActivos(Editar);
            BotonesVisibles(Editar);
            Clases.Conexion conexion = new Clases.Conexion();
            DataSet DT = new DataSet();
            DT = conexion.ExtraeraDataSet("Select * from departamentos where iddepartamento = " + id + "");
            txtidDepartamento.Text = DT.Tables[0].Rows[0]["iddepartamento"].ToString();
            txtnomdepto.Text = DT.Tables[0].Rows[0]["nombredepto"].ToString();
            txtidempleado.Text = DT.Tables[0].Rows[0]["idempleado"].ToString();
            DT = conexion.ExtraeraDataSet("select nombre + ' ' + apellido as 'Nombre' from empleados where idempleado = " + txtidempleado.Text + "");
            txtsupervisor.Text = DT.Tables[0].Rows[0]["Nombre"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var departamentos = new Clases.Departamentos();
            departamentos.IdEmpleado = departamentos.SiEstaVacioValeCero(txtidempleado.Text);
            departamentos.NombreDepto = txtnomdepto.Text;
            if (departamentos.ObjetoCompleto() == true)
            {
                txtidDepartamento.Text = departamentos.Guardar().ToString();
                Clases.ControlDeDatos.CambiosRealizados();
                ControlesActivos(false);
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion("Empleados", "Select idempleado as 'ID', nombre +' '+ apellido as 'Nombre'," +
            " cargo as 'Cargo', telefono as 'Telefono' from empleados");
            seleccion.ShowDialog();
            if (seleccion.DialogResult == DialogResult.OK)
            {
                txtidempleado.Text = seleccion.IDEntidad.ToString();
                txtsupervisor.Text = seleccion.NombreEntidad;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlesActivos(bool criterio)
        {
            if (criterio == true)
            {
                txtnomdepto.Enabled = criterio;
                btnbuscar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                btnNuevo.Visible = false;
            }
            else
            {
                txtnomdepto.Enabled = criterio;
                btnbuscar.Enabled = criterio;
                btnGuardar.Enabled = criterio;
                btnLimpiar.Enabled = criterio;
                btnNuevo.Visible = true;
            }

        }

        private void BotonesVisibles(bool criterio)
        {
            if (criterio == false)
            {
                btnbuscar.Visible = criterio;
                btnGuardar.Visible = criterio;
                btnLimpiar.Visible = criterio;
                btnNuevo.Visible = criterio;
                btnCancelar.Visible = criterio;
            }
            else
            {
                btnbuscar.Visible = criterio;
                btnGuardar.Visible = false;
                btnActualizar.Visible = criterio;
                btnCancelar.Visible = criterio;
                btnLimpiar.Visible = false;
                btnNuevo.Visible = false;
            }
 
        }

        private void lblsupervisor_Click(object sender, EventArgs e)
        {

        }

        private void txtsupervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlesActivos(true);
            Limpiar();
        }

        private void Departamento_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var departamentos = new Clases.Departamentos();
            departamentos.IdDepartamento = Convert.ToInt32(txtidDepartamento.Text);
            departamentos.IdEmpleado = departamentos.SiEstaVacioValeCero(txtidempleado.Text);
            departamentos.NombreDepto = txtnomdepto.Text;
            if (departamentos.ObjetoCompleto() == true)
            {
                departamentos.Actualizar();
                Clases.ControlDeDatos.CambiosRealizados();
                ControlesActivos(false);
                btnNuevo.Visible = false;
                btnActualizar.Enabled = false;
            }
            else
            {
                Clases.ControlDeDatos.CompleteLosCampos();
            }

        }

        private void Departamento_FormClosing(object sender, FormClosingEventArgs e)
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
            Limpiar();
        }
        private void Limpiar()
        {
            txtidDepartamento.Clear();
            txtidempleado.Clear();
            txtnomdepto.Clear();
            txtsupervisor.Clear();
        }
    }
}
