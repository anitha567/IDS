using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_2.Clases;

namespace Actividad_2.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSaludo objSaludo = new clsSaludo();
            objSaludo.AbrirSaludo();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInfoPersonal objInfo = new clsInfoPersonal();
            objInfo.AbrirInfoPersonal();
        }

        private void operacionesBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsOperaciones objOperaciones = new clsOperaciones();
            objOperaciones.AbrirOperaciones();
        }
    }
}
