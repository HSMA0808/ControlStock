using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    class Usuarios : ControlDeDatos
    {
        public int IdUsuario;
        public int IdEmpleado;
        public string nm_user;
        public string pass_word;
        public string Categoria;
        private DataSet DS;


        public int Guardar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Insert Into Usuarios (idempleado, nm_user, pass_word, categoria) Values" +
            " (" +  IdEmpleado + ", '" +  nm_user + "', '" +  pass_word + "', '" +  Categoria + "')");
            DS = new DataSet();
            int UltimoRegistro;
            DS = C.ExtraeraDataSet("select * from usuarios");
            UltimoRegistro = DS.Tables[0].Rows.Count;
            UltimoRegistro = Convert.ToInt32(DS.Tables[0].Rows[UltimoRegistro - 1]["idusuario"]);
            return UltimoRegistro;
        }

        public void Actualizar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Update Usuarios set idempleado = " +  IdEmpleado + ", nm_user = '" +  nm_user + "'" +
            ", pass_word = '" +  pass_word + "', Categoria = '" +  Categoria + "' where idusuario = "+IdUsuario+"");
        }

        public void Eliminar()
        {
            Conexion C = new Conexion();
            C.EjecutarScript("Delete From Usuarios where idusuario = '" +  IdUsuario + "'");
        }

        public bool IniciarSesion(string user, string pass)
        {
            bool criterio = false;
            Conexion C = new Conexion();
            DataSet DS = new DataSet();
            DS = C.ExtraeraDataSet("select idusuario, nm_user, pass_word from usuarios where nm_user = '" + user + "' and pass_word = '" + pass + "'");
            if (DS.Tables[0].Rows.Count > 0 )
            {
                if (DS.Tables[0].Rows[0]["nm_user"].ToString() == user && DS.Tables[0].Rows[0]["pass_word"].ToString() == pass)
                {
                    criterio = true;
                }
            }
            else
            {
                return criterio;
            }
            return criterio;
        }

        public bool ObjetoCompleto()
        {
            bool EstaLleno = false;
            if (IdEmpleado == 0 || nm_user == string.Empty || pass_word == string.Empty || Categoria == string.Empty)
            {
                return EstaLleno;
            }
            else if (IdEmpleado > 0 || nm_user != string.Empty || pass_word != string.Empty || Categoria != string.Empty)
            {
                EstaLleno = true;
            }
            return EstaLleno;
        }
    }
}
