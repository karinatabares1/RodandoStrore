using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class VentasController
    {
        private BaseDatos db;

        public VentasController()
        {
            db = new BaseDatos();
        }

        // VENTAS

        // Obtener todas las ventas
        public List<VentasEntity> ObtenerVentas()
        {
            return db.TraerVentas();
        }

        // Registrar una venta (cabecera)
        public int CrearVenta(int idUsuario, decimal total)
        {
            return db.GuardarVenta(idUsuario, total);
        }

        // Actualizar una venta
        public int ActualizarVenta(int idVenta, int idUsuario, decimal total)
        {
            return db.ActualizarVenta(idVenta, idUsuario, total);
        }

        // Eliminar una venta
        public int EliminarVenta(int idVenta)
        {
            return db.EliminarVenta(idVenta);
        }

        // DETALLE DE VENTAS

        // Obtener el detalle de una venta
        public List<DetalleVentaEntity> ObtenerDetalleVenta(int idVenta)
        {
            return db.TraerDetalleVentas(idVenta);
        }

        // Agregar un detalle de venta
        public int CrearDetalleVenta(int idVentas, int idProducto, int cantidad, decimal subtotal)
        {
            return db.GuardarDetalleVenta(idVentas, idProducto, cantidad, subtotal);
        }

        // Actualizar un detalle de venta
        public int ActualizarDetalleVenta(int idDetalleVenta, int idVentas, int idProducto, int cantidad, decimal subtotal)
        {
            return db.ActualizarDetalleVenta(idDetalleVenta, idVentas, idProducto, cantidad, subtotal);
        }

        // Eliminar un detalle de venta
        public int EliminarDetalleVenta(int idDetalleVenta)
        {
            return db.EliminarDetalleVenta(idDetalleVenta);
        }
    }
}
