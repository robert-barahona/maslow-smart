using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCN
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            escribirTextos();
        }

        public void escribirTextos()
        {
            lblAyuda1.Text = Res.Ayuda1;
            lblAyuda2.Text = Res.Ayuda2;
            lblAyuda3.Text = Res.Ayuda3;
            lblAyuda4.Text = Res.Ayuda4;
            lblAyuda5.Text = Res.Ayuda5;
            lblAyuda6.Text = Res.Ayuda6;
            lblDesarrolladores.Text = Res.Desarrolladores + "Barahona Cevallos Roberto Alejandro - Moya Suárez Johnny Andrés";
            lblUniversidad.Text = Res.Universidad;
        }
    }
}
