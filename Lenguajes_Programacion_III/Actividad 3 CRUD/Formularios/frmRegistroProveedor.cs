using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Actividad_3_CRUD.Clases;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmRegistroProveedor : Form
    {
        public frmRegistroProveedor()
        {
            InitializeComponent();
        }

        private void frmRegistroProveedor_Load(object sender, EventArgs e)
        {
            txtNif.ReadOnly = true;
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                dgvProveedores.DataSource = ConexionBD.EjecutarConsulta(
                    "SELECT nif, nombre, direccion FROM PROVEEDORES");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNif.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Nombre y dirección son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"INSERT INTO PROVEEDORES (nombre, direccion)
                               VALUES (@nombre, @direccion)";

                ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@direccion", txtDireccion.Text.Trim())
                );

                MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proveedor: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNif.Text.Trim(), out int nif))
            {
                MessageBox.Show("Selecciona un proveedor de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"UPDATE PROVEEDORES
                               SET nombre = @nombre, direccion = @direccion
                               WHERE nif = @nif";

                int filas = ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@nif", nif),
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@direccion", txtDireccion.Text.Trim())
                );

                if (filas > 0)
                {
                    MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un proveedor con ese NIF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNif.Text.Trim(), out int nif))
            {
                MessageBox.Show("Selecciona un proveedor de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int filas = ConexionBD.EjecutarComando("DELETE FROM PROVEEDORES WHERE nif = @nif", new SqlParameter("@nif", nif));
                    if (filas > 0)
                    {
                        MessageBox.Show("Proveedor eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProveedores();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar (verifica que no tenga productos asociados): " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
                txtNif.Text = fila.Cells["nif"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
            }
        }
    }
}