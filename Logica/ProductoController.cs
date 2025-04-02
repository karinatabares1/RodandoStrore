using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ProductoController
    {
        public List<ProductoEntity> verProductos()
        {
            BaseDatos db = new BaseDatos();
            List<ProductoEntity> productos = db.TraerProductos();
            return productos;
        }

        public string GuardarProducto(string nombre, string descripcion, string imagenUrl, int existencia, decimal precio)
        {
            BaseDatos db = new BaseDatos();
            int resultado = db.GuardarProducto(nombre, descripcion, imagenUrl, existencia, precio);
            if (resultado > 0)
            {
                return "Producto guardado";
            }
            else
            {
                return "Error al guardar el producto";
            }
        }

    }
}
