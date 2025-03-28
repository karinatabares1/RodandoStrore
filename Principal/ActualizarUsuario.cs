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
    public partial class ActualizarUsuario : Form
    {
        public ActualizarUsuario()
        {
            InitializeComponent();
            CargarRoles();
        }
        
        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        private void CargarRoles()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_rol, nombre FROM rol";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbRoles.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id_rol"), reader.GetString("nombre")));
                        }
                    }
                    cmbRoles.DisplayMember = "Value";
                    cmbRoles.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message);
                }
            }
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE usuario SET nombre = @nuevoNombre, id_rol = @nuevoIdRol WHERE id_usuario = @idUsuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@nuevoIdRol", nuevoIdRol);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Usuario actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }
    }
}

