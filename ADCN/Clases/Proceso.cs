using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCN.Clases
{
    class Proceso
    {

        public void mostrarConfiguracion()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            menu.AbrirFormulario<frmConfiguracion>();
            menu.lblEncabezado.Text = Res.Configuracion;
        }

        public void mostrarAyuda()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            menu.AbrirFormulario<frmAyuda>();
            menu.lblEncabezado.Text = Res.Ayuda;
        }

        public void cambiarIdioma(string idioma)
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            
            switch (idioma)
            {
                case "español":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                    break;
                case "inglés":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
            }

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

        public void cambiarColor(string color)
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            switch (color)
            {
                case "Azul":     
                    menu.pnlMenu.BackColor = Color.FromArgb(2, 42, 91);
                    menu.pnlTop.BackColor = Color.FromArgb(13, 93, 142);
                    menu.lblEncabezado.BackColor = Color.FromName("GradientActiveCaption");
                    menu.btnJuegosAtencion.BackColor = Color.FromArgb(2, 42, 91);
                    menu.btnJuegosMemoria.BackColor = Color.FromArgb(2, 42, 91);
                    break;
                case "Naranja":
                    menu.pnlMenu.BackColor = Color.FromArgb(255, 128, 0);
                    menu.pnlTop.BackColor = Color.FromArgb(192, 64, 0);
                    menu.lblEncabezado.BackColor = Color.FromArgb(255, 192, 128);
                    menu.btnJuegosAtencion.BackColor = Color.FromArgb(255, 128, 0);
                    menu.btnJuegosMemoria.BackColor = Color.FromArgb(255, 128, 0);
                    break;
                case "Verde":
                    menu.pnlMenu.BackColor = Color.FromArgb(40, 180, 99);
                    menu.pnlTop.BackColor = Color.FromArgb(25, 111, 61);
                    menu.lblEncabezado.BackColor = Color.FromArgb(171, 235, 198);
                    menu.btnJuegosAtencion.BackColor = Color.FromArgb(40, 180, 99);
                    menu.btnJuegosMemoria.BackColor = Color.FromArgb(40, 180, 99);
                    break;
                case "Rosa":
                    menu.pnlMenu.BackColor = Color.FromName("Violet");
                    menu.pnlTop.BackColor = Color.FromName("Purple");
                    menu.lblEncabezado.BackColor = Color.FromName("Thistle");
                    menu.btnJuegosAtencion.BackColor = Color.FromName("Violet");
                    menu.btnJuegosMemoria.BackColor = Color.FromName("Violet");
                    break;
            }
        }

        public void abrirPaginaMaslow()
        {
            System.Diagnostics.Process.Start("http://escuelas.maslowschool.com/valle-de-los-chillos/sangolqui/unidad-educativa-maslow.php");
        }

        public void activar_desactivar_Sonido(bool sonido)
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            menu.sonido = sonido;
        }
    }
}
