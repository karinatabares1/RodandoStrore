using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Principal
{
    public partial class AgregarUsuario : Form
    {
        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        public AgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
            
        }

        // Método para cargar los roles en el ComboBox
        private void CargarRoles()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_rol, nombre FROM rol"; // Consulta a la tabla rol

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada rol al ComboBox (mostramos el nombre, pero guardamos el id)
                            cmbRoles.Items.Add(new ComboBoxItem(reader["nombre"].ToString(), Convert.ToInt32(reader["id_rol"])));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los roles: " + ex.Message);
                }
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

            // Obtener el id_rol seleccionado
            int idRol = ((ComboBoxItem)cmbRoles.SelectedItem).Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO usuario (nombre, id_rol) VALUES (@nombre, @idRol)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@idRol", idRol);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario agregado correctamente.");
                        this.Close(); // Cierra el formulario después de guardar
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el usuario: " + ex.Message);
                }

            }
        }

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
                return Text; // Muestra el nombre en el ComboBox
            }
        }

    }
}
