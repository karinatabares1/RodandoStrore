using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logica; // Importar el controlador

namespace Principal
{
    public partial class AgregarUsuario : Form
    {
        private UsuarioController usuarioController; // Usamos el controlador

        public AgregarUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            CargarRoles();
        }

        // Método para cargar los roles desde el controlador
        private void CargarRoles()
        {
            Dictionary<int, string> roles = usuarioController.ObtenerRoles();
            cmbRoles.Items.Clear();

            foreach (var role in roles)
            {
                cmbRoles.Items.Add(new ComboBoxItem(role.Value, role.Key));
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese un nombre y seleccione un rol.");
                return;
            }

            // Obtener el id del rol seleccionado
            int idRol = ((ComboBoxItem)cmbRoles.SelectedItem).Value;

            try
            {
                int resultado = usuarioController.AgregarUsuario(nombre, idRol);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario agregado correctamente.");
                    this.Close(); // Cierra el formulario tras guardar
                }
                else
                {
                    MessageBox.Show("Error al guardar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
        }

        // Clase auxiliar para manejar los elementos del ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text; // Se muestra el nombre en el ComboBox
            }
        }
    }
}
