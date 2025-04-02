using Modelo;
using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class ActualizarProveedor : Form
    {
        public ActualizarProveedor()
        {
            InitializeComponent();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            int idProveedor;
            if (!int.TryParse(txtID.Text, out idProveedor))
            {
                MessageBox.Show("El ID del proveedor debe ser un número válido.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            try
            {
                BaseDatos bd = new BaseDatos();
                int resultado = bd.ActualizarProveedor(idProveedor, nombre, telefono, direccion);
                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró el proveedor o los datos no han cambiado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor;
            if (!int.TryParse(txtID.Text, out idProveedor))
            {
                MessageBox.Show("El ID del proveedor debe ser un número válido para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el proveedor con ID '{idProveedor}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    BaseDatos bd = new BaseDatos();
                    int resultado = bd.EliminarProveedor(idProveedor);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Proveedor eliminado correctamente.");
                        // Opcional: Limpiar campos después de eliminar
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                        txtID.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un proveedor con ese ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
                }
            }
        }
    }
}
