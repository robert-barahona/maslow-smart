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
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Clases.DesarrolloCognitivo des_cog = new Clases.DesarrolloCognitivo();
            if (des_cog.cargarLogo())
            {
                pbxLogo.Visible = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Clases.DesarrolloCognitivo des_cog = new Clases.DesarrolloCognitivo();
            if (txtNombre.Text == "")
            {
                MessageBox.Show("ERROR! Nombre vacío","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                des_cog.registrarNombre(txtNombre.Text);
                des_cog.mostrarMenu();
                this.Close();
            }      
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Clases.DesarrolloCognitivo des_cog = new Clases.DesarrolloCognitivo();
            if (des_cog.cerrarAplicacion())
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
