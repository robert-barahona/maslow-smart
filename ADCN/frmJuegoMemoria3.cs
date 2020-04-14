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
    public partial class frmJuegoMemoria3 : Form
    {
        private int puntaje_total;
        private int minutos = 0;
        private int segundos = 0;
        private int total_segundos = 0;
        public string historia;
        public string historia_concatenada;
        private string frase;
        public string pista;
        public int indice = 0;
        private int aux = 0;
        Clases.Juego juego = new Clases.Juego();

        public frmJuegoMemoria3()
        {
            InitializeComponent();
        }

        private void frmJuegoMemoria2_Load(object sender, EventArgs e)
        {
            if (juego.iniciarTiempo())
            {
                timer1.Enabled = true;
            }
            escribirTexto();
            juego.nombre_juego = "Había una vez";
            juego.puntuacion = 0;
            juego.mostrarNivel(1);
            lblFrase.Focus();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pista = historia_concatenada;
            historia_concatenada += lblFrase.Text + " ";
            txtIngresarFrase.Text = "";
            txtIngresarFrase.Visible = true;
            txtIngresarFrase.Focus();
            btnComprobar.Visible = true;
            lblFrase.Visible = false;
            AcceptButton = btnComprobar;
            lblTitulo.Text = Res.Escribe_la_frase;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            
            frase = txtIngresarFrase.Text + " ";
            if (frase == historia_concatenada)
            {
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                juego.reproducirSonido("ring");
                juego.puntuacion += 10000;
                indice++;
                string[] lbl_nivel = lblNivel.Text.Split();
                int nivel = Convert.ToInt32(lbl_nivel[1]);
                juego.mostrarNivel(nivel);
            }
            else
            {
                pbxCheck.Image = Image.FromFile("..\\..\\Resources\\error.png");
                juego.reproducirSonido("uh_minecraft");
                juego.puntuacion -= 50;
            }
            pbxCheck.Visible = true;
            timer2.Start();
        }

        private void comprobarPaseDeNivel()
        {
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":
                    if (indice == 5)
                    {
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Memoria3_1 + " 2", juego.nombre_juego);
                        paseDeNivel.Show();
                    }
                    break;
                case "2":
                    if (indice == 7)
                    {
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Memoria3_2 + " 3", juego.nombre_juego);
                        paseDeNivel.Show();
                    }
                    break;
                case "3":
                    if (indice == 11)
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
            indice = 0;
            historia_concatenada = "";
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

        private void borrarPortapapeles(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void btnRendirse_Click(object sender, EventArgs e)
        {
            juego.reproducirSonido("game_over");
            timer1.Stop();
            this.Enabled = false;
            frmRendirse frmRendirse = new frmRendirse(Res.Mensaje_Rendirse, juego.nombre_juego);
            frmRendirse.Show();
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
            juego.puntuacion -= 50;
        }

        private void escribirTexto()
        {
            btnComprobar.Text = Res.Comprobar;
            btnSiguiente.Text = Res.Siguiente;
            lblTitulo.Text = Res.Memoriza_la_frase_y_haz_clic_en_siguiente;
            lblTime.Text = Res.Tiempo;
            btnPista.Text = Res.Comodin;
            btnRendirse.Text = Res.Rendirse;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pbxCheck.Visible = false;
            if (frase == historia_concatenada)
            {
                txtIngresarFrase.Visible = false;
                btnComprobar.Visible = false;
                lblFrase.Visible = true;
                AcceptButton = btnSiguiente;
                lblFrase.Focus();
                lblTitulo.Text = Res.Memoriza_la_frase_y_haz_clic_en_siguiente;
                comprobarPaseDeNivel();
            }
        }
    }
}
