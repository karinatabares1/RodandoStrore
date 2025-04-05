using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class Ventas : Form
    {
        private VentasController ventasController = new VentasController();
        public Ventas()
        {
            InitializeComponent();
        }



        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            // Si el DataGridView no tiene columnas, las agregamos.
            if (dgvDetalle.Columns.Count == 0)
            {
                dgvDetalle.Columns.Add("IdProducto", "ID Producto");
                dgvDetalle.Columns.Add("Cantidad", "Cantidad");
                dgvDetalle.Columns.Add("Subtotal", "Subtotal");
            }

            // Validar los datos de entrada (ejemplo, de TextBoxes)
            if (!int.TryParse(txtIdProducto.Text, out int idProducto))
            {
                MessageBox.Show("Ingrese un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidadVentas.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precioProducto))
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular el subtotal
            decimal subtotal = cantidad * precioProducto;

            // Agregar la fila al DataGridView
            dgvDetalle.Rows.Add(idProducto, cantidad, subtotal);

            // Actualizar total de la venta (si tienes un método para ello)
            CalcularTotalVenta();
        }

        private void CalcularTotalVenta()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                // Omite la fila de nueva entrada
                if (row.IsNewRow) continue;

                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            txtTotal.Text = total.ToString("F2");
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado el ID del usuario y el total
            if (!int.TryParse(txtID.Text, out int idUsuario))
            {
                MessageBox.Show("Ingrese un ID de usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal total))
            {
                MessageBox.Show("El total de la venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear la entidad Venta
            VentasEntity venta = new VentasEntity
            {
                Id_usuario = idUsuario,
                total = total,
                // La fecha se asigna automáticamente
            };

            // Recorrer el DataGridView para crear la lista de detalles
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.IsNewRow) continue;

                DetalleVentaEntity detalle = new DetalleVentaEntity();
                detalle.Id_producto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                detalle.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                detalle.subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                venta.DetallesVentas.Add(detalle);
            }

            try
            {

                int resultado = ventasController.CrearVenta(idUsuario, total);
                if (resultado > 0)
                {
                    MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Método para limpiar los campos después de registrar la venta
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtTotal.Clear();
            dgvDetalle.Rows.Clear();
        }
    }
}

