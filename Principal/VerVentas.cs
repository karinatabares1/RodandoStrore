using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Modelo;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Principal
{
    public partial class VerVentas : Form
    {
        private VentasController ventasController;
        public VerVentas()
        {
            InitializeComponent();
            ventasController = new VentasController();
            CargarVentas();
        }

        private void CargarVentas()
        {
            try
            {
                List<VentasEntity> ventas = ventasController.ObtenerVentas();

                DataTable dt = new DataTable();
                dt.Columns.Add("id_ventas", typeof(int));
                dt.Columns.Add("usuario", typeof(string));
                dt.Columns.Add("fecha", typeof(DateTime));
                dt.Columns.Add("total", typeof(decimal));

                foreach (var venta in ventas)
                {
                    dt.Rows.Add(venta.Id_ventas, venta.usuario.nombre, venta.fecha, venta.total);
                }


                dgvVentas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message);
            }
        }
        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idVenta = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells[0].Value);
                CargarDetallesVenta(idVenta);
            }
        }
        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int idVenta = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells[0].Value);
                CargarDetallesVenta(idVenta);
            }
            else
            {
                MessageBox.Show("Selecciona una venta para ver los detalles.");
            }
        }

        private void CargarDetallesVenta(int idVenta)
        {
            try
            {
                DetalleVentasController detalleVentas = new DetalleVentasController();
                var detalles = detalleVentas.TraerDetalles(idVenta);  // Debes tener este método en BaseDatos

                DataTable dt = new DataTable();
                dt.Columns.Add("id_producto", typeof(int));
                dt.Columns.Add("cantidad", typeof(int));
                dt.Columns.Add("subtotal", typeof(decimal));

                foreach (var detalle in detalles)
                {
                    dt.Rows.Add(detalle.Id_producto, detalle.cantidad, detalle.subtotal);
                }

                dgvDetallesVenta.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles de venta: " + ex.Message);
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int idVenta = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells[0].Value);

                DialogResult resultado = MessageBox.Show("¿Deseas eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Crear instancia del controller de detalles
                    DetalleVentasController detalleController = new DetalleVentasController();

                    // Traer los detalles de la venta seleccionada
                    var detalles = detalleController.TraerDetalles(idVenta);

                    // Eliminar todos los detalles de la venta
                    foreach (var detalle in detalles)
                    {
                        detalleController.EliminarDetalleVenta(detalle.Id_detalle_venta);
                    }

                    // Ahora eliminar la venta
                    int filasAfectadas = ventasController.EliminarVenta(idVenta);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Venta eliminada correctamente.");
                        CargarVentas(); // Recargar la lista de ventas
                        dgvDetallesVenta.DataSource = null; // Limpiar detalles
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la venta.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una venta para eliminar.");
            }
        }

        private void VerVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int idVenta = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells[0].Value);
                DateTime nuevaFecha = dtpFechaVenta.Value;

                // Calcular el nuevo total desde los subtotales del dgvDetallesVenta
                decimal nuevoTotal = 0;

                foreach (DataGridViewRow fila in dgvDetallesVenta.Rows)
                {
                    if (fila.Cells["subtotal"].Value != null)
                    {
                        decimal subtotal;
                        if (decimal.TryParse(fila.Cells["subtotal"].Value.ToString(), out subtotal))
                        {
                            nuevoTotal += subtotal;
                        }
                    }
                }

                int filasAfectadas = ventasController.ActualizarVenta(idVenta, nuevaFecha, nuevoTotal);

                if (filasAfectadas > 0)
                {
                    // Actualizar detalles de venta
                    DetalleVentasController detalleController = new DetalleVentasController();

                    foreach (DataGridViewRow fila in dgvDetallesVenta.Rows)
                    {
                        if (fila.Cells["id_producto"].Value != null &&
                            fila.Cells["cantidad"].Value != null &&
                            fila.Cells["subtotal"].Value != null)
                        {
                            int idProducto = Convert.ToInt32(fila.Cells["id_producto"].Value);
                            int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                            decimal subtotal = Convert.ToDecimal(fila.Cells["subtotal"].Value);

                            detalleController.ActualizarDetalleVenta(idVenta, idProducto, cantidad, subtotal);
                        }
                    }

                    MessageBox.Show("Venta actualizada correctamente.");
                    CargarVentas();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la venta.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una venta para actualizar.");
            }

        }
    }
}