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

namespace Principal
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private string imagenRuta = "";

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagenRuta = openFileDialog.FileName;
                pbAgregarProducto.Image = new Bitmap(imagenRuta);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtCantidad.Text) ||
                string.IsNullOrEmpty(imagenRuta))
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar la imagen en la carpeta del proyecto
            string carpetaDestino = @"C:\ImagenesProductos\";
            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }

            string nombreArchivo = Path.GetFileName(imagenRuta);
            string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);
            File.Copy(imagenRuta, rutaDestino, true); // Copia la imagen a la carpeta destino

            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int existencia = cantidad;  // Puedes modificar esto si la existencia es diferente
            string imagenUrl = rutaDestino;  // Guardamos la ruta de la imagen

            // Guardar en la base de datos
            BaseDatos bd = new BaseDatos();
            int resultado = bd.GuardarProducto(nombre, descripcion, imagenUrl, existencia, precio, cantidad);

            if (resultado > 0)
            {
                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
