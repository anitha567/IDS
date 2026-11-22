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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            double n3 = double.Parse(txtNum3.Text);
            double n4 = double.Parse(txtNum4.Text);
            double n5 = double.Parse(txtNum5.Text);
            double n6 = double.Parse(txtNum6.Text);

            double resultado = n1 + n2 + n3 + n4 + n5 + n6;
            txtResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            double n3 = double.Parse(txtNum3.Text);
            double n4 = double.Parse(txtNum4.Text);
            double n5 = double.Parse(txtNum5.Text);
            double n6 = double.Parse(txtNum6.Text);

            double resultado = n1 - n2 - n3 - n4 - n5 - n6;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            double n3 = double.Parse(txtNum3.Text);
            double n4 = double.Parse(txtNum4.Text);
            double n5 = double.Parse(txtNum5.Text);
            double n6 = double.Parse(txtNum6.Text);

            double resultado = n1 * n2 * n3 * n4 * n5 * n6;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            double n3 = double.Parse(txtNum3.Text);
            double n4 = double.Parse(txtNum4.Text);
            double n5 = double.Parse(txtNum5.Text);
            double n6 = double.Parse(txtNum6.Text);

            if (n2 == 0 || n3 == 0 || n4 == 0 || n5 == 0 || n6 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double resultado = n1 / n2 / n3 / n4 / n5 / n6;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNum4.Clear();
            txtNum5.Clear();
            txtNum6.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
