using Logica;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Principal
{
    public partial class VerProductos : Form
    {
        private ProductoController productoController;

        public VerProductos()
        {
            InitializeComponent();
            productoController = new ProductoController();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                List<ProductoEntity> listaProductos = productoController.ObtenerProductos();

                DataTable dt = new DataTable();
                dt.Columns.Add("id_producto", typeof(int));
                dt.Columns.Add("nombre", typeof(string));
                dt.Columns.Add("descripcion", typeof(string));
                dt.Columns.Add("precio", typeof(decimal));
                dt.Columns.Add("existencia", typeof(int));

                foreach (ProductoEntity producto in listaProductos)
                {
                    dt.Rows.Add(producto.Id_producto, producto.nombre, producto.descripcion,
                                producto.precio, producto.existencia);
                }

                dgvProductos.DataSource = dt;
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }
    }
}
