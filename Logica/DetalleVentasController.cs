using System.Collections.Generic;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class DetalleVentasController
    {
        private BaseDatos db = new BaseDatos();

        // Guarda un detalle de venta
        public int CrearDetalle(int idVenta, int idProducto, int cantidad, decimal subtotal)
        {
            return db.GuardarDetalleVenta(idVenta, idProducto, cantidad, subtotal);
        }

        // Trae todos los detalles (útil para VerVentas)
        public List<DetalleVentaEntity> TraerDetalles(int idVenta)
        {
            return db.TraerDetalleVentas(idVenta);
        }

        // Actualizar un detalle de venta existente
        public int ActualizarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal subtotal)
        {
            return db.ActualizarDetalleVenta(idVenta, idProducto, cantidad, subtotal);
        }

        // Eliminar un detalle de venta específico (opcional, si lo necesitas)
        public int EliminarDetalleVenta(int idDetalleVenta)
        {
            return db.EliminarDetalleVenta(idDetalleVenta);
        }
    }
}
