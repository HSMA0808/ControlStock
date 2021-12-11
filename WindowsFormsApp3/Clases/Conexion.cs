using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp3.Clases
{
    class Conexion
    {
        private SqlCommand Comando;
        private SqlDataAdapter Adaptador;
        private DataTable Tabla;
        private SqlConnection Conexion1 = new SqlConnection(ConfigurationManager.ConnectionStrings["ControlStockString"].ConnectionString.ToString());
       
        //Metodo para abrir la conexion 
        private void Conectar(SqlConnection Conex)
        {
            try
            {
                Conex.Open();
            }
            catch (Exception X)
            {
                Conex.Close();
                MessageBox.Show("Ocurrio un error al momento de establecer la conexion con la base de datos: " + X, "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Metodo para errores al ejecutar querys
        public void ErrorOpsBD(Exception x)
        {
            MessageBox.Show("Ocurrio un error al realizar la operacion en la base de datos: " + x + "", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        //Metodo para extraer datos de la bd y mapearlos
        public DataSet ExtraeraDataSet(string cmd)
        {
            DataSet DS = new DataSet();

            try
            {
                Conectar(Conexion1);
                Adaptador = new SqlDataAdapter(cmd, Conexion1);
                Adaptador.Fill(DS);
                Conexion1.Close();
                return DS;
            }
            catch (Exception X)
            {
                ErrorOpsBD(X);
                return DS;
            }
        }

        //Metodo para cargar datos a un DataGridView
        public void CargarDataGridView(string cmd, DataGridView DataGridView)
        {
            try
            {
                Conectar(Conexion1);
                Tabla = new DataTable();
                Adaptador = new SqlDataAdapter(cmd, Conexion1);
                Adaptador.Fill(Tabla);
                DataGridView.DataSource = Tabla;
                Conexion1.Close();
            }
            catch (Exception x)
            {
                ErrorOpsBD(x);
            }
        }

        //Metodo para ejecutar scripts en la base de datos
        public void EjecutarScript(string cmd)
        {
            try
            {
                Conectar(Conexion1);
                Comando = new SqlCommand(cmd, Conexion1);
                Comando.ExecuteNonQuery();
                Conexion1.Close();
            }
            catch (Exception X)
            {
                ErrorOpsBD(X);
            }
        }
    }
}
