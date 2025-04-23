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
    public partial class FormCompra : Form
    {
        private List<ProductoEntity> productos;
        private List<ItemCarrito> carrito;
        private ProductoController productoController = new ProductoController();
        private VentasController ventaController = new VentasController();
        private FacturaController facturaController = new FacturaController();
        public FormCompra()
        {
            InitializeComponent();
            productos = productoController.ObtenerProductos(); // ✅ Usa la variable global
            carrito = new List<ItemCarrito>();
            this.Load += FormCompra_Load;
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            // 1) Asegúrate de empezar desde cero
            dgvCarrito.Columns.Clear();
            dgvCarrito.Rows.Clear();

            // 2) Añade tus columnas
            dgvCarrito.Columns.Add("Producto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarProductos();
        }

        private void CargarProductos()
        {
            productos = productoController.ObtenerProductos(); // Asigna a la variable global

            foreach (ProductoEntity producto in productos)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = new Size(180, 280);

                PictureBox imagen = new PictureBox();
                imagen.Size = new Size(160, 120);
                imagen.Location = new Point(10, 10);
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;

                //string rutaCarpetaImagenes = Path.Combine(Application.StartupPath, "imagenes");
                //string rutaImagen = Path.Combine(rutaCarpetaImagenes, producto.imagen_url);

                //if (File.Exists(rutaImagen))
                //{
                //    imagen.Image = Image.FromFile(rutaImagen);
                //}
                //else
                //{
                //    MessageBox.Show($"La imagen '{producto.imagen_url}' no se encuentra en la carpeta.");
                //}
                // Dentro de tu bucle de CargarProductos, antes de File.Exists:
                string rutaCarpetaImagenes = Path.Combine(Application.StartupPath, "imagenes");
                string rutaImagen = Path.Combine(rutaCarpetaImagenes, producto.imagen_url);

                // 1) Muéstrame la ruta completa que está buscando:
                MessageBox.Show($"Buscando en:\n{rutaImagen}");

                // 2) Comprueba si el archivo existe:
                if (!File.Exists(rutaImagen))
                {
                    MessageBox.Show("NO ENCONTRADO: " + rutaImagen);
                }
                else
                {
                    imagen.Image = Image.FromFile(rutaImagen);
                }


                Label nombre = new Label();
                nombre.Text = producto.nombre;
                nombre.AutoSize = false;
                nombre.Size = new Size(160, 30);
                nombre.Location = new Point(10, 140);
                nombre.TextAlign = ContentAlignment.MiddleCenter;

                Label precio = new Label();
                precio.Text = "$" + producto.precio.ToString("N2");
                precio.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                precio.ForeColor = Color.Green;
                precio.Size = new Size(160, 25);
                precio.Location = new Point(10, 170);
                precio.TextAlign = ContentAlignment.MiddleCenter;

                Button btnAgregar = new Button();
                btnAgregar.Text = "Agregar al carrito";
                btnAgregar.Size = new Size(160, 30);
                btnAgregar.Location = new Point(10, 210);
                btnAgregar.Tag = producto;
                btnAgregar.Click += btnAgregarCarrito_Click;

                card.Controls.Add(imagen);
                card.Controls.Add(nombre);
                card.Controls.Add(precio);
                card.Controls.Add(btnAgregar);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ActualizarCarrito()
        {
            dgvCarrito.Rows.Clear();

            // ✅ Verifica si los datos están en el carrito
            Console.WriteLine("CARRITO TIENE: " + carrito.Count + " PRODUCTOS");

            foreach (var item in carrito)
            {
                Console.WriteLine($"Agregando {item.Producto.nombre}, cantidad: {item.Cantidad}");
                dgvCarrito.Rows.Add(item.Producto.nombre, item.Cantidad, item.Producto.precio, item.Cantidad * item.Producto.precio);
            }
        }


        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            ProductoEntity producto = boton.Tag as ProductoEntity;

            // Verificar si el producto ya está en el carrito
            ItemCarrito itemExistente = carrito.FirstOrDefault(i => i.Producto.Id_producto == producto.Id_producto);

            if (itemExistente != null)
            {
                // Si ya existe, aumentar la cantidad
                itemExistente.Cantidad++;
            }
            else
            {
                // Si no existe, agregar nuevo item
                carrito.Add(new ItemCarrito
                {
                    Producto = producto,
                    Cantidad = 1
                });
            }

            // Mostrar mensaje y actualizar tabla
            MessageBox.Show($"Producto '{producto.nombre}' agregado al carrito.");
            ActualizarCarrito();
        }
        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            int idUsuario = 1; // Simulado
            decimal total = carrito.Sum(i => i.Cantidad * i.Producto.precio);

            // 1) Crear la venta en BD
            int idVenta = ventaController.CrearVenta(idUsuario, total);

            // 2) Crear cada detalle en BD
            foreach (var item in carrito)
            {
                var detalleController = new DetalleVentasController();
                detalleController.CrearDetalle(
                    idVenta,
                    item.Producto.Id_producto,
                    item.Cantidad,
                    item.Cantidad * item.Producto.precio
                );
            }

            // 3) Crear la factura en BD
            facturaController.CrearFactura(idVenta, "Efectivo", "Sin dirección");

            MessageBox.Show("¡Compra confirmada! Se ha generado la factura.");

            // 4) Redirigir al formulario de Facturas
            this.Hide();                      // opcional: oculta el FormCompra
            var frmFacturas = new Factura();  // tu Form que lista facturas
            frmFacturas.ShowDialog();         // lo abre en modo modal
            this.Show();                      // opcional: al cerrar Factura, vuelve a mostrar FormCompra

            // 5) Limpiar carrito y refrescar tabla
            carrito.Clear();
            ActualizarCarrito();
        }
    }

    public class ItemCarrito
    {
        public ProductoEntity Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
