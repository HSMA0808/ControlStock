using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Clases
{
    interface IEntidadesBase
    {
        int Guardar();
        void Actualizar();
        void Eliminar();
    }
}
