using System;
using System.Windows.Forms;

namespace Actividad_3_CRUD
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

        // --- 1. MENÚ BIENVENIDA ---
        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menú principal padre: se deja vacío para que solo despliegue las subopciones
        }

        private void mensajeDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bienvenido a la tienda en línea ZAPATERÍA UMI, donde podrá encontrar todo lo que usted necesita y si no lo encuentra se lo conseguimos.\n\nSomos su mejor opción hoy y siempre.",
                "Mensaje de Bienvenida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void quiénesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "¿Quiénes somos?\n\nSomos una empresa mexicana que trata de apoyar al comercio mexicano; todos nuestros productos son 100% mexicanos, porque creemos en nosotros y porque sabemos que podemos.",
                "¿Quiénes Somos?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "MISIÓN:\n\nNuestra misión es darnos a conocer a nivel nacional y lograr el objetivo de que todos los mexicanos utilicen productos mexicanos, que abramos los ojos y veamos que no porque el producto sea de otro país signifique que es mejor.",
                "Misión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "VISIÓN:\n\nNuestra visión es que una vez que nos encontremos a nivel nacional, buscaremos el mercado internacional y llevaremos el nombre de nuestro producto, de nuestro país, a todo el mundo para que sepan de lo que somos capaces.",
                "Visión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // --- 2. MENÚ PRODUCTOS ---
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmCatalogoDamas ventanaDamas = new Formularios.frmCatalogoDamas();
            ventanaDamas.ShowDialog();
        }

        private void caballerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmCatalogoCaballeros ventanaCaballeros = new Formularios.frmCatalogoCaballeros();
            ventanaCaballeros.ShowDialog();
        }

        // --- 3. MENÚ REGISTRO CON CONTRASEÑA ---
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmAccesoRegistro acceso = new Formularios.frmAccesoRegistro("Cliente");
            acceso.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmAccesoRegistro acceso = new Formularios.frmAccesoRegistro("Proveedor");
            acceso.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmAccesoRegistro acceso = new Formularios.frmAccesoRegistro("Producto");
            acceso.ShowDialog();
        }

        // --- 4. MENÚ COMPRAS ---
        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmCompras ventanaCompras = new Formularios.frmCompras();
            ventanaCompras.ShowDialog();
        }

        // --- 5. MENÚ SALIR ---
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void damasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Formularios.frmCatalogoDamas ventanaDamas = new Formularios.frmCatalogoDamas();
            ventanaDamas.ShowDialog();
        }

        private void caballerosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Formularios.frmCatalogoCaballeros ventanaCaballeros = new Formularios.frmCatalogoCaballeros();
            ventanaCaballeros.ShowDialog();
        }
    }
}