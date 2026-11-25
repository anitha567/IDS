using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmCatalogoCaballeros : Form
    {
        public frmCatalogoCaballeros()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string modelo = "";
            if (rbCaballero1.Checked) modelo = rbCaballero1.Text;
            else if (rbCaballero2.Checked) modelo = rbCaballero2.Text;
            else if (rbCaballero3.Checked) modelo = rbCaballero3.Text;

            if (modelo == "")
            {
                MessageBox.Show("Por favor selecciona un modelo del catálogo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> tallas = new List<string>();
            foreach (Control ctrl in gbTallas.Controls)
            {
                if (ctrl is CheckBox chk && chk.Checked)
                {
                    tallas.Add(chk.Text);
                }
            }

            if (tallas.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una talla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tallas.Sort();

            MessageBox.Show(
                "Modelo seleccionado:\n" + modelo + "\n\nTallas disponibles en tienda: " + string.Join(", ", tallas),
                "Catálogo Caballeros - Zapatería UMI",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCatalogoCaballeros_Load(object sender, EventArgs e)
        {

        }
    }
}