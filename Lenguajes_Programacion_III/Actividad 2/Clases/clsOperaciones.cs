using System;
using System.Windows.Forms;
using Actividad_2.Formularios;

namespace Actividad_2.Clases
{
    public class clsOperaciones
    {
        public void AbrirOperaciones()
        {
            frmOperaciones ventanaOperaciones = new frmOperaciones();
            ventanaOperaciones.ShowDialog();
        }
    }
}