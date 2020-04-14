using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCN
{
    public partial class frmMenu : Form
    {
        public string nombre_est;
        public string juego;
        public string color = "naranja";
        public bool sonido = true;

        public frmMenu(string nombre_est)
        {
            this.nombre_est = nombre_est;
            InitializeComponent();
        }

        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = new Form();
            formulario = pnlForms.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        public void AbrirFormularioFormateado<MiForm>() where MiForm : Form, new()
        {
            Form formulario = new Form();
            formulario = pnlForms.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.Close();
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            escribirTextos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Clases.DesarrolloCognitivo des_cog = new Clases.DesarrolloCognitivo();
            if (des_cog.cerrarAplicacion())
            {
                Application.Exit();
            }
        }

        private void pbxConfiguracion_Click(object sender, EventArgs e)
        {
            Clases.Proceso proceso = new Clases.Proceso();
            proceso.mostrarConfiguracion();
        }

        private void pbxLogoMaslow_Click(object sender, EventArgs e)
        {
            Clases.Proceso proceso = new Clases.Proceso();
            proceso.abrirPaginaMaslow();
        }

        private void pbxAyuda_Click(object sender, EventArgs e)
        {
            Clases.Proceso proceso = new Clases.Proceso();
            proceso.mostrarAyuda();
        }

        private void btnJuegosAtencion_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Clases.Atencion atencion = new Clases.Atencion();
            if (atencion.abrirMenuAtencion())
            {
                juego = "atencion";
                atencion.mostrarMenuEdades();
            }
        }

        private void btnJuegosMemoria_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Clases.Memoria memoria = new Clases.Memoria();
            if (memoria.abrirMenuMemoria())
            {
                juego = "memoria";
                memoria.mostrarMenuEdades();
            }
        }

        private void cerrarVentanas()
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

        private void pbxIdiomaEspañol_Click(object sender, EventArgs e)
        {
            Clases.Proceso proceso = new Clases.Proceso();
            proceso.cambiarIdioma("español");
            escribirTextos();
        }

        private void pbxIdiomaIngles_Click(object sender, EventArgs e)
        {
            Clases.Proceso proceso = new Clases.Proceso();
            proceso.cambiarIdioma("inglés");
            escribirTextos();
        }

        private void escribirTextos()
        {
            lblEncabezado.Text = Res.Bienvenida + " " + nombre_est.First().ToString().ToUpper() + nombre_est.Substring(1);
            btnJuegosAtencion.Text = Res.Juegos_de_Atencion;
            btnJuegosMemoria.Text = Res.Juegos_de_Memoria;
            lblIdioma.Text = Res.Idioma;
        }

        private void agrandarPbx(object sender, EventArgs e)
        {
            PictureBox pbx = sender as PictureBox;
            pbx.Size = new Size(37, 39);
        }

        private void minimizarPbx(object sender, EventArgs e)
        {
            PictureBox pbx = sender as PictureBox;
            pbx.Size = new Size(35, 37);
        }
    }
}
