using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Formularios
{
    public partial class ModalLoading : Form
    {
        public ModalLoading(string Operacion)
        {
            InitializeComponent();
            lblOperacion.Text = Operacion + "...";
        }
    }
}
