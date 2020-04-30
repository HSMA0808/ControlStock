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
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
        }

        public int IDEntidad {get; set;}
        public string NombreEntidad { get; set; }
        public string CampoExtra { get; set; }

        public Seleccion(string Entidad, string Consulta)
        {
            InitializeComponent();
            Clases.Conexion conexion = new Clases.Conexion();
            lblseleccion.Text = Entidad;
            conexion.CargarDataGridView(Consulta, dataGridView1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           IDEntidad = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            NombreEntidad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }*/

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                IDEntidad = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                NombreEntidad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                CampoExtra = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                IDEntidad = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                NombreEntidad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void Seleccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
