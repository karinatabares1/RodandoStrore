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
    public partial class ActualizarProducto : Form
    {
        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            int existencia = int.Parse(lbExistencia.Text);
            string imagePath = pbAgregarProducto.ImageLocation;

            try
            {
              
                {
                    
                    string query = "UPDATE productos SET descripcion=@descripcion, precio=@precio, cantidad=@cantidad, existencia=@existencia, imagen=@imagen WHERE nombre=@nombre";

                    using (MySqlCommand cmd = new MySqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@existencia", existencia);

                        // Guardar la imagen como bytes
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            byte[] imageBytes = File.ReadAllBytes(imagePath);
                            cmd.Parameters.AddWithValue("@imagen", imageBytes);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@imagen", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
    }
}
