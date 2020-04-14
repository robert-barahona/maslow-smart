using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCN.Clases
{
    class DesarrolloCognitivo
    {
        private string nombre_est;

        public DesarrolloCognitivo()
        {

        }

        public void abrirVentanaPrincipal()
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        public void mostrarMenu()
        {
            frmMenu menu = new frmMenu(this.nombre_est);
            menu.Show();
        }

        public bool cerrarAplicacion()
        {
            return true;
        }

        public bool cargarLogo()
        {
            return true;
        }

        public void registrarNombre(string nombre_est)
        {
            this.nombre_est = nombre_est;
        }
    }
}
