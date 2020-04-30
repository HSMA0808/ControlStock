using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    class Empleado : ControlDeDatos
    {
        public int IdEmpleado;
        public string Nombre;
        public string Apellido;
        public string Sexo;
        public string Cedula;
        public string Email;
        public string Direccion;
        public string Telefono;
        public string Cargo;
        private DataSet DS;


        public int Guardar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Insert Into Empleados (Nombre, Apellido, sexo, Cedula, Email, Direccion, Telefono, Cargo) " +
            "Values ('" +  Nombre + "', '" + Apellido + "', '" +  Sexo + "', '" +  Cedula + "', "+
            "'" +  Email + "', '" +  Direccion + "', '" +  Telefono + "', '" +  Cargo + "')");
            DS = new DataSet();
            int UltimoRegistro;
            DS = C.ExtraeraDataSet("select * from empleados");
            UltimoRegistro = DS.Tables[0].Rows.Count;
            UltimoRegistro = Convert.ToInt32(DS.Tables[0].Rows[UltimoRegistro - 1]["idempleado"]);
            return UltimoRegistro;
        }

        public void Actualizar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Update Empleados set Nombre = '" +  Nombre + "', Apellido = '" +  Apellido + "', " +
            "Sexo = '" +  Sexo + "', Cedula = '" +  Cedula + "', Email = '" +  Email + "', Direccion = " +
            "'" +  Direccion + "', Telefono = '" +  Telefono + "', Cargo = '" +  Cargo + "' where idempleado = " +  IdEmpleado + "");
        }

        public void Eliminar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Delete From Empleados where idempleado = " +  IdEmpleado + "");
        }

        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (Nombre == string.Empty || Apellido == string.Empty || Sexo == string.Empty || Cedula == string.Empty || Email == string.Empty || Direccion == string.Empty || Telefono == string.Empty || Cargo == string.Empty)
            {
                return EstaLleno;
            }
            else if (Nombre != string.Empty || Apellido != string.Empty || Sexo != string.Empty || Cedula != string.Empty || Email != string.Empty || Direccion != string.Empty || Telefono != string.Empty || Cargo != string.Empty)
            {
                EstaLleno = true;
            }
            return EstaLleno;
        }
    }
}
