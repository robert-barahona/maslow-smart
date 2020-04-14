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
    public partial class frmJuegoAtencion3 : Form
    {
        public string color = "";
        private int contador = 0;
        private int puntaje_total;
        private int minutos = 0;
        private int segundos = 0;
        private int total_segundos = 0;
        Clases.Juego juego = new Clases.Juego();

        public frmJuegoAtencion3()
        {
            InitializeComponent();
        }

        private void frmJuegoAtencion3_Load(object sender, EventArgs e)
        {
            if (juego.iniciarTiempo())
            {
                timer1.Enabled = true;
            }
            escribirTexto();
            juego.nombre_juego = "Colores y Significados";
            juego.puntuacion = 0;
            juego.mostrarNivel(1);
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            if ((lblSignificado.Text == "Negro" && color == "Color [Black]") || (lblSignificado.Text == "Azul" && color == "Color [Blue]") || (lblSignificado.Text == "Rojo" && color == "Color [Red]") || (lblSignificado.Text == "Amarillo" && color == "Color [Gold]") || (lblSignificado.Text == "Morado" && color == "Color [DarkViolet]") || (lblSignificado.Text == "Rosa" && color == "Color [Violet]") || (lblSignificado.Text == "Naranja" && color == "Color [Orange]") || (lblSignificado.Text == "Celeste" && color == "Color [Cyan]") || (lblSignificado.Text == "Verde" && color == "Color [Green]") || (lblSignificado.Text == "Café" && color == "Color [Chocolate]"))
            {
                juego.puntuacion += 1000;
                juego.reproducirSonido("ring");
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
            }
            else
            {
                juego.puntuacion -= 100;
                juego.reproducirSonido("uh_minecraft");
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if ((lblSignificado.Text == "Negro" && color != "Color [Black]") || (lblSignificado.Text == "Azul" && color != "Color [Blue]") || (lblSignificado.Text == "Rojo" && color != "Color [Red]") || (lblSignificado.Text == "Amarillo" && color != "Color [Gold]") || (lblSignificado.Text == "Morado" && color != "Color [DarkViolet]") || (lblSignificado.Text == "Rosa" && color != "Color [Violet]") || (lblSignificado.Text == "Naranja" && color != "Color [Orange]") || (lblSignificado.Text == "Celeste" && color != "Color [Cyan]") || (lblSignificado.Text == "Verde" && color != "Color [Green]") || (lblSignificado.Text == "Café" && color != "Color [Chocolate]"))
            {
                juego.puntuacion += 1000;
                juego.reproducirSonido("ring");
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
            }
            else
            {
                juego.puntuacion -= 100;
                juego.reproducirSonido("uh_minecraft");
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void actualizarPantalla()
        {
            contador++;

            if (contador == 20)
            {
                timer1.Stop();
                this.Enabled = false;
                frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion3 + " 2", juego.nombre_juego);
                paseDeNivel.Show();
            }
            else if (contador == 40)
            {
                timer1.Stop();
                this.Enabled = false;
                frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion3 + " 3", juego.nombre_juego);
                paseDeNivel.Show();
            }
            else if (contador == 60)
            {
                juego.reproducirSonido("victory2");
                timer1.Stop();
                this.Enabled = false;
                puntaje_total = juego.gestionarPuntuacion(total_segundos);
                frmFinDeJuego finDeJuego = new frmFinDeJuego(Res.Obtuviste + " " + puntaje_total.ToString() + " " + Res.Puntos, juego.nombre_juego);
                finDeJuego.Show();
            }

            string[] nivel = lblNivel.Text.Split();

            if (nivel[1] == "1")
            {
                juego.mostrarNivel(1);
            }
            else if (nivel[1] == "2")
            {
                juego.mostrarNivel(2);
            }
            else if (nivel[1] == "3")
            {
                juego.mostrarNivel(3);
            }
        }

        public void abrirSiguienteNivel(int nivel)
        {
            timer1.Start();
            juego.mostrarNivel(nivel);
        }

        public void volverAJugar()
        {
            juego.volverAIntentarlo();
        }

        public void abrirVideo()
        {
            juego.abrirVideo();
        }

        public void abrirMenuPrincipal()
        {
            for (int i = 0; i < 10; i++)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() != typeof(frmMenu))
                    {
                        frm.Close();
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            total_segundos++;
            if (segundos >= 60)
            {
                minutos++;
                segundos = 0;
            }
            if (segundos >= 0 && segundos < 10)
            {
                if (minutos >= 0 && minutos < 10)
                    lblTiempo.Text = "0" + minutos.ToString() + ":0" + segundos.ToString();
                else
                    lblTiempo.Text = minutos.ToString() + ":0" + segundos.ToString();
            }
            else
            {
                if (minutos >= 0 && minutos < 10)
                    lblTiempo.Text = "0" + minutos.ToString() + ":" + segundos.ToString();
                else
                    lblTiempo.Text = minutos.ToString() + ":" + segundos.ToString();
            }
        }

        private void btnPista_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("pista");
            juego.mostrarPista();   
        }

        private void btnRendirse_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("game_over");
            timer1.Stop();
            this.Enabled = false;
            frmRendirse frmRendirse = new frmRendirse(Res.Mensaje_Rendirse, juego.nombre_juego);
            frmRendirse.Show();
        }

        private void escribirTexto()
        {
            lblTitulo.Text = Res.Encabezado_juego_atencion3;
            gbxSignificado.Text = Res.Significado;
            gbxColor.Text = Res.Color_del_Texto;
            btnSi.Text = Res.Si;
            lblTime.Text = Res.Tiempo;
            btnPista.Text = Res.Comodin;
            btnRendirse.Text = Res.Rendirse;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            actualizarPantalla();
            pbxCheck.Visible = false;
        }
    }
}
