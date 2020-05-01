using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Clases
{
    class ControlDeDatos
    {
        public void CerrarApp()
        {
            if (MessageBox.Show("¿Esta seguro de que desea cerrar la aplicacion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void CompleteLosCampos()
        {
            MessageBox.Show("Debe completar todos los campos para guardar la informacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void LleneelCampos()
        {
            MessageBox.Show("Debe llenar el campos para consultar la informacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public int SiEstaVacioValeCero(string valor)
        {
            int digito;
            if (valor == string.Empty)
            {
                valor = "0";
                digito = Convert.ToInt32(valor);
            }
            else
            {
                digito = Convert.ToInt32(valor);
            }
            return digito;
        }

        public bool YaFueAgregado(string id, string cantidad, DataGridView datagrid)
        {
            bool resultado = false;
            int filas;
            filas = datagrid.Rows.Count;
            if (filas == 0)
            {
                return resultado;
            }
            else
            {
                foreach (DataGridViewRow row in datagrid.Rows)
                {
                    if (row.Cells[0].Value.ToString() == id)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value) + Convert.ToInt32(cantidad)).ToString();
                        resultado = true;
                        break;
                    }
                }
            }
            return resultado;
        }

        public int TotalRegistrado(DataGridView datagrid)
        {
            int filas = 0, total = 0;
            filas = datagrid.Rows.Count;
            if (filas == 0)
            {
                return total;
            }
            else
            {
                foreach (DataGridViewRow row in datagrid.Rows)
                {
                        total = Convert.ToInt32(row.Cells[2].Value) + total;
                }
            }
            return total;

        }

        //Metodo que guarda los detalles registrados en el datagrid
        public void GuardarDetails(DataGridView DataGrid, int IdProceso, string Proceso)
        {
            Clases.Conexion conexion = new Clases.Conexion();
            int iterador = 0, contador = 0;
            iterador = DataGrid.Rows.Count;
                if (Proceso == "Entrada")
                {
                    for (contador = 0; contador < iterador; contador++)
                    {
                        conexion.EjecutarScript("insert into entradadetail (numentrada, idarticulo, cantidad) values " +
                            "(" + IdProceso + ", " + Convert.ToInt32(DataGrid.Rows[contador].Cells[0].Value.ToString()) + ", " + Convert.ToInt32(DataGrid.Rows[contador].Cells[2].Value.ToString()) + ") ");
                    }
                }
                else if (Proceso == "Salida")
                {
                    for (contador = 0; contador < iterador; contador++)
                    {
                        conexion.EjecutarScript("insert into salidadetail (numsalida, idarticulo, cantidad) values (" + IdProceso + ", '" + int.Parse(DataGrid.Rows[contador].Cells[0].Value.ToString()) + "', '" + int.Parse(DataGrid.Rows[contador].Cells[2].Value.ToString()) + "')");
                    }
                }
        }
        public static void CambiosRealizados()
        {
            MessageBox.Show("Se realizo la accion correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void NoEncontrado()
        {
            MessageBox.Show("El numero del tipo de transaccion a consultar no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LimpiarDGV(DataGridView Dgv)
        {
            int filas = 0;
            for (filas = Dgv.Rows.Count - 1; filas >= 0; filas--)
            {
                Dgv.Rows.RemoveAt(filas);
            }
        }

        public static void CargarDetails(DataGridView DGV, DataSet DS)
        {
            int i, x;
            i = DS.Tables[0].Rows.Count;
            if (i > 0)
            {
                for (x = 0; x < i; x++)
                {
                    DGV.Rows.Add(DS.Tables[0].Rows[x][0].ToString(), DS.Tables[0].Rows[x][1].ToString(), DS.Tables[0].Rows[x][2].ToString());
                }
            }
        }

        public static void SinRegistros()
        {
            MessageBox.Show("Debe existir al menos un registro para efectuar la devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void CerrarAplicacion()
        {
            if (MessageBox.Show("¿Esta seguro que desea salir de Control Stock?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void MinimizarVentana(Form formulario)
        {
            formulario.WindowState = FormWindowState.Minimized;
        }

        public static int MaximizarVentana(int a, Form formulario)
        {
            if (a == 0)
            {
                formulario.WindowState = FormWindowState.Maximized;
                a++;
            }
            else if (a == 1)
            {
                formulario.WindowState = FormWindowState.Normal;
                a--;
            }
            return a;
        }

    }
}
