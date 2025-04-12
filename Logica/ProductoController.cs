using System.Collections.Generic;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ProductoController
    {
        private readonly BaseDatos db;

        public ProductoController()
        {
            db = new BaseDatos();
        }

        // Obtener lista de productos
        public List<ProductoEntity> ObtenerProductos()
        {
            return db.TraerProductos();
        }

        // Guardar un nuevo producto
        public int GuardarProducto(string nombre, string descripcion, string imagenUrl, int existencia, decimal precio)
        {
            int resultado = db.GuardarProducto(nombre, descripcion, imagenUrl, existencia, precio);

            return resultado;
        }

        // Actualizar un producto existente
        public int ActualizarProducto(int idProducto, string nombre, string descripcion, string imagenUrl, int existencia, decimal precio)
        {
            int resultado = db.ActualizarProducto(idProducto, nombre, descripcion, imagenUrl, existencia, precio);

            return resultado;
        }

        // Eliminar producto por ID
        public int EliminarProducto(int idProducto)
        {
         return db.EliminarProducto(idProducto);

        }

        // Actualizar solo la imagen del producto
        // Actualizar solo la imagen del producto (ahora con idProducto)
        // En ProductoController.cs
        public int ActualizarImagen(int idProducto, byte[] imagen)
        {
            // Aquí necesitarías una nueva función en BaseDatos para buscar por nombre
            int resultado = db.ActualizarImagenProducto(idProducto, imagen);
            return resultado;
        }


    }
}
