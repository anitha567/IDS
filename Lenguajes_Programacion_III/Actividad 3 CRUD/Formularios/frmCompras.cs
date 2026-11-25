using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Actividad_3_CRUD.Clases;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            txtIdCompra.ReadOnly = true;
            CargarCombos();
            CargarCompras();
        }

        private void CargarCombos()
        {
            try
            {
                DataTable dtClientes = ConexionBD.EjecutarConsulta(
                    "SELECT dni, CAST(dni AS VARCHAR) + ' - ' + nombre + ' ' + apellidos AS clienteCompleto FROM CLIENTES");
                cmbCliente.DataSource = dtClientes;
                cmbCliente.DisplayMember = "clienteCompleto";
                cmbCliente.ValueMember = "dni";

                DataTable dtProductos = ConexionBD.EjecutarConsulta(
                    "SELECT codigo, CAST(codigo AS VARCHAR) + ' - ' + nombre + ' ($' + CAST(precio AS VARCHAR) + ')' AS productoCompleto FROM PRODUCTOS");
                cmbProducto.DataSource = dtProductos;
                cmbProducto.DisplayMember = "productoCompleto";
                cmbProducto.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listas de clientes/productos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCompras()
        {
            try
            {
                string sql = @"SELECT co.idCompra, co.dniCliente,
                                      cl.nombre + ' ' + cl.apellidos AS cliente,
                                      co.codProducto,
                                      pr.nombre AS producto,
                                      pr.precio
                               FROM COMPRAS co
                               INNER JOIN CLIENTES cl ON co.dniCliente = cl.dni
                               INNER JOIN PRODUCTOS pr ON co.codProducto = pr.codigo";
                dgvCompras.DataSource = ConexionBD.EjecutarConsulta(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtIdCompra.Clear();
            if (cmbCliente.Items.Count > 0) cmbCliente.SelectedIndex = 0;
            if (cmbProducto.Items.Count > 0) cmbProducto.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null || cmbProducto.SelectedValue == null)
            {
                MessageBox.Show("Asegúrate de tener al menos un cliente y un producto registrados.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"INSERT INTO COMPRAS (dniCliente, codProducto)
                               VALUES (@dniCliente, @codProducto)";

                ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@dniCliente", Convert.ToInt32(cmbCliente.SelectedValue)),
                    new SqlParameter("@codProducto", Convert.ToInt32(cmbProducto.SelectedValue))
                );

                MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCompras();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar compra: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCompra.Text.Trim(), out int idCompra))
            {
                MessageBox.Show("Selecciona una compra de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"UPDATE COMPRAS
                               SET dniCliente = @dniCliente, codProducto = @codProducto
                               WHERE idCompra = @idCompra";

                int filas = ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@idCompra", idCompra),
                    new SqlParameter("@dniCliente", Convert.ToInt32(cmbCliente.SelectedValue)),
                    new SqlParameter("@codProducto", Convert.ToInt32(cmbProducto.SelectedValue))
                );

                if (filas > 0)
                {
                    MessageBox.Show("Compra actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCompras();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró una compra con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar compra: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCompra.Text.Trim(), out int idCompra))
            {
                MessageBox.Show("Selecciona una compra de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar esta compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int filas = ConexionBD.EjecutarComando("DELETE FROM COMPRAS WHERE idCompra = @idCompra", new SqlParameter("@idCompra", idCompra));
                    if (filas > 0)
                    {
                        MessageBox.Show("Compra eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCompras();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar compra: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCompras.Rows[e.RowIndex];
                txtIdCompra.Text = fila.Cells["idCompra"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(fila.Cells["dniCliente"].Value);
                cmbProducto.SelectedValue = Convert.ToInt32(fila.Cells["codProducto"].Value);
            }
        }
    }
}