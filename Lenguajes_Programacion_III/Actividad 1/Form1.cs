using System;
using System.Windows.Forms;

namespace Actividad_1
{
    public partial class frmExpediente : Form
    {
        public frmExpediente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string horario = rdbMatutino.Checked ? "Matutino" : (rdbVespertino.Checked ? "Vespertino" : "No seleccionado");
            string estado = lstEstados.SelectedItem != null ? lstEstados.SelectedItem.ToString() : "No seleccionado";

            MessageBox.Show(
                $"Expediente guardado correctamente:\n\n" +
                $"Nombre: {txtNombreCompleto.Text}\n" +
                $"Fecha de nacimiento: {txtFechaNacimiento.Text}\n" +
                $"Dirección: {txtDireccion.Text}\n" +
                $"Estado: {estado}\n" +
                $"Horario: {horario}",
                "Confirmación de Expediente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string horario = rdbMatutino.Checked ? "Matutino" : (rdbVespertino.Checked ? "Vespertino" : "No seleccionado");
            string estado = lstEstados.SelectedItem != null ? lstEstados.SelectedItem.ToString() : "No seleccionado";

            MessageBox.Show(
                $"Expediente guardado correctamente:\n\n" +
                $"Nombre: {txtNombreCompleto.Text}\n" +
                $"Fecha de nacimiento: {txtFechaNacimiento.Text}\n" +
                $"Dirección: {txtDireccion.Text}\n" +
                $"Estado: {estado}\n" +
                $"Horario: {horario}",
                "Confirmación de Expediente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}