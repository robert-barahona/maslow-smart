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
    public partial class frmJuegoMemoria2 : Form
    {
        private int puntaje_total;
        private int minutos = 0;
        private int segundos = 0;
        private int total_segundos = 0;
        public string[] respuestas = new string[3] { "", "", "" };
        Clases.Juego juego = new Clases.Juego();

        public frmJuegoMemoria2()
        {
            InitializeComponent();
        }

        private void frmJuegoMemoria_Load(object sender, EventArgs e)
        {
            if (juego.iniciarTiempo())
            {
                timer1.Enabled = true;
            }
            escribirTexto();
            juego.nombre_juego = "Provincias del Ecuador";
            juego.puntuacion = 0;
            juego.mostrarNivel(1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":
                    lblTitulo.Text = "Pichincha";
                    pnlPichincha.Visible = true;
                    pnlCotopaxi.Visible = false;
                    pnlTungurahua.Visible = false;
                    break;
                case "2":
                    lblTitulo.Text = "Azuay";
                    pnlAzuay.Visible = true;
                    pnlGuayas.Visible = false;
                    pnlChimborazo.Visible = false;
                    break;
                case "3":
                    lblTitulo.Text = "Manabí";
                    pnlManabi.Visible = true;
                    pnlLoja.Visible = false;
                    pnlBolivar.Visible = false;
                    break;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":
                    lblTitulo.Text = "Cotopaxi";
                    pnlPichincha.Visible = false;
                    pnlCotopaxi.Visible = true;
                    pnlTungurahua.Visible = false;
                    break;
                case "2":
                    lblTitulo.Text = "Guayas";
                    pnlAzuay.Visible = false;
                    pnlGuayas.Visible = true;
                    pnlChimborazo.Visible = false;
                    break;
                case "3":
                    lblTitulo.Text = "Loja";
                    pnlManabi.Visible = false;
                    pnlLoja.Visible = true;
                    pnlBolivar.Visible = false;
                    break;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":
                    lblTitulo.Text = "Tungurahua";
                    pnlPichincha.Visible = false;
                    pnlCotopaxi.Visible = false;
                    pnlTungurahua.Visible = true;
                    break;
                case "2":
                    lblTitulo.Text = "Chimborazo";
                    pnlAzuay.Visible = false;
                    pnlGuayas.Visible = false;
                    pnlChimborazo.Visible = true;
                    break;
                case "3":
                    lblTitulo.Text = "Bolivar";
                    pnlManabi.Visible = false;
                    pnlLoja.Visible = false;
                    pnlBolivar.Visible = true;
                    break;
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = Res.Escriba_las_provincias_que_corresponden_a_las_imagenes;
            string[] nivel = lblNivel.Text.Split();
            switch (nivel[1])
            {
                case "1":  
                    pnlPichincha.Visible = false;
                    pnlCotopaxi.Visible = false;
                    pnlTungurahua.Visible = false;     
                    break;
                case "2":
                    pnlAzuay.Visible = false;
                    pnlGuayas.Visible = false;
                    pnlChimborazo.Visible = false;
                    break;
                case "3":
                    pnlManabi.Visible = false;
                    pnlLoja.Visible = false;
                    pnlBolivar.Visible = false;
                    break;
            }
            pnlComprobacion.Visible = true;
            pnlBotones.Visible = false;
            //MessageBox.Show(respuestas[0] + "\n" + respuestas[1] + "\n" + respuestas[2]);
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            pbxCheck1.Visible = true;
            pbxCheck2.Visible = true;
            pbxCheck3.Visible = true;

            if (txt1.Text.ToLower() == respuestas[0] && txt1.BackColor == Color.White)
            {
                pbxCheck1.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                txt1.BackColor = Color.LightGreen;
                txt1.ReadOnly = true;
                juego.puntuacion += 5000;
            }
            else if (txt1.BackColor == Color.White || txt1.BackColor == Color.Red)
            {
                pbxCheck1.Image = Image.FromFile("..\\..\\Resources\\error.png");
                txt1.BackColor = Color.LightCoral;
                juego.puntuacion -= 500;
            }

            if (txt2.Text.ToLower() == respuestas[1] && txt2.BackColor == Color.White)
            {
                pbxCheck2.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                txt2.BackColor = Color.LightGreen;
                txt2.ReadOnly = false;
                juego.puntuacion += 5000;
            }
            else if (txt2.BackColor == Color.White || txt2.BackColor == Color.Red)
            {
                pbxCheck2.Image = Image.FromFile("..\\..\\Resources\\error.png");
                txt2.BackColor = Color.LightCoral;
                juego.puntuacion -= 500;
            }

            if (txt3.Text.ToLower() == respuestas[2] && txt3.BackColor == Color.White)
            {
                pbxCheck3.Image = Image.FromFile("..\\..\\Resources\\lista.png");
                txt3.BackColor = Color.LightGreen;
                txt3.ReadOnly = true;
                juego.puntuacion += 5000;
            }
            else if (txt3.BackColor == Color.White || txt3.BackColor == Color.Red)
            {
                pbxCheck3.Image = Image.FromFile("..\\..\\Resources\\error.png");
                txt3.BackColor = Color.LightCoral;
                juego.puntuacion -= 500;
            }

            if (txt1.Text.ToLower() == respuestas[0] && txt2.Text.ToLower() == respuestas[1] && txt3.Text.ToLower() == respuestas[2])
            {
                string[] nivel = lblNivel.Text.Split();
                switch (nivel[1])
                {
                    case "1":
                        juego.reproducirSonido("ring");
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel = new frmPaseDeNivel(Res.Avanzar_Nivel_Memoria2 + " 2", juego.nombre_juego);
                        paseDeNivel.Show();    
                        break;
                    case "2":
                        juego.reproducirSonido("ring");
                        timer1.Stop();
                        this.Enabled = false;
                        frmPaseDeNivel paseDeNivel2 = new frmPaseDeNivel(Res.Avanzar_Nivel_Memoria2 + " 3", juego.nombre_juego);
                        paseDeNivel2.Show();
                        break;
                    case "3":
                        juego.reproducirSonido("victory2");
                        timer1.Stop();
                        this.Enabled = false;
                        puntaje_total = juego.gestionarPuntuacion(total_segundos);
                        frmFinDeJuego finDeJuego = new frmFinDeJuego(Res.Obtuviste + " " + puntaje_total.ToString() + " " + Res.Puntos, juego.nombre_juego);
                        finDeJuego.Show();
                        break;
                }
            }
        }

        private void ponerColorBlanco(object sender, EventArgs e)
        {
            TextBox clickedButton = sender as TextBox;

            if (clickedButton.BackColor == Color.LightCoral)
            {
                clickedButton.BackColor = Color.White;
            }
        }

        public void abrirSiguienteNivel(int nivel)
        {
            timer1.Start();
            juego.mostrarNivel(nivel);
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt1.ReadOnly = false;
            txt2.ReadOnly = false;
            txt3.ReadOnly = false;
            txt1.BackColor = Color.White;
            txt2.BackColor = Color.White;
            txt3.BackColor = Color.White;
            pbxCheck1.Visible = false;
            pbxCheck2.Visible = false;
            pbxCheck3.Visible = false;
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

        private void escribirTexto()
        {
            btnComprobar.Text = Res.Comprobar;
            btnListo.Text = Res.Listo;
            lblTime.Text = Res.Tiempo;
            btnPista.Text = Res.Comodin;
            btnRendirse.Text = Res.Rendirse;
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
    }
}
