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
    public partial class frmJuegoMemoria1 : Form
    {
        private int contador = 0;
        private int puntaje_total;
        private int minutos = 0;
        private int segundos = 0;
        private int total_segundos = 0;
        Clases.Juego juego = new Clases.Juego();
        public bool correcto1 = false;
        public bool correcto2 = false;
        public bool correcto3 = false;
        public bool correcto4 = false;

        public frmJuegoMemoria1()
        {
            InitializeComponent();
        }

        private void frmJuegoMemoria1_Load(object sender, EventArgs e)
        {
            if (juego.iniciarTiempo())
            {
                timer1.Enabled = true;
            }
            escribirTexto();
            juego.nombre_juego = "Tablas de multiplicar";
            juego.puntuacion = 0;
            juego.mostrarNivel(1);
            mouseDownRojo();
        }

        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            if (correcto1 == true)
            {
                juego.reproducirSonido("ring");
                juego.puntuacion += 1000;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                nuevaOperacion();
            }
            else
            {
                juego.reproducirSonido("uh_minecraft");
                juego.puntuacion -= 200;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            if (correcto2 == true)
            {
                juego.reproducirSonido("ring");
                juego.puntuacion += 1000;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                nuevaOperacion();
            }
            else
            {
                juego.reproducirSonido("uh_minecraft");
                juego.puntuacion -= 200;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            if (correcto3 == true)
            {
                juego.reproducirSonido("ring");
                juego.puntuacion += 1000;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                nuevaOperacion();
            }
            else
            {
                juego.reproducirSonido("uh_minecraft");
                juego.puntuacion -= 200;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void btnRespuesta4_Click(object sender, EventArgs e)
        {
            if (correcto4 == true)
            {
                juego.reproducirSonido("ring");
                juego.puntuacion += 1000;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                nuevaOperacion();
            }
            else
            {
                juego.reproducirSonido("uh_minecraft");
                juego.puntuacion -= 200;
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void nuevaOperacion()
        {
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":
                    juego.mostrarNivel(1);
                    break;
                case "2":
                    juego.mostrarNivel(2);
                    break;
                case "3":
                    juego.mostrarNivel(3);
                    break;
            }

            mouseDownRojo();

            contador++;
            if (contador == 15)
            {
                timer1.Stop();
                this.Enabled = false;
                frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion3 + " 2", juego.nombre_juego);
                paseDeNivel.Show();
            }
            else if (contador == 30)
            {
                timer1.Stop();
                this.Enabled = false;
                frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Atencion3 + " 3", juego.nombre_juego);
                paseDeNivel.Show();
            }else if (contador == 45)
            {
                timer1.Stop();
                this.Enabled = false;
                puntaje_total = juego.gestionarPuntuacion(total_segundos);
                frmFinDeJuego finDeJuego = new frmFinDeJuego(Res.Obtuviste + " " + puntaje_total.ToString() + " " + Res.Puntos, juego.nombre_juego);
                finDeJuego.Show();
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

        private void mouseDownRojo()
        {
            btnRespuesta1.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnRespuesta2.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnRespuesta3.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnRespuesta4.FlatAppearance.MouseDownBackColor = Color.Pink;

            if (correcto1 == true)
            {
                btnRespuesta1.FlatAppearance.MouseDownBackColor = Color.Gray;
            }
            else if (correcto2 == true)
            {
                btnRespuesta2.FlatAppearance.MouseDownBackColor = Color.Gray;
            }
            else if (correcto3 == true)
            {
                btnRespuesta3.FlatAppearance.MouseDownBackColor = Color.Gray;
            }
            else if (correcto4 == true)
            {
                btnRespuesta4.FlatAppearance.MouseDownBackColor = Color.Gray;
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
            if (segundos > 0 && segundos < 10)
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

        private void escribirTexto()
        {
            lblTitulo.Text = Res.Cual_es_la_respuesta_correcta;
            lblTime.Text = Res.Tiempo;
            btnSalir.Text = Res.Salir_del_juego;
            btnRendirse.Text = Res.Rendirse;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pbxCheck.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            abrirMenuPrincipal();
        }
    }
}
