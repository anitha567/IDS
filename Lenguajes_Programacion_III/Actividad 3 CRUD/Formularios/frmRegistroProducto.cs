using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Actividad_3_CRUD.Clases;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmRegistroProducto : Form
    {
        public frmRegistroProducto()
        {
            InitializeComponent();
        }

        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            txtCodigo.ReadOnly = true;
            CargarProveedores();
            CargarProductos();
        }

        private void CargarProveedores()
        {
            try
            {
                DataTable dt = ConexionBD.EjecutarConsulta("SELECT nif, nombre FROM PROVEEDORES");
                cmbProveedor.DataSource = dt;
                cmbProveedor.DisplayMember = "nombre";
                cmbProveedor.ValueMember = "nif";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de proveedores: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                string sql = @"SELECT p.codigo, p.nombre, p.precio, p.nifProveedor, pr.nombre AS proveedor
                               FROM PRODUCTOS p
                               INNER JOIN PROVEEDORES pr ON p.nifProveedor = pr.nif";
                dgvProductos.DataSource = ConexionBD.EjecutarConsulta(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            if (cmbProveedor.Items.Count > 0) cmbProveedor.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Ingresa un precio válido (ej. 750.00).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show("Registra primero al menos un proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"INSERT INTO PRODUCTOS (nombre, precio, nifProveedor)
                               VALUES (@nombre, @precio, @nifProveedor)";

                ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@precio", precio),
                    new SqlParameter("@nifProveedor", Convert.ToInt32(cmbProveedor.SelectedValue))
                );

                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Selecciona un producto de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Ingresa un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"UPDATE PRODUCTOS
                               SET nombre = @nombre, precio = @precio, nifProveedor = @nifProveedor
                               WHERE codigo = @codigo";

                int filas = ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@codigo", codigo),
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@precio", precio),
                    new SqlParameter("@nifProveedor", Convert.ToInt32(cmbProveedor.SelectedValue))
                );

                if (filas > 0)
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con ese código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Selecciona un producto de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int filas = ConexionBD.EjecutarComando("DELETE FROM PRODUCTOS WHERE codigo = @codigo", new SqlParameter("@codigo", codigo));
                    if (filas > 0)
                    {
                        MessageBox.Show("Producto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar (verifica que no esté incluido en compras): " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["precio"].Value.ToString();
                cmbProveedor.SelectedValue = Convert.ToInt32(fila.Cells["nifProveedor"].Value);
            }
        }
    }
}