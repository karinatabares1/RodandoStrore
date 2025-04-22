using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logica;
using Modelo;

namespace Principal
{
    public partial class ActualizarUsuario : Form
    {
        private UsuarioController usuarioController;

        public ActualizarUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            CargarRoles();
        }

        private void CargarRoles()
        {
            try
            {
                Dictionary<int, string> roles = usuarioController.ObtenerRoles();
                cmbRoles.Items.Clear();

                foreach (var rol in roles)
                {
                    cmbRoles.Items.Add(new KeyValuePair<int, string>(rol.Key, rol.Value));
                }

                cmbRoles.DisplayMember = "Value";
                cmbRoles.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizaUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtID.Text, out int idUsuario))
            {
                MessageBox.Show("El ID del usuario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoNombre = txtNombre.Text.Trim();
            int nuevoIdRol = ((KeyValuePair<int, string>)cmbRoles.SelectedItem).Key;

            try
            {
                int resultado = usuarioController.ActualizarUsuario(idUsuario, nuevoNombre, nuevoIdRol);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario o no hubo cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del usuario a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtID.Text, out int idUsuario))
            {
                MessageBox.Show("El ID del usuario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar al usuario con ID '{idUsuario}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    int resultado = usuarioController.EliminarUsuario(idUsuario);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un usuario con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
