using System;
using System.ComponentModel;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportAppServer.CommLayer;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp3.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        public Reportes(string entidad)
        {
            InitializeComponent();
            switch (entidad)
            {
                case "Empleados":
                CrystalReport1 ReporteEmpleados = new CrystalReport1();
                crystalReportViewer1.ReportSource = ReporteEmpleados;
                crystalReportViewer1.RefreshReport();
                break;

                case "Articulos":
                    ReportDocument reporte = new ReportDocument();                    
                    DiskFileDestinationOptions diskOptions = new DiskFileDestinationOptions();
                    ReporteArticulos reporteArticulos = new ReporteArticulos();
                    //crystalReportViewer1.ReportSource = reporteArticulos;
                    //crystalReportViewer1.
                    //crystalReportViewer1.RefreshReport();
                    diskOptions.DiskFileName = ConfigurationManager.AppSettings.Get("ReporteDeArticulos")+"ReporteDeArticulos_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString()+".pdf";
                    //reporte.SetDataSource(reporteArticulos.Rows);
                    reporte.Load("C:\\Users\\Samuel\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\Reportes\\ReporteArticulos.rpt");
                    reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    reporte.ExportOptions.ExportDestinationOptions = diskOptions;
                    reporte.Export();
                    break;

                case "Departamentos":
                    ReporteDepartamento reporteDepartamentos = new ReporteDepartamento();
                    crystalReportViewer1.ReportSource = reporteDepartamentos;
                    crystalReportViewer1.RefreshReport();
                    break;

                case "Proveedores":
                    ReporteProveedor reporteProveedor = new ReporteProveedor();
                    crystalReportViewer1.ReportSource = reporteProveedor;
                    crystalReportViewer1.RefreshReport();
                    break;

                case "Entrada":
                    ReporteEntrada reporteEntrada = new ReporteEntrada();
                    crystalReportViewer1.ReportSource = reporteEntrada;
                    crystalReportViewer1.RefreshReport();
                    break;

                case "Salida":
                    ReporteSalida reporteSalida = new ReporteSalida();
                    crystalReportViewer1.ReportSource = reporteSalida;
                    crystalReportViewer1.RefreshReport();
                    break;

                case "Devolucion Entrada":
                    ReporteDevEntrada reporteDevEntrada = new ReporteDevEntrada();
                    crystalReportViewer1.ReportSource = reporteDevEntrada;
                    crystalReportViewer1.RefreshReport();
                    break;

                case "Devolucion Salida":
                    ReporteDevSalida reporteDevSalida = new ReporteDevSalida();
                    crystalReportViewer1.ReportSource = reporteDevSalida;
                    crystalReportViewer1.RefreshReport();
                    break;
            }

         }

         private void ReporteEmpleados_Load(object sender, EventArgs e)
         {

         }

        private void CrystalReport1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
