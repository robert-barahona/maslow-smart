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
    public partial class frmJuegoAtencion2 : Form
    {
        private int puntaje_total;
        private int minutos = 0;
        private int segundos = 0;
        private int total_segundos = 0;
        Clases.Juego juego = new Clases.Juego();

        public frmJuegoAtencion2()
        {
            InitializeComponent();
        }

        private void frmJuegoAtencion1_Load(object sender, EventArgs e)
        {
            if (juego.iniciarTiempo())
            {
                timer1.Enabled = true;
            }
            escribirTexto();
            juego.nombre_juego = "Dónde está pikachu";
            juego.puntuacion = 0;
            juego.mostrarNivel(1);
        }

        private void pbxN1_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            timer1.Stop();
            this.Enabled = false;
            juego.puntuacion += 1000;
            frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion2 + " 2", juego.nombre_juego);
            paseDeNivel.Show();
        }

        private void pbxN2_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            timer1.Stop();
            this.Enabled = false;
            juego.puntuacion += 1000;
            frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion2 + " 3", juego.nombre_juego);
            paseDeNivel.Show();
        }

        private void pbxN3_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            timer1.Stop();
            this.Enabled = false;
            juego.puntuacion += 1000;
            frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion2 + " 4", juego.nombre_juego);
            paseDeNivel.Show();
        }

        private void pbxN4_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            timer1.Stop();
            this.Enabled = false;
            juego.puntuacion += 1000;
            frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion2 + " 5", juego.nombre_juego);
            paseDeNivel.Show();
        }

        private void pbxN5_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            timer1.Stop();
            this.Enabled = false;
            juego.puntuacion += 1000;
            frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion2 + " 6", juego.nombre_juego);
            paseDeNivel.Show();
        }

        private void pbxN6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Enabled = false;
            juego.reproducirSonido("victory2");
            juego.puntuacion += 5000;
            puntaje_total = juego.gestionarPuntuacion(total_segundos);
            frmFinDeJuego finDeJuego = new frmFinDeJuego(Res.Obtuviste + " " + puntaje_total.ToString() + " " + Res.Puntos, juego.nombre_juego);
            finDeJuego.Show();
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

        private void restarPuntos(object sender, EventArgs e)
        {
            juego.reproducirSonido("uh_minecraft");
            juego.puntuacion -= 200;
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

        private void btnRendirse_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("game_over");
            timer1.Stop();
            this.Enabled = false;
            frmRendirse frmRendirse = new frmRendirse(Res.Mensaje_Rendirse, juego.nombre_juego);
            frmRendirse.Show();
        }

        private void btnPista_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("pista");
            juego.mostrarPista();
        }

        private void escribirTexto()
        {
            lblTime.Text = Res.Tiempo;
            btnPista.Text = Res.Comodin;
            btnRendirse.Text = Res.Rendirse;
        }

    }
}
