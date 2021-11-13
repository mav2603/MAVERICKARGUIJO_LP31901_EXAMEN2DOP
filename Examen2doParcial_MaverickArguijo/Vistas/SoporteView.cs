using Examen2doParcial_MaverickArguijo.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2doParcial_MaverickArguijo.Vistas
{
    public partial class SoporteView : Form
    {
        public SoporteView()
        {
            InitializeComponent();
            TipoSoporteController controller = new TipoSoporteController(this);
        }
    }
}
