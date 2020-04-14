using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCN.Clases
{
    class Atencion : Juego 
    {

        public bool abrirMenuAtencion()
        {
            return true;
        }

        public void mostrarJuegoAtencion1()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            menu.AbrirFormularioFormateado<frmJuegoAtencion1>();
            
        }

        public void mostrarJuegoAtencion2()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            menu.AbrirFormularioFormateado<frmJuegoAtencion2>();
        }

        public void mostrarJuegoAtencion3()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            menu.AbrirFormularioFormateado<frmJuegoAtencion3>();
        }
    }
}
