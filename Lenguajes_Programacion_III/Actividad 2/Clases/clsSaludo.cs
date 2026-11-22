using System;
using System.Windows.Forms;
using Actividad_2.Formularios;

namespace Actividad_2.Clases
{
    public class clsSaludo
    {
        public void AbrirSaludo()
        {
            frmSaludo ventanaSaludo = new frmSaludo();
            ventanaSaludo.ShowDialog();
        }
    }
}