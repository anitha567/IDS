using System;
using System.Windows.Forms;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmAccesoRegistro : Form
    {
        private string destinoModulo;
        private const string CONTRASENA_VALIDA = "admin123";

        public frmAccesoRegistro(string modulo)
        {
            InitializeComponent();
            destinoModulo = modulo;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == CONTRASENA_VALIDA)
            {
                this.Hide();
                if (destinoModulo == "Cliente")
                {
                    new frmRegistroCliente().ShowDialog();
                }
                else if (destinoModulo == "Proveedor")
                {
                    new frmRegistroProveedor().ShowDialog();
                }
                else if (destinoModulo == "Producto")
                {
                    new frmRegistroProducto().ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intenta de nuevo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}