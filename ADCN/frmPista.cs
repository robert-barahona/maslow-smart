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
    public partial class frmPista : Form
    {
        private string mensaje;

        public frmPista()
        {
            InitializeComponent();
        }

        public void setMessage(string mensaje)
        {
            this.mensaje = mensaje;
        }

        private void frmPista_Load(object sender, EventArgs e)
        {
            escribirTexto();
        }

        private void escribirTexto()
        {
            btnAceptar.Text = Res.Aceptar;
            lblPista.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
