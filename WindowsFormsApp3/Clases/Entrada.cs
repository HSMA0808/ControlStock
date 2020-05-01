using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    class Entrada 
    {
        public int IdEntrada;
        public int IdUsuario;
        public int IdProveedor;
        public string Conduce;
        public DateTime Fecha;
        public int CantidadTotal;

        public int Guardar()
        {
            DataSet DS;
            Clases.Conexion Conexion = new Clases.Conexion();
            Conexion.EjecutarScript("insert into entradas (idusuario, idproveedor, conduce, fecha, cant_total)" +
            " values (" + IdUsuario + ", " + IdProveedor + ", '" + Conduce + "', Convert(char(19), '" + Fecha.ToShortDateString() + "'), " + CantidadTotal + ")");
            DS = Conexion.ExtraeraDataSet("select * from entradas");
            IdEntrada = DS.Tables[0].Rows.Count;
            IdEntrada = Convert.ToInt32(DS.Tables[0].Rows[IdEntrada - 1]["identrada"]);
            return IdEntrada;
        }
        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (IdProveedor == 0 || CantidadTotal == 0 || Conduce == string.Empty || IdUsuario == 0 || Fecha == null)
            {
                return EstaLleno;
            }
            else
            {
                EstaLleno = true;
            }
            return EstaLleno;
        }
    }
}
