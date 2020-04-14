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
    public partial class frmRendirse : Form
    {
        private string mensaje;
        private string juego;

        public frmRendirse(string mensaje, string juego)
        {
            this.mensaje = mensaje;
            this.juego = juego;
            InitializeComponent();
        }

        private void frmRendirse_Load(object sender, EventArgs e)
        {
            escribirTexto();
        }

        private void escribirTexto()
        {
            btnVolverAJugar.Text = Res.Aceptar;
            lblMensaje.Text = mensaje;
            btnVolverAJugar.Text = Res.Volver_a_jugar;
            btnVerVideo.Text = Res.Ver_video;
            btnSalir.Text = Res.Salir;
        }

        private void btnVolverAJugar_Click(object sender, EventArgs e)
        {
            switch (juego)
            {
                case "Elegir la letra correcta":
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.volverAJugar();
                    break;
                case "Dónde está pikachu":
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.volverAJugar();
                    break;
                case "Colores y Significados":
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.volverAJugar();
                    break;
                case "Tablas de multiplicar":
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.volverAJugar();
                    break;
                case "Provincias del Ecuador":
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.volverAJugar();
                    break;
                case "Había una vez":
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.volverAJugar();
                    break;
            }
            this.Close();
        }

        private void btnVerVideo_Click(object sender, EventArgs e)
        {
            switch (juego)
            {
                case "Elegir la letra correcta":
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.abrirVideo();
                    break;
                case "Dónde está pikachu":
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.abrirVideo();
                    break;
                case "Colores y Significados":
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.abrirVideo();
                    break;
                case "Tablas de multiplicar":
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.abrirVideo();
                    break;
                case "Provincias del Ecuador":
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.abrirVideo();
                    break;
                case "Había una vez":
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.abrirVideo();
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            switch (juego)
            {
                case "Elegir la letra correcta":
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.abrirMenuPrincipal();
                    break;
                case "Dónde está pikachu":
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.abrirMenuPrincipal();
                    break;
                case "Colores y Significados":
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.abrirMenuPrincipal();
                    break;
                case "Tablas de multiplicar":
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.abrirMenuPrincipal();
                    break;
                case "Provincias del Ecuador":
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.abrirMenuPrincipal();
                    break;
                case "Había una vez":
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.abrirMenuPrincipal();
                    break;
            }
            this.Close();
        }
    }
}
