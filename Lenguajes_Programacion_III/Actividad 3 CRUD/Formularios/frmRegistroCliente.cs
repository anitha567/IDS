using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Actividad_3_CRUD.Clases;

namespace Actividad_3_CRUD.Formularios
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
        }

        private void frmRegistroCliente_Load(object sender, EventArgs e)
        {
            txtDni.ReadOnly = true;
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                dgvClientes.DataSource = ConexionBD.EjecutarConsulta(
                    "SELECT dni, nombre, apellidos, fechaNac, tfno, email FROM CLIENTES");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            dtpFechaNac.Value = DateTime.Today;
            txtTfno.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Nombre y apellidos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"INSERT INTO CLIENTES (nombre, apellidos, fechaNac, tfno, email)
                               VALUES (@nombre, @apellidos, @fechaNac, @tfno, @email)";

                ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@apellidos", txtApellidos.Text.Trim()),
                    new SqlParameter("@fechaNac", dtpFechaNac.Value.Date),
                    new SqlParameter("@tfno", txtTfno.Text.Trim()),
                    new SqlParameter("@email", txtEmail.Text.Trim())
                );

                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDni.Text.Trim(), out int dni))
            {
                MessageBox.Show("Selecciona un cliente de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"UPDATE CLIENTES
                               SET nombre = @nombre, apellidos = @apellidos, fechaNac = @fechaNac, tfno = @tfno, email = @email
                               WHERE dni = @dni";

                int filas = ConexionBD.EjecutarComando(sql,
                    new SqlParameter("@dni", dni),
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@apellidos", txtApellidos.Text.Trim()),
                    new SqlParameter("@fechaNac", dtpFechaNac.Value.Date),
                    new SqlParameter("@tfno", txtTfno.Text.Trim()),
                    new SqlParameter("@email", txtEmail.Text.Trim())
                );

                if (filas > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDni.Text.Trim(), out int dni))
            {
                MessageBox.Show("Selecciona un cliente de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int filas = ConexionBD.EjecutarComando("DELETE FROM CLIENTES WHERE dni = @dni", new SqlParameter("@dni", dni));
                    if (filas > 0)
                    {
                        MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarClientes();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar (verifica que no tenga compras registradas): " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                txtDni.Text = fila.Cells["dni"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellidos.Text = fila.Cells["apellidos"].Value.ToString();
                if (DateTime.TryParse(fila.Cells["fechaNac"].Value.ToString(), out DateTime fecha))
                {
                    dtpFechaNac.Value = fecha;
                }
                txtTfno.Text = fila.Cells["tfno"].Value.ToString();
                txtEmail.Text = fila.Cells["email"].Value.ToString();
            }
        }
    }
}