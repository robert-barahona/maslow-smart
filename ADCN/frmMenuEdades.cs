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
    public partial class frmMenuEdades : Form
    {
        public string nombre_juego;
        frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
        Clases.Memoria memoria = new Clases.Memoria();
        Clases.Atencion atencion = new Clases.Atencion();

        public frmMenuEdades()
        {
            InitializeComponent();           
        }

        private void frmMenuEdades_Load(object sender, EventArgs e)
        {
            escribirTexto();
        }

        private void btnEdad10_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario<frmInicio>();
            frmInicio inicio = Application.OpenForms.OfType<frmInicio>().SingleOrDefault();
            switch (menu.juego)
            {
                case "atencion":
                    nombre_juego = "Elegir la letra correcta";
                    atencion.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Elegir_la_letra_correcta;
                    inicio.lblObjetivo.Text = atencion.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = atencion.mostrarInstrucciones();
                    break;
                case "memoria":
                    nombre_juego = "Tablas de multiplicar";
                    memoria.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Tablas_de_multiplicar;
                    inicio.lblObjetivo.Text = memoria.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = memoria.mostrarInstrucciones();
                    break;
            }
        }

        private void btnEdad11_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario<frmInicio>();
            frmInicio inicio = Application.OpenForms.OfType<frmInicio>().SingleOrDefault();
            switch (menu.juego)
            {
                case "atencion":
                    nombre_juego = "Dónde está pikachu";
                    atencion.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Donde_esta_pikachu;
                    inicio.lblObjetivo.Text = atencion.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = atencion.mostrarInstrucciones();
                    break;
                case "memoria":
                    nombre_juego = "Provincias del Ecuador";
                    memoria.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Provincias_del_Ecuador;
                    inicio.lblObjetivo.Text = memoria.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = memoria.mostrarInstrucciones();
                    break;
            }
        }

        private void btnEdad12_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario<frmInicio>();
            frmInicio inicio = Application.OpenForms.OfType<frmInicio>().SingleOrDefault();
            switch (menu.juego)
            {
                case "atencion":
                    nombre_juego = "Colores y Significados";
                    atencion.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Colores_y_Significados;
                    inicio.lblObjetivo.Text = atencion.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = atencion.mostrarInstrucciones();
                    break;
                case "memoria":
                    nombre_juego = "Había una vez";
                    memoria.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Habia_una_vez;
                    inicio.lblObjetivo.Text = memoria.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = memoria.mostrarInstrucciones();
                    break;
            }
        }

        private void escribirTexto()
        {
            lblQueEdadTienes.Text = Res.Que_edad_tienes;
            lbl10Anios.Text = Res._10_Años;
            lbl11Anios.Text = Res._11_Años;
            lbl12Anios.Text = Res._12_Años;
            btnEdad10.Text = Res.Jugar;
            btnEdad11.Text = Res.Jugar;
            btnEdad12.Text = Res.Jugar;
            lblRecuerdaQue.Text = Res.Recuerda_que_la_edad;
            switch (menu.juego)
            {
                case "atencion":
                    lblJuego1.Text = Res.Elegir_la_letra_correcta;
                    lblJuego2.Text = Res.Donde_esta_pikachu;
                    lblJuego3.Text = Res.Colores_y_Significados;
                    pbxJuego1.Image = Image.FromFile("..\\..\\Resources\\juego_a1.jpg");
                    pbxJuego2.Image = Image.FromFile("..\\..\\Resources\\juego_a2.jpg");
                    pbxJuego3.Image = Image.FromFile("..\\..\\Resources\\juego_a3.jpg");
                    break;
                case "memoria":
                    lblJuego1.Text = Res.Tablas_de_multiplicar;
                    lblJuego2.Text = Res.Provincias_del_Ecuador;
                    lblJuego3.Text = Res.Habia_una_vez;
                    pbxJuego1.Image = Image.FromFile("..\\..\\Resources\\juego_m1.jpg");
                    pbxJuego2.Image = Image.FromFile("..\\..\\Resources\\juego_m2.jpg");
                    pbxJuego3.Image = Image.FromFile("..\\..\\Resources\\juego_m3.jpg");
                    break;
            }
        }
    }
}
