using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCN.Clases
{
    class Memoria : Juego
    {

        public bool abrirMenuMemoria()
        {
            return true;
        }

        public void mostrarJuegoMemoria1()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            menu.AbrirFormularioFormateado<frmJuegoMemoria1>();
        }

        public void mostrarJuegoMemoria2()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            menu.AbrirFormularioFormateado<frmJuegoMemoria2>();
        }

        public void mostrarJuegoMemoria3()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            menu.AbrirFormularioFormateado<frmJuegoMemoria3>();
        }
    }
}
