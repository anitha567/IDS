using System;
using System.Windows.Forms;
using Actividad_2.Formularios;

namespace Actividad_2.Clases
{
    public class clsInfoPersonal
    {
        public void AbrirInfoPersonal()
        {
            frmInformacionPersonal ventanaInfo = new frmInformacionPersonal();
            ventanaInfo.ShowDialog();
        }
    }
}