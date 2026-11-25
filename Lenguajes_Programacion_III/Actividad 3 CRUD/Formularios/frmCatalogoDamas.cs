using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmCatalogoDamas : Form
    {
        public frmCatalogoDamas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string modelo = "";
            if (rbDama1.Checked) modelo = rbDama1.Text;
            else if (rbDama2.Checked) modelo = rbDama2.Text;
            else if (rbDama3.Checked) modelo = rbDama3.Text;

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
                "Catálogo Damas - Zapatería UMI",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}