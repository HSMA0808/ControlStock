using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Reportes;
using WindowsFormsApp3.Formularios;
using WindowsFormsApp3.Clases;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnEmpleados.Text);
            MostrarReporte.Show();
        }

        private async void btnArticulos_Click(object sender, EventArgs e)
        {
            btnArticulos.Enabled = false;
            ReporteArticulos reporte = new ReporteArticulos();
            bool impreso = false;
            await Task.Run(() => {Imprimir(reporte, "ReporteDeArticulos"); });
            btnArticulos.Enabled = true;
        }

        private async void btnDepartamentos_Click(object sender, EventArgs e)
        {
            btnDepartamentos.Enabled = false;
            ReporteDepartamento reporte = new ReporteDepartamento();
            bool impreso = false;
            await Task.Run(() => { Imprimir(reporte, "ReporteDeDepartamentos"); });
            btnDepartamentos.Enabled = true;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnProveedores.Text);
            MostrarReporte.Show();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnEntrada.Text);
            MostrarReporte.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnSalida.Text);
            MostrarReporte.Show();
        }

        private void btnDevolucionEntrada_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnDevolucionEntrada.Text);
            MostrarReporte.Show();
        }

        private void btnDevolucionSalida_Click(object sender, EventArgs e)
        {
            Reportes.Reportes MostrarReporte = new Reportes.Reportes(btnDevolucionSalida.Text);
            MostrarReporte.Show();
        }

        private async void Imprimir(ReportDocument rpt, string reportName)
        {
            await Task.Run(() => {
                bool impreso = false;
                var Modal = new ModalLoading("Imprimiendo");
                Modal.Show();
                try
                {
                    DiskFileDestinationOptions diskOptions = new DiskFileDestinationOptions();
                    rpt.Refresh();
                    diskOptions.DiskFileName = ConfigurationManager.AppSettings.Get(reportName) + reportName + "_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".pdf";
                    rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    rpt.ExportOptions.ExportDestinationOptions = diskOptions;
                    rpt.Export();
                    impreso = true;
                    Modal.Close();
                }
                catch (Exception e)
                {
                    Modal.Close();
                    MessageBox.Show("Error", "Descripcion: " + e, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return impreso;
            });
        }
    }
}
