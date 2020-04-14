using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ADCN.Clases
{
    class Juego
    {
        public string nombre_juego;
        public int puntuacion;

        public void reproducirSonido(string sonido)
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            if (menu.sonido == true)
            {
                SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\sonidos\" + sonido + ".wav");
                sound.Play();
            }
        }

        public int gestionarPuntuacion(int tiempo)
        {
            int puntaje_total = 0;

            if (puntuacion <= 0)
                puntaje_total = 0;
            else
                puntaje_total = puntuacion / tiempo;

            return puntaje_total;
        }

        public void mostrarPista()
        {
            string[] nivel;
            frmPista pista = new frmPista();
            switch (nombre_juego)
            {
                case "Elegir la letra correcta":
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    nivel = juegoAtencion1.lblNivel.Text.Split();
                    switch (nivel[1])
                    {
                        case "1":
                            if (12 - juegoAtencion1.contador == 1)
                                pista.setMessage(Res.Pista_a1_1_1 + "1" + Res.Pista_a1_3);
                            else
                                pista.setMessage(Res.Pista_a1_1 + (12 - juegoAtencion1.contador).ToString() + Res.Pista_a1_2);
                            break;
                        case "2":
                            if (16 - juegoAtencion1.contador == 1)
                                pista.setMessage(Res.Pista_a1_1.Remove(Res.Pista_a1_1.Length - 2) + "1" + Res.Pista_a1_3);
                            else
                                pista.setMessage(Res.Pista_a1_1 + (16 - juegoAtencion1.contador).ToString() + Res.Pista_a1_2);
                            break;
                        case "3":
                            if (28 - juegoAtencion1.contador == 1)
                                pista.setMessage(Res.Pista_a1_1_1 + "1" + Res.Pista_a1_3);
                            else
                                pista.setMessage(Res.Pista_a1_1 + (28 - juegoAtencion1.contador).ToString() + Res.Pista_a1_2);
                            break;
                        case "4":
                            if (13 - juegoAtencion1.contador == 1)
                            {
                                pista.setMessage(Res.Pista_a1_1_1 + "1" + Res.Pista_a1_3);
                            }
                            else if (juegoAtencion1.contador == 13 && juegoAtencion1.numeros == 1)
                            {
                                pista.setMessage(Res.Pista_a1_1_1 + "1" + Res.Pista_a1_4);
                            }
                            else
                            {
                                string[] aux = Res.Pista_a1_2.Split();
                                pista.setMessage(Res.Pista_a1_1 + (13 - juegoAtencion1.contador).ToString() + " " + aux[1] + Res.Y + juegoAtencion1.numeros.ToString() + Res.Numeros_por_encontrar);

                            }
                            break;
                    }
                    break;
                case "Dónde está pikachu":
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    nivel = juegoAtencion2.lblNivel.Text.Split();
                    switch (nivel[1])
                    {
                        case "1":
                            pista.setMessage(Res.Pista_a2_1);
                            break;
                        case "2":
                            pista.setMessage(Res.Pista_a2_2);
                            break;
                        case "3":
                            pista.setMessage(Res.Pista_a2_3);
                            break;
                        case "4":
                            pista.setMessage(Res.Pista_a2_4);
                            break;
                        case "5":
                            pista.setMessage(Res.Pista_a2_5);
                            break;
                        case "6":
                            pista.setMessage(Res.Pista_a2_6);
                            break;
                    }
                    break;
                case "Colores y Significados":
                    pista.setMessage(Res.Pista_a3);
                    break;
                case "Provincias del Ecuador":
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    nivel = juegoMemoria2.lblNivel.Text.Split();
                    switch (nivel[1])
                    {
                        case "1":
                            pista.setMessage(Res.Pista_m2 + "Pichincha, Cotopaxi, Tungurahua");
                            break;
                        case "2":
                            pista.setMessage(Res.Pista_m2 + "Azuay, Guayas, Chimborazo");
                            break;
                        case "3":
                            pista.setMessage(Res.Pista_m2 + "Manabí, Loja, Bolivar");
                            break;
                    }
                    break;
                case "Había una vez":
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    if (juegoMemoria3.historia_concatenada == "Había una vez " || juegoMemoria3.historia_concatenada == "Once upon a time " || juegoMemoria3.historia_concatenada == null)
                    {
                        pista.setMessage(Res.Pistas_disponibles);
                    }
                    else
                    {
                        pista.setMessage(Res.Pista_m3 + juegoMemoria3.pista);
                    }
                    break;
            }
            pista.Show();
        }

        public string mostrarInstrucciones()
        {
            string instrucciones = "";
            switch (nombre_juego)
            {
                case "Elegir la letra correcta":
                    instrucciones = Res.Instrucciones1;
                    break;
                case "Dónde está pikachu":
                    instrucciones = Res.Instrucciones2;
                    break;
                case "Colores y Significados":
                    instrucciones = Res.Instrucciones3;
                    break;
                case "Tablas de multiplicar":
                    instrucciones = Res.Instrucciones4;
                    break;
                case "Provincias del Ecuador":
                    instrucciones = Res.Instrucciones5;
                    break;
                case "Había una vez":
                    instrucciones = Res.Instrucciones6;
                    break;
            }
            return instrucciones;
        }

        public bool iniciarTiempo()
        {
            return true;
        }

        public void mostrarNivel(int numero)
        {
            switch (nombre_juego)
            {
                case "Elegir la letra correcta":
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    switch (numero)
                    {
                        case 1:
                            juegoAtencion1.lblNivel.Text = Res.Nivel1;
                            juegoAtencion1.lblTitulo.Text = Res.Encuentra_la_letra_P;
                            juegoAtencion1.tblNivel1.Visible = true;
                            break;
                        case 2:
                            juegoAtencion1.lblNivel.Text = Res.Nivel2;
                            juegoAtencion1.lblTitulo.Text = Res.Encuentra_las_letras_E_y_P;
                            juegoAtencion1.tblNivel1.Visible = false;
                            juegoAtencion1.tblNivel2.Visible = true;
                            break;
                        case 3:
                            juegoAtencion1.lblNivel.Text = Res.Nivel3;
                            juegoAtencion1.lblTitulo.Text = Res.Encuentra_las_letras_I_G_y_S;
                            juegoAtencion1.tblNivel2.Visible = false;
                            juegoAtencion1.tblNivel3.Visible = true;
                            break;
                        case 4:
                            juegoAtencion1.lblNivel.Text = Res.Nivel4;
                            juegoAtencion1.lblTitulo.Text = Res.Encuentra_las_letras_T_K_8;
                            juegoAtencion1.tblNivel3.Visible = false;
                            juegoAtencion1.tblNivel4.Visible = true;
                            break;
                    }
                    break;
                case "Dónde está pikachu":
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    switch (numero)
                    {
                        case 1:
                            juegoAtencion2.lblNivel.Text = Res.Nivel1;
                            juegoAtencion2.pbxN1.Visible = true;
                            juegoAtencion2.pbxNivel1.Visible = true;
                            break;
                        case 2:
                            juegoAtencion2.lblNivel.Text = Res.Nivel2;
                            juegoAtencion2.pbxN1.Visible = false;
                            juegoAtencion2.pbxNivel1.Visible = false;
                            juegoAtencion2.pbxN2.Visible = true;
                            juegoAtencion2.pbxNivel2.Visible = true;
                            break;
                        case 3:
                            juegoAtencion2.lblNivel.Text = Res.Nivel3;
                            juegoAtencion2.pbxN2.Visible = false;
                            juegoAtencion2.pbxNivel2.Visible = false;
                            juegoAtencion2.pbxN3.Visible = true;
                            juegoAtencion2.pbxNivel3.Visible = true;
                            break;
                        case 4:
                            juegoAtencion2.lblNivel.Text = Res.Nivel4;
                            juegoAtencion2.pbxN3.Visible = false;
                            juegoAtencion2.pbxNivel3.Visible = false;
                            juegoAtencion2.pbxN4.Visible = true;
                            juegoAtencion2.pbxNivel4.Visible = true;
                            break;
                        case 5:
                            juegoAtencion2.lblNivel.Text = Res.Nivel5;
                            juegoAtencion2.pbxN4.Visible = false;
                            juegoAtencion2.pbxNivel4.Visible = false;
                            juegoAtencion2.pbxN5.Visible = true;
                            juegoAtencion2.pbxNivel5.Visible = true;
                            break;
                        case 6:
                            juegoAtencion2.lblNivel.Text = Res.Nivel6;
                            juegoAtencion2.pbxN5.Visible = false;
                            juegoAtencion2.pbxNivel5.Visible = false;
                            juegoAtencion2.pbxN6.Visible = true;
                            juegoAtencion2.pbxNivel6.Visible = true;
                            break;
                    }
                    break;
                case "Colores y Significados":
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    Random random = new Random();
                    String[] colores = new string[10] { "Negro", "Azul", "Rojo", "Amarillo", "Morado", "Rosa", "Naranja", "Celeste", "Verde", "Café" };
                    String[] colores_ingles = new string[10] { "Black", "Blue", "Red", "Gold", "Purple", "Pink", "Orange", "Cyan", "Green", "Brown" };
                    String[] colores2 = new string[10] { "Black", "Blue", "Red", "Gold", "DarkViolet", "Violet", "Orange", "Cyan", "Green", "Chocolate" };
                    int significado_num = 0;
                    int color_num = 0;

                    switch (numero)
                    {
                        case 1:
                            do
                            {
                                significado_num = random.Next(5);
                                color_num = random.Next(5);
                            } while (juegoAtencion3.lblSignificado.Text == colores[significado_num] || juegoAtencion3.lblColor.Text == colores[color_num]);

                            juegoAtencion3.lblSignificado.Text = colores[significado_num];
                            juegoAtencion3.lblColor.Text = colores[color_num];
                            juegoAtencion3.lblColor.ForeColor = Color.FromName(colores2[random.Next(5)]);
                            juegoAtencion3.lblNivel.Text = Res.Nivel1;
                            break;
                        case 2:
                            do
                            {
                                significado_num = random.Next(8);
                                color_num = random.Next(8);
                            } while (juegoAtencion3.lblSignificado.Text == colores[significado_num] || juegoAtencion3.lblColor.Text == colores[color_num]);
                            
                            juegoAtencion3.lblSignificado.Text = colores[significado_num];
                            juegoAtencion3.lblColor.Text = colores[color_num];
                            juegoAtencion3.lblColor.ForeColor = Color.FromName(colores2[random.Next(8)]);
                            juegoAtencion3.lblNivel.Text = Res.Nivel2;
                            break;
                        case 3:
                            do
                            {
                                significado_num = random.Next(10);
                                color_num = random.Next(10);
                            } while (juegoAtencion3.lblSignificado.Text == colores[significado_num] || juegoAtencion3.lblColor.Text == colores[color_num]);

                            juegoAtencion3.lblSignificado.Text = colores[significado_num];
                            juegoAtencion3.lblColor.Text = colores[color_num];
                            juegoAtencion3.lblColor.ForeColor = Color.FromName(colores2[random.Next(10)]);
                            juegoAtencion3.lblNivel.Text = Res.Nivel3;
                            break;
                    }

                    int probabilidad = random.Next(2);
                    if (probabilidad == 1)
                    {
                        juegoAtencion3.lblColor.ForeColor = Color.FromName(colores2[significado_num]);
                    }
                    juegoAtencion3.color = juegoAtencion3.lblColor.ForeColor.ToString();

                    break;
                case "Tablas de multiplicar":
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    int a = 0, b = 0, respuesta = 0, boton, puntos = 0, segundos = 60, n1 = 0, n2 = 0, n3 = 0;
                    Random rnd = new Random();
                    juegoMemoria1.correcto1 = false;
                    juegoMemoria1.correcto2 = false;
                    juegoMemoria1.correcto3 = false;
                    juegoMemoria1.correcto4 = false;

                    switch (numero)
                    {
                        case 1:
                            juegoMemoria1.lblNivel.Text = Res.Nivel1;
                            do
                            {
                                a = rnd.Next(1, 6);
                                b = rnd.Next(1, 10);
                            } while (juegoMemoria1.lblOperacion.Text == a.ToString() + "x" + b.ToString());
                            
                            respuesta = a * b;
                            juegoMemoria1.lblOperacion.Text = a.ToString() + "x" + b.ToString();
                            do
                            {
                                n1 = rnd.Next(1, 55);
                                n2 = rnd.Next(1, 55);
                                n3 = rnd.Next(1, 55);
                            } while (n1 == respuesta || n2 == respuesta || n3 == respuesta);
                            
                            boton = rnd.Next(1, 5);
                            juegoMemoria1.btnRespuesta1.Text = rnd.Next(1, 55).ToString();
                            juegoMemoria1.btnRespuesta2.Text = n1.ToString();
                            juegoMemoria1.btnRespuesta3.Text = n2.ToString();
                            juegoMemoria1.btnRespuesta4.Text = n3.ToString();
                            switch (boton)
                            {
                                case 1:
                                    juegoMemoria1.btnRespuesta1.Text = respuesta.ToString();
                                    juegoMemoria1.correcto1 = true;
                                    break;
                                case 2:
                                    juegoMemoria1.btnRespuesta2.Text = respuesta.ToString();
                                    juegoMemoria1.correcto2 = true;
                                    break;
                                case 3:
                                    juegoMemoria1.btnRespuesta3.Text = respuesta.ToString();
                                    juegoMemoria1.correcto3 = true;
                                    break;
                                case 4:
                                    juegoMemoria1.btnRespuesta4.Text = respuesta.ToString();
                                    juegoMemoria1.correcto4 = true;
                                    break;
                            }
                            break;
                        case 2:
                            juegoMemoria1.lblNivel.Text = Res.Nivel2;
                            do
                            {
                                a = rnd.Next(6, 11);
                                b = rnd.Next(5, 11);
                            } while (juegoMemoria1.lblOperacion.Text == a.ToString() + "x" + b.ToString());
                            
                            respuesta = a * b;
                            juegoMemoria1.lblOperacion.Text = a.ToString() + "x" + b.ToString();
                            do
                            {
                                n1 = rnd.Next(30, 82);
                                n2 = rnd.Next(30, 82);
                                n3 = rnd.Next(30, 82);
                            } while (n1 == respuesta || n2 == respuesta || n3 == respuesta);

                            boton = rnd.Next(1, 5);
                            juegoMemoria1.btnRespuesta1.Text = rnd.Next(30, 82).ToString();
                            juegoMemoria1.btnRespuesta2.Text = n1.ToString();
                            juegoMemoria1.btnRespuesta3.Text = n2.ToString();
                            juegoMemoria1.btnRespuesta4.Text = n3.ToString();
                            switch (boton)
                            {
                                case 1:
                                    juegoMemoria1.btnRespuesta1.Text = respuesta.ToString();
                                    juegoMemoria1.correcto1 = true;
                                    break;
                                case 2:
                                    juegoMemoria1.btnRespuesta2.Text = respuesta.ToString();
                                    juegoMemoria1.correcto2 = true;
                                    break;
                                case 3:
                                    juegoMemoria1.btnRespuesta3.Text = respuesta.ToString();
                                    juegoMemoria1.correcto3 = true;
                                    break;
                                case 4:
                                    juegoMemoria1.btnRespuesta4.Text = respuesta.ToString();
                                    juegoMemoria1.correcto4 = true;
                                    break;
                            }
                            break;
                        case 3:
                            juegoMemoria1.lblNivel.Text = Res.Nivel3;
                            do
                            {
                                a = rnd.Next(9, 13);
                                b = rnd.Next(5, 13);
                            } while (juegoMemoria1.lblOperacion.Text == a.ToString() + "x" + b.ToString());

                            respuesta = a * b;
                            juegoMemoria1.lblOperacion.Text = a.ToString() + "x" + b.ToString();
                            do
                            {
                                n1 = rnd.Next(45, 145);
                                n2 = rnd.Next(45, 145);
                                n3 = rnd.Next(45, 145);
                            } while (n1 == respuesta || n2 == respuesta || n3 == respuesta);

                            boton = rnd.Next(1, 5);
                            juegoMemoria1.btnRespuesta1.Text = rnd.Next(45, 145).ToString();
                            juegoMemoria1.btnRespuesta2.Text = n1.ToString();
                            juegoMemoria1.btnRespuesta3.Text = n2.ToString();
                            juegoMemoria1.btnRespuesta4.Text = n3.ToString();
                            switch (boton)
                            {
                                case 1:
                                    juegoMemoria1.btnRespuesta1.Text = respuesta.ToString();
                                    juegoMemoria1.correcto1 = true;
                                    break;
                                case 2:
                                    juegoMemoria1.btnRespuesta2.Text = respuesta.ToString();
                                    juegoMemoria1.correcto2 = true;
                                    break;
                                case 3:
                                    juegoMemoria1.btnRespuesta3.Text = respuesta.ToString();
                                    juegoMemoria1.correcto3 = true;
                                    break;
                                case 4:
                                    juegoMemoria1.btnRespuesta4.Text = respuesta.ToString();
                                    juegoMemoria1.correcto4 = true;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Provincias del Ecuador":
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    int num;
                    Random rnd1 = new Random();
                    int[] aux = new int[3];
                    bool salir = true;
                    switch (numero)
                    {
                        case 1:
                            juegoMemoria2.lblNivel.Text = Res.Nivel1;
                            juegoMemoria2.lblTitulo.Text = "Pichincha";
                            juegoMemoria2.pnlBotones.Visible = true;
                            juegoMemoria2.pnlPichincha.Visible = true;

                            string[] imagenes = new string[6] { "Mitad del mundo", "Iglesia Sangolqui", "Parque vicente leon", "Iglesia de Salcedo", "Baños", "Ambato" };

                            for (int j = 1; j <= 3; j++)
                            {
                                salir = true;
                                do
                                {
                                    num = rnd1.Next(6);
                                    salir = true;
                                    if (num >= 0 && num <= 1 && juegoMemoria2.respuestas.Contains("pichincha"))
                                        salir = false;
                                    else if (num >= 2 && num <= 3 && juegoMemoria2.respuestas.Contains("cotopaxi"))
                                        salir = false;
                                    else if (num >= 4 && num <= 5 && juegoMemoria2.respuestas.Contains("tungurahua"))
                                        salir = false;
                                } while (aux.Contains(num) || salir == false);
                                
                                if (j == 1)
                                {
                                    juegoMemoria2.pbx1.Image = Image.FromFile("..\\..\\Resources\\" + imagenes[num] + ".jpg");
                                    if (num == 0 || num == 1)
                                        juegoMemoria2.respuestas[0] = "pichincha";
                                    else if (num == 2 || num == 3)
                                        juegoMemoria2.respuestas[0] = "cotopaxi";
                                    else if (num == 4 || num == 5)
                                        juegoMemoria2.respuestas[0] = "tungurahua";
                                }
                                else if (j == 2)
                                {
                                    juegoMemoria2.pbx2.Image = Image.FromFile("..\\..\\Resources\\" + imagenes[num] + ".jpg");
                                    if (num == 0 || num == 1)
                                        juegoMemoria2.respuestas[1] = "pichincha";
                                    else if (num == 2 || num == 3)
                                        juegoMemoria2.respuestas[1] = "cotopaxi";
                                    else if (num == 4 || num == 5)
                                        juegoMemoria2.respuestas[1] = "tungurahua";
                                }
                                else if (j == 3)
                                {
                                    juegoMemoria2.pbx3.Image = Image.FromFile("..\\..\\Resources\\" + imagenes[num] + ".jpg");
                                    if (num == 0 || num == 1)
                                        juegoMemoria2.respuestas[2] = "pichincha";
                                    else if (num == 2 || num == 3)
                                        juegoMemoria2.respuestas[2] = "cotopaxi";
                                    else if (num == 4 || num == 5)
                                        juegoMemoria2.respuestas[2] = "tungurahua";
                                }
                                aux[j-1] = num;
                            }
                            break;
                        case 2:
                            juegoMemoria2.lblNivel.Text = Res.Nivel2;
                            juegoMemoria2.lblTitulo.Text = "Azuay";
                            juegoMemoria2.pnlBotones.Visible = true;
                            juegoMemoria2.pnlAzuay.Visible = true;
                            juegoMemoria2.pnlComprobacion.Visible = false;

                            string[] imagenes2 = new string[12] { "Cuenca", "Chiquintad", "Gualaceo", "Giron", "Villamil", "Yaguachi", "Milagro", "Guayaquil", "Guamote", "Alausí", "Chambo", "Riobamba" };

                            for (int j = 1; j <= 3; j++)
                            {
                                salir = true;
                                do
                                {
                                    num = rnd1.Next(12);
                                    salir = true;
                                    if (num >= 0 && num <= 3 && juegoMemoria2.respuestas.Contains("azuay"))
                                        salir = false;
                                    else if (num >= 4 && num <= 7 && juegoMemoria2.respuestas.Contains("guayas"))
                                        salir = false;
                                    else if (num >= 8 && num <= 11 && juegoMemoria2.respuestas.Contains("chimborazo"))
                                        salir = false;
                                } while (aux.Contains(num) || salir == false);

                                if (j == 1)
                                {
                                    juegoMemoria2.pbx1.Image = Image.FromFile("..\\..\\Resources\\" + imagenes2[num] + ".jpg");
                                    if (num >= 0 && num <= 3)
                                        juegoMemoria2.respuestas[0] = "azuay";
                                    else if (num >= 4 && num <= 7)
                                        juegoMemoria2.respuestas[0] = "guayas";
                                    else if (num >= 8 && num <= 11)
                                        juegoMemoria2.respuestas[0] = "chimborazo";
                                }
                                else if (j == 2)
                                {
                                    juegoMemoria2.pbx2.Image = Image.FromFile("..\\..\\Resources\\" + imagenes2[num] + ".jpg");
                                    if (num >= 0 && num <= 3)
                                        juegoMemoria2.respuestas[1] = "azuay";
                                    else if (num >= 4 && num <= 7)
                                        juegoMemoria2.respuestas[1] = "guayas";
                                    else if (num >= 8 && num <= 11)
                                        juegoMemoria2.respuestas[1] = "chimborazo";
                                }
                                else if (j == 3)
                                {
                                    juegoMemoria2.pbx3.Image = Image.FromFile("..\\..\\Resources\\" + imagenes2[num] + ".jpg");
                                    if (num >= 0 && num <= 3)
                                        juegoMemoria2.respuestas[2] = "azuay";
                                    else if (num >= 4 && num <= 7)
                                        juegoMemoria2.respuestas[2] = "guayas";
                                    else if (num >= 8 && num <= 11)
                                        juegoMemoria2.respuestas[2] = "chimborazo";
                                }
                                aux[j - 1] = num;
                            }
                            break;
                        case 3:
                            juegoMemoria2.lblNivel.Text = Res.Nivel3;
                            juegoMemoria2.lblTitulo.Text = "Manabí";
                            juegoMemoria2.pnlBotones.Visible = true;
                            juegoMemoria2.pnlManabi.Visible = true;
                            juegoMemoria2.pnlComprobacion.Visible = false;

                            string[] imagenes3 = new string[18] { "Manta", "Chone", "Bolívar", "Portoviejo", "Jipijapa", "Montecristi", "Loja", "Catamayo", "Macará", "Paltas", "Saraguro", "Gonzanamá", "Guaranda", "Chimbo", "San Miguel", "Chillanes", "Echeandía", "Caluma" };

                            for (int j = 1; j <= 3; j++)
                            {
                                salir = true;
                                do
                                {
                                    num = rnd1.Next(18);
                                    salir = true;
                                    if (num >= 0 && num <= 5 && juegoMemoria2.respuestas.Contains("manabi"))
                                        salir = false;
                                    else if (num >= 6 && num <= 11 && juegoMemoria2.respuestas.Contains("loja"))
                                        salir = false;
                                    else if (num >= 12 && num <= 17 && juegoMemoria2.respuestas.Contains("bolivar"))
                                        salir = false;
                                } while (aux.Contains(num) || salir == false);

                                if (j == 1)
                                {
                                    juegoMemoria2.pbx1.Image = Image.FromFile("..\\..\\Resources\\" + imagenes3[num] + ".jpg");
                                    if (num >= 0 && num <= 5)
                                        juegoMemoria2.respuestas[0] = "manabi";
                                    else if (num >= 6 && num <= 11)
                                        juegoMemoria2.respuestas[0] = "loja";
                                    else if (num >= 12 && num <= 17)
                                        juegoMemoria2.respuestas[0] = "bolivar";
                                }
                                else if (j == 2)
                                {
                                    juegoMemoria2.pbx2.Image = Image.FromFile("..\\..\\Resources\\" + imagenes3[num] + ".jpg");
                                    if (num >= 0 && num <= 5)
                                        juegoMemoria2.respuestas[1] = "manabi";
                                    else if (num >= 6 && num <= 11)
                                        juegoMemoria2.respuestas[1] = "loja";
                                    else if (num >= 12 && num <= 17)
                                        juegoMemoria2.respuestas[1] = "bolivar";
                                }
                                else if (j == 3)
                                {
                                    juegoMemoria2.pbx3.Image = Image.FromFile("..\\..\\Resources\\" + imagenes3[num] + ".jpg");
                                    if (num >= 0 && num <= 5)
                                        juegoMemoria2.respuestas[2] = "manabi";
                                    else if (num >= 6 && num <= 11)
                                        juegoMemoria2.respuestas[2] = "loja";
                                    else if (num >= 12 && num <= 17)
                                        juegoMemoria2.respuestas[2] = "bolivar";
                                }
                                aux[j - 1] = num;
                            }
                            break;
                    }
                    break;
                case "Había una vez":
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    string[] frases;
                    int i = juegoMemoria3.indice;
                    switch (numero)
                    {
                        case 1:
                            juegoMemoria3.lblNivel.Text = Res.Nivel1;
                            juegoMemoria3.historia = Res.Historia1_ballena;
                            frases = juegoMemoria3.historia.Split(',');
                            if (i != 5)
                            {
                                juegoMemoria3.lblFrase.Text = frases[i];
                            }
                            break;
                        case 2:
                            juegoMemoria3.lblNivel.Text = Res.Nivel2;
                            juegoMemoria3.historia = Res.Historia2_jirafa;
                            frases = juegoMemoria3.historia.Split(',');
                            if (i != 7)
                            {
                                juegoMemoria3.lblFrase.Text = frases[i];
                            }
                            break;
                        case 3:
                            juegoMemoria3.lblNivel.Text = Res.Nivel3;
                            juegoMemoria3.historia = Res.Historia3_gato;
                            frases = juegoMemoria3.historia.Split(',');
                            if (i != 11)
                            {
                                juegoMemoria3.lblFrase.Text = frases[i];
                            }
                            break;
                    }
                    break;
            }
        }

        public void volverAIntentarlo()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            switch (nombre_juego)
            {
                case "Elegir la letra correcta": 
                    menu.AbrirFormularioFormateado<frmJuegoAtencion1>();
                    break;
                case "Dónde está pikachu":
                    menu.AbrirFormularioFormateado<frmJuegoAtencion2>();
                    break;
                case "Colores y Significados":
                    menu.AbrirFormularioFormateado<frmJuegoAtencion3>();
                    break;
                case "Tablas de multiplicar":
                    menu.AbrirFormularioFormateado<frmJuegoMemoria1>();
                    break;
                case "Provincias del Ecuador":
                    menu.AbrirFormularioFormateado<frmJuegoMemoria2>();
                    break;
                case "Había una vez":
                    menu.AbrirFormularioFormateado<frmJuegoMemoria3>();
                    break;
            }
        }

        public string mostrarObjetivo()
        {
            string objetivo = "";
            switch (nombre_juego)
            {
                case "Elegir la letra correcta":
                    objetivo = Res.Objetivo1;
                    break;
                case "Dónde está pikachu":
                    objetivo = Res.Objetivo2;
                    break;
                case "Colores y Significados":
                    objetivo = Res.Objetivo3;
                    break;
                case "Tablas de multiplicar":
                    objetivo = Res.Objetivo4;
                    break;
                case "Provincias del Ecuador":
                    objetivo = Res.Objetivo5;
                    break;
                case "Había una vez":
                    objetivo = Res.Objetivo6;
                    break;
            }
            return objetivo;
        }

        public void abrirVideo()
        {
            switch (nombre_juego)
            {
                case "Elegir la letra correcta":
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=wIa_uu04Ngc");
                    break;
                case "Dónde está pikachu":
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=fH7_c_TR-rU");
                    break;
                case "Colores y Significados":
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=7RZ5HP_sYso");
                    break;
                case "Tablas de multiplicar":
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=6fHNUFars-o");
                    break;
                case "Provincias del Ecuador":
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yqtJlqrEJkI");
                    break;
                case "Había una vez":
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=cI8X9QRwrbU");
                    break;
            }
        }

        public void mostrarMenuEdades()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            menu.AbrirFormulario<frmMenuEdades>();
            if (menu.juego == "atencion")
            {
                menu.lblEncabezado.Text = Res.Juegos_de_Atencion;
            }
            else if (menu.juego == "memoria")
            {
                menu.lblEncabezado.Text = Res.Juegos_de_Memoria;
            }
        }
    }
}
