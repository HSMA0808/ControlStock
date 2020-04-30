using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    class Proveedores : ControlDeDatos
    {
        public int IdProveedor;
        public string RNC;
        public string Nombre;
        public string Direccion;
        public string Telefono1;
        public string Telefono2;
        public string Email;
        private DataSet DS;

        public int Guardar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Insert into Proveedores (RNC, Nombre, Direccion, Tel1, Tel2, Email) " +
            " values ('" +  RNC + "', '" +  Nombre + "', '" +  Direccion + "', '" + Telefono1 + "', '" + Telefono2 + "', " +
            "'" +  Email + "')");
            DS = new DataSet();
            int UltimoRegistro;
            DS = C.ExtraeraDataSet("select * from proveedores");
            UltimoRegistro = DS.Tables[0].Rows.Count;
            UltimoRegistro = Convert.ToInt32(DS.Tables[0].Rows[UltimoRegistro - 1]["idproveedor"]);
            return UltimoRegistro;
        }

        public void Actualizar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Update Proveedores set RNC = '" +  RNC + "', Nombre = '" +  Nombre + "'" +
            ", Direccion = '" +  Direccion + "', Tel1 = '" +  Telefono1 + "', Tel2 = '" +  Telefono2 + "', Email = '" +  Email + "'" +
            " where idproveedor = "+IdProveedor+"");
        }

        public void Eliminar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Delete From Proveedores where idproveedor = " +  IdProveedor + "");
        }

        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (RNC == string.Empty || Nombre == string.Empty || Direccion == string.Empty || Telefono1 == string.Empty || Telefono2 == string.Empty || Email == string.Empty)
            {
                return EstaLleno;
            }
            else if (RNC != string.Empty || Nombre != string.Empty || Direccion != string.Empty || Telefono1 != string.Empty || Telefono2 != string.Empty || Email != string.Empty)
            {
                EstaLleno = true;
            }
            return EstaLleno;
        }
    }
}
