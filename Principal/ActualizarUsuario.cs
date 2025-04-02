using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using MySql.Data.MySqlClient;

namespace Principal
{
    public partial class ActualizarUsuario : Form
    {
        private BaseDatos bd;

        public ActualizarUsuario()
        {
            InitializeComponent();
            bd = new BaseDatos();
            CargarRoles();
        }

        private void CargarRoles()
        {
            Dictionary<int, string> roles = bd.ObtenerRoles();
            cmbRoles.Items.Clear();
            foreach (var rol in roles)
            {
                cmbRoles.Items.Add(new KeyValuePair<int, string>(rol.Key, rol.Value));
            }
            cmbRoles.DisplayMember = "Value";
            cmbRoles.ValueMember = "Key";
        }

        private void btnActualizaUsuario_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNombre.Text == "" || cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            int idUsuario = int.Parse(txtID.Text);
            string nuevoNombre = txtNombre.Text;
            int nuevoIdRol = ((KeyValuePair<int, string>)cmbRoles.SelectedItem).Key;

            int resultado = bd.ActualizarUsuario(idUsuario, nuevoNombre, nuevoIdRol);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del usuario a eliminar.");
                return;
            }

            int idUsuario;
            if (!int.TryParse(txtID.Text, out idUsuario))
            {
                MessageBox.Show("El ID del usuario debe ser un número válido.");
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
                int resultado = bd.EliminarUsuario(idUsuario);
                if (resultado > 0)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    txtID.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con ese ID.");
                }
            }
        }
    }
}
