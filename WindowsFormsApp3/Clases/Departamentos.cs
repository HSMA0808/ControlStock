using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp3.Clases
{
    class Departamentos : ControlDeDatos
    {
        public int IdDepartamento;
        public int IdEmpleado;
        public string NombreDepto;
        private DataSet DS;


        public int Guardar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Insert into Departamentos (idempleado, nombredepto) values " +
            "(" +  IdEmpleado + ", '" +  NombreDepto + "')");
            DS = new DataSet();
            int UltimoRegistro;
            DS = C.ExtraeraDataSet("select * from departamentos");
            UltimoRegistro = DS.Tables[0].Rows.Count;
            UltimoRegistro = Convert.ToInt32(DS.Tables[0].Rows[UltimoRegistro - 1]["iddepartamento"]);
            return UltimoRegistro;
        }

        public void Actualizar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Update  Departamentos set IdEmpleado = " +  IdEmpleado + ", NombreDepto =" +
            " '"+  NombreDepto + "'");
        }

        public void Eliminar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Delete From Departamentos where IdDepartamento = " +  IdDepartamento + "");
        }

        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (IdEmpleado == 0 || NombreDepto == string.Empty)
            {
                return EstaLleno;
            }
            else if (IdEmpleado > 0 || NombreDepto != string.Empty)
            {
                EstaLleno = true;
            }
            return EstaLleno;
        }
    }


   
}
