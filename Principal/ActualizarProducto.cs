using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Modelo.Entities;
using Logica;

namespace Principal
{
    public partial class ActualizarProducto : Form
    {
        private ProductoController controller = new ProductoController();

        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
             int idProducto = Convert.ToInt32(textIId.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string imagenUrl = pbAgregarProducto.Tag?.ToString() ?? "";

            
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int existencia = Convert.ToInt32(txtExistencia.Text);

            if (idProducto < 0)
            {
                MessageBox.Show("Ingrese un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("ID producto capturado: " + idProducto); // DEBUG

            if (precio < 0)
            {
                MessageBox.Show("Ingrese un valor numérico válido para el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (existencia < 0)
            {
                MessageBox.Show("Ingrese un valor numérico válido para la existencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int filasAfectadas = controller.ActualizarProducto(idProducto, nombre, descripcion, imagenUrl, existencia, precio);

                if (filasAfectadas > 0)
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se encontró el producto con ese ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposImagen()
        {
            if (pbAgregarProducto.Image == null || pbAgregarProducto.Tag == null)
            {
                MessageBox.Show("Seleccione una imagen antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto para actualizar su imagen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text.Trim(), out int idProducto))
            {
                MessageBox.Show("Ingrese un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                int filasAfectadas = controller.EliminarProducto(idProducto);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con ese ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtExistencia.Text = "";
            pbAgregarProducto.Image = null;
            pbAgregarProducto.Tag = null;
        }

        private Image LoadImage(string filePath)
        {
            return new Bitmap(filePath); // Evita problemas con FileStream bloqueado
        }

        private void btnActualizarImagen_Click_1(object sender, EventArgs e)
        {
            // Paso 1: Primero seleccionar la imagen
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccione una imagen",
                Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return; // Usuario canceló la selección
            }

            try
            {
                // Cargar la imagen seleccionada
                using (var temp = Image.FromFile(openFileDialog.FileName))
                {
                    pbAgregarProducto.Image = new Bitmap(temp);
                }
                pbAgregarProducto.Tag = openFileDialog.FileName;

                int idProducto = Convert.ToInt32(textIId.Text);
                // Paso 2: Ahora validar el ID después de seleccionar la imagen
                if (idProducto < 0)
                {
                    MessageBox.Show("Debe ingresar un ID de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                bool esNumeroValido = idProducto >=0 ? true : false;
                if (!esNumeroValido )
                {
                    MessageBox.Show("Ingrese un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Paso 3: Convertir la imagen a bytes
                byte[] imagenBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pbAgregarProducto.Image.Save(ms, ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }

                // Paso 4: Actualizar la imagen en la base de datos
                int filasAfectadas = controller.ActualizarImagen(idProducto, imagenBytes);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Imagen actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con ese ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
