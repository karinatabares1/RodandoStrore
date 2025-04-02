using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Principal
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        // Método para cargar los roles desde la base de datos
        private void CargarRoles()
        {
            BaseDatos bd = new BaseDatos();
            Dictionary<int, string> roles = bd.ObtenerRoles();
            foreach (var role in roles)
            {
                // Se agrega el rol al ComboBox, mostrando el nombre y guardando el id
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

            // Llamada al método GuardarUsuario de BaseDatos
            BaseDatos bd = new BaseDatos();
            try
            {
                int resultado = bd.GuardarUsuario(nombre, idRol);
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
