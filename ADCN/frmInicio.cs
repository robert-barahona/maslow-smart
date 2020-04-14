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
    public partial class frmInicio : Form
    {
        Clases.Memoria memoria = new Clases.Memoria();
        Clases.Atencion atencion = new Clases.Atencion();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            escribirTexto();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            frmMenuEdades menuEdades = Application.OpenForms.OfType<frmMenuEdades>().SingleOrDefault();
            switch (menuEdades.nombre_juego)
            {
                case "Elegir la letra correcta":
                    atencion.mostrarJuegoAtencion1();
                    break;
                case "Dónde está pikachu":
                    atencion.mostrarJuegoAtencion2();
                    break;
                case "Colores y Significados":
                    atencion.mostrarJuegoAtencion3();
                    break;
                case "Tablas de multiplicar":
                    memoria.mostrarJuegoMemoria1();
                    break;
                case "Provincias del Ecuador":
                    memoria.mostrarJuegoMemoria2();
                    break;
                case "Había una vez":
                    memoria.mostrarJuegoMemoria3();
                    break;
            }
        }

        private void escribirTexto()
        {
            gbxObjetivo.Text = Res.Objetivo;
            gbxInstrucciones.Text = Res.Instrucciones;
            btnEmpezar.Text = Res.Empezar;
        }
    }
}
