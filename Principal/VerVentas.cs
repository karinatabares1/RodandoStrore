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
                if (MessageBox.Show("¿Deseas eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BaseDatos db = new BaseDatos();
                    db.EliminarVenta(idVenta);  // Debes tener este método en BaseDatos

                    MessageBox.Show("Venta eliminada correctamente.");
                    CargarVentas();
                    dgvDetallesVenta.DataSource = null;
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

    }
}