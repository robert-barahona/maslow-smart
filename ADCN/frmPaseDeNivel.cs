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
    public partial class frmPaseDeNivel : Form
    {
        private string mensaje;
        private string juego;

        public frmPaseDeNivel(string mensaje, string juego)
        {
            this.mensaje = mensaje;
            this.juego = juego;
            InitializeComponent();
        }

        private void frmPaseDeNivel_Load(object sender, EventArgs e)
        {
            escribirTexto();
            pbxCheck.Enabled = true;
            lblMensaje.Visible = true;
            btnAceptar.Visible = true;
        }

        private void escribirTexto()
        {
            btnAceptar.Text = Res.Aceptar;
            lblMensaje.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            switch (juego)
            {
                case "Elegir la letra correcta":
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.abrirSiguienteNivel(Convert.ToInt32(mensaje.Last().ToString()));
                    juegoAtencion1.Enabled = true;
                    break;
                case "Dónde está pikachu":
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.abrirSiguienteNivel(Convert.ToInt32(mensaje.Last().ToString()));
                    juegoAtencion2.Enabled = true;
                    break;
                case "Colores y Significados":
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.abrirSiguienteNivel(Convert.ToInt32(mensaje.Last().ToString()));
                    juegoAtencion3.Enabled = true;
                    break;
                case "Tablas de multiplicar":
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.abrirSiguienteNivel(Convert.ToInt32(mensaje.Last().ToString()));
                    juegoMemoria1.Enabled = true;
                    break;
                case "Provincias del Ecuador":
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.abrirSiguienteNivel(Convert.ToInt32(mensaje.Last().ToString()));
                    juegoMemoria2.Enabled = true;
                    break;
                case "Había una vez":
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.abrirSiguienteNivel(Convert.ToInt32(mensaje.Last().ToString()));
                    juegoMemoria3.Enabled = true;
                    break;
            }
            this.Close();
        }
    }
}
