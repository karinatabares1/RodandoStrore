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
    public partial class RegistrarVentas : Form
    {
        List<DetalleVentaEntity> listaDetalleVenta = new List<DetalleVentaEntity>();

        public RegistrarVentas()
        {
            InitializeComponent();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Selecciona un producto y escribe la cantidad.");
                return;
            }

            ProductoEntity productoSeleccionado = (ProductoEntity)cbxProducto.SelectedItem;

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            // Calcular subtotal
            decimal subtotal = productoSeleccionado.precio * cantidad;

            // Crear el detalle y agregarlo a la lista
            DetalleVentaEntity detalle = new DetalleVentaEntity
            {
                Id_producto = productoSeleccionado.Id_producto,
                cantidad = cantidad,
                subtotal = subtotal,
                Producto = productoSeleccionado
            };

            listaDetalleVenta.Add(detalle);

            // Actualizar DataGridView
            dgvDetalle.Rows.Add(productoSeleccionado.nombre, cantidad, productoSeleccionado.precio, subtotal);

            // Actualizar total
            decimal totalActual = string.IsNullOrEmpty(txtTotal.Text) ? 0 : decimal.Parse(txtTotal.Text);
            totalActual += subtotal;
            txtTotal.Text = totalActual.ToString("0.00");

            // Limpiar campos
            txtCantidad.Text = "";
            cbxProducto.SelectedIndex = -1;
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debes agregar al menos un producto antes de registrar la venta.");
                return;
            }

            try
            {
                VentasController ventasController = new VentasController();

                // Calcular total de la venta
                decimal totalVenta = 0;
                foreach (DataGridViewRow fila in dgvDetalle.Rows)
                {
                    totalVenta += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                }

                // Registrar la venta y obtener el ID generado
                int idVentaGenerado = ventasController.CrearVenta(Session.UserId, totalVenta);

                // Registrar los detalles
                DetalleVentasController detalleController = new DetalleVentasController();

                foreach (DataGridViewRow fila in dgvDetalle.Rows)
                {
                    int idProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(fila.Cells["Subtotal"].Value);

                    // Llamada directa con parámetros como lo requiere tu método
                    detalleController.CrearDetalle(idVentaGenerado, idProducto, cantidad, subtotal);
                }

                MessageBox.Show("¡Venta registrada exitosamente!");
                dgvDetalle.Rows.Clear();
                txtTotal.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }


    }
}
