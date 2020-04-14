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
    public partial class frmJuegoAtencion1 : Form
    {
        public int contador = 0;
        private int puntaje_total;
        private int minutos = 0;
        private int segundos = 0;
        private int total_segundos = 0;
        public bool siguiente_nivel = false;
        public int numeros = 7;
        Clases.Juego juego = new Clases.Juego();

        public frmJuegoAtencion1()
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
            juego.nombre_juego = "Elegir la letra correcta";
            juego.puntuacion = 0;
            juego.mostrarNivel(1);
        }

        private void sumarPuntos(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            Button clickedButton = sender as Button;
            juego.puntuacion += 2000;
            contador++;
            comprobarPaseDeNivel();
            clickedButton.Enabled = false;
        }

        private void comprobarPaseDeNivel()
        {
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":
                    if (contador == 12)
                    {
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion1 + " 2", juego.nombre_juego);
                        paseDeNivel.Show();
                    }
                    break;
                case "2":
                    if (contador == 16)
                    {
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion1 + " 3", juego.nombre_juego);
                        paseDeNivel.Show();
                    }
                    break;
                case "3":
                    if (contador == 28)
                    {
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion1 + " 4", juego.nombre_juego);
                        paseDeNivel.Show();
                    }
                    break;
                case "4":
                    if (contador == 13 && numeros == 0)
                    {
                        juego.reproducirSonido("victory2");
                        timer1.Stop();
                        this.Enabled = false;
                        puntaje_total = juego.gestionarPuntuacion(total_segundos);
                        frmFinDeJuego finDeJuego = new frmFinDeJuego(Res.Obtuviste + " " + puntaje_total.ToString() + " " + Res.Puntos, juego.nombre_juego);
                        finDeJuego.Show();
                    }
                    break;
            }
        }

        public void abrirSiguienteNivel(int nivel)
        {
            timer1.Start();
            juego.mostrarNivel(nivel);
            contador = 0;
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

        private void btnRestarPuntos_Click(object sender, EventArgs e)
        {
            juego.puntuacion -= 100;
            juego.reproducirSonido("uh_minecraft");
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
            this.Enabled = false;
            timer1.Stop();
            frmRendirse frmRendirse = new frmRendirse(Res.Mensaje_Rendirse, juego.nombre_juego);
            frmRendirse.Show();
        }

        private void escribirTexto()
        {
            lblTime.Text = Res.Tiempo;
            btnPista.Text = Res.Comodin;
            btnRendirse.Text = Res.Rendirse;
        }

        private void numerosRestantes(object sender, EventArgs e)
        {
            juego.reproducirSonido("ring");
            Button clickedButton = sender as Button;
            clickedButton.Enabled = false;
            numeros -= 1;
            juego.puntuacion += 2000;
            comprobarPaseDeNivel();
        }
    }
}
