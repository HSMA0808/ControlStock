using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    class Salida
    {
        public int IdSalida;
        public int IdUsuario;
        public int IdDepart;
        public DateTime Fecha;
        public int CantidadTotal;


        public int Guardar()
        {
            DataSet DS;
            Clases.Conexion Conexion = new Clases.Conexion();
            Conexion.EjecutarScript("insert into salidas (idusuario, iddepartamento, fecha, cant_total)" +
            " values (" + IdUsuario + ", " + IdDepart + ", Convert(char(19), '" + Fecha.ToShortDateString() + "'), " + CantidadTotal + ")");
            DS = Conexion.ExtraeraDataSet("select * from salidas");
            IdSalida = DS.Tables[0].Rows.Count;
            IdSalida = Convert.ToInt32(DS.Tables[0].Rows[IdSalida - 1]["idsalida"]);
            return IdSalida;
        }

        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (IdDepart == 0 || CantidadTotal == 0 || Fecha == null || IdUsuario == 0)
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
