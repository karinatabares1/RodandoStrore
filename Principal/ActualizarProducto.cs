using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Principal
{
    public partial class ActualizarProducto : Form
    {
        // Cadena de conexión a la base de datos (ajústala según tu servidor)
        private string connectionString = "server=localhost;database=rodandoStore;user=root;password=;";

        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio;
            int existencia;

            // Validar que los campos numéricos sean correctos
            if (!decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(lbExistencia.Text, out existencia))
            {
                MessageBox.Show("Ingrese valores numéricos válidos en precio, cantidad y existencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();  // 🔹 Abre la conexión

                    string query = "UPDATE producto SET descripcion=@descripcion, precio=@precio, existencia=@existencia WHERE nombre=@nombre";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@existencia", existencia);

                        int rowsAffected = cmd.ExecuteNonQuery();  // 🔹 Ejecutar la consulta
                        if (rowsAffected > 0)
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se encontró el producto con ese nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizarImagen_Click_1(object sender, EventArgs e)
        {
            // Abrir un explorador de archivos para seleccionar una imagen
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccione una imagen",
                Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mostrar la imagen en el PictureBox
                pbAgregarProducto.Image = Image.FromFile(openFileDialog.FileName);
                pbAgregarProducto.Tag = openFileDialog.FileName; // Guardar la ruta en Tag
            }

            // Verificar si el usuario seleccionó una imagen
            if (pbAgregarProducto.Image == null || pbAgregarProducto.Tag == null)
            {
                MessageBox.Show("Seleccione una imagen antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto para actualizar su imagen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text;
            string imagePath = pbAgregarProducto.Tag.ToString(); // Usar la ruta guardada en Tag

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Conexión exitosa con la base de datos.");

                    string query = "UPDATE producto SET imagen=@imagen WHERE nombre=@nombre";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Convertir la imagen en bytes usando un MemoryStream
                        byte[] imageBytes; 
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbAgregarProducto.Image.Save(ms, pbAgregarProducto.Image.RawFormat);
                            imageBytes = ms.ToArray();
                        }

                        cmd.Parameters.AddWithValue("@imagen", imageBytes);
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Filas afectadas: " + rowsAffected);

                        if (rowsAffected > 0)
                            MessageBox.Show("Imagen actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se encontró el producto con ese nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
