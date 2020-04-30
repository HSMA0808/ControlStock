using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    class Articulos : ControlDeDatos
    {
        public int IdArticulos;
        public int IdProveedor;
        public string Nombre_Articulo;
        public int Cantidad;
        public string Marca;
        public string Descripcion;
        private DataSet DS;

        public int Guardar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Insert into Articulos  (idproveedor, nombre_articulo, cantidad, marca, descripcion) values " +
            "(" +  IdProveedor + " , '" +  Nombre_Articulo + "', " +  Cantidad + ", '" +  Marca + "', '" +  Descripcion + "')");
            DS = new DataSet();
            int UltimoRegistro;
            DS = C.ExtraeraDataSet("select * from articulos");
            UltimoRegistro = DS.Tables[0].Rows.Count;
            UltimoRegistro = Convert.ToInt32(DS.Tables[0].Rows[UltimoRegistro-1]["idarticulo"]);
            return UltimoRegistro;
        }

        public void Actualizar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Update Articulos set idproveedor = " +  IdProveedor + ", nombre_articulo = '" +  Nombre_Articulo + "'" +
            ", cantidad = " +  Cantidad + ", marca = '" +  Marca + "', descripcion = '" +  Descripcion + "' where idarticulo = "+ IdArticulos+"");
        }

        public void Eliminar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Delete From Articulos where idarticulos = " +  IdArticulos + "");
        }

        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (IdProveedor == 0 || Cantidad == 0 || Nombre_Articulo == string.Empty || Marca == string.Empty || Descripcion == string.Empty)
            {
                return EstaLleno;
            }
            else if (IdProveedor > 0 || Cantidad > 0 || Nombre_Articulo != string.Empty || Marca != string.Empty || Descripcion != string.Empty)
            {
                EstaLleno = true;
            }
            return EstaLleno;
        }
    }
}
