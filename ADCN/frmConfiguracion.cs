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
    public partial class frmConfiguracion : Form
    {
        Clases.Proceso proceso = new Clases.Proceso();
        private string color;

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            setImages();
            escribirTextos();
        }

        private void cambiarColores(object sender, EventArgs e)
        {
            PictureBox btnClicked = sender as PictureBox;
            switch (btnClicked.Name)
            {
                case "pbxNaranja":
                    color = "Naranja";
                    break;
                case "pbxAzul":
                    color = "Azul";
                    break;
                case "pbxVerde":
                    color = "Verde";
                    break;
                case "pbxRosa":
                    color = "Rosa";
                    break;
            }
            proceso.cambiarColor(color);
        }

        private void escribirTextos()
        {
            gbxTema.Text = Res.Tema;
            gbxSonido.Text = Res.Sonido;
        }

        private void pbxActivarSonido_Click(object sender, EventArgs e)
        {
            proceso.activar_desactivar_Sonido(true);
            setImages();
        }

        private void pbxDesactivarSonido_Click(object sender, EventArgs e)
        {
            proceso.activar_desactivar_Sonido(false);
            setImages();
        }

        private void setImages()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            switch (menu.sonido)
            {
                case true:
                    pbxActivarSonido.Image = Image.FromFile("..\\..\\Resources\\sound_on.png");
                    pbxDesactivarSonido.Image = Image.FromFile("..\\..\\Resources\\sound_off_disable.png");
                    break;
                case false:
                    pbxActivarSonido.Image = Image.FromFile("..\\..\\Resources\\sound_on_disable.png");
                    pbxDesactivarSonido.Image = Image.FromFile("..\\..\\Resources\\sound_off.png");
                    break;
            }
        }

        private void pbxActivarSonido_MouseEnter(object sender, EventArgs e)
        {
            pbxActivarSonido.Size = new Size(191, 106);
        }

        private void pbxActivarSonido_MouseLeave(object sender, EventArgs e)
        {
            pbxActivarSonido.Size = new Size(191, 103);
        }

        private void pbxDesactivarSonido_MouseEnter(object sender, EventArgs e)
        {
            pbxDesactivarSonido.Size = new Size(191, 106);
        }

        private void pbxDesactivarSonido_MouseLeave(object sender, EventArgs e)
        {
            pbxDesactivarSonido.Size = new Size(191, 103);
        }

        private void agrandarPbx(object sender, EventArgs e)
        {
            PictureBox pbx = sender as PictureBox;
            pbx.Size = new Size(291, 156);
            
        }

        private void minimizarPbx(object sender, EventArgs e)
        {
            PictureBox pbx = sender as PictureBox;
            pbx.Size = new Size(288, 153);
        }
    }
}
