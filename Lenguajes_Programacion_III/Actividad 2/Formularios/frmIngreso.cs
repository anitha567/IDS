using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2.Formularios
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "1234")
            {
                frmMenu menuPrincipal = new frmMenu();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intenta nuevamente.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }
    }
}
