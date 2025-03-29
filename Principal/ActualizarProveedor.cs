using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using MySql.Data.MySqlClient;

namespace Principal
{
    public partial class ActualizarProveedor : Form
    {
        private int id_proveedor;
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

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=rodandoStore;user=root;password=;"))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE proveedor SET nombre = @nombre, telefono = @telefono, direccion = @direccion WHERE id_proveedor = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@id", idProveedor);

                        int resultado = cmd.ExecuteNonQuery();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }

    }
}    

