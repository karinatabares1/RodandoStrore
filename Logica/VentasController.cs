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
        private BaseDatos db = new BaseDatos();

        // Crea la venta y devuelve el id generado
        public int CrearVenta(int idUsuario, decimal total)
        {
            return db.GuardarVenta(idUsuario, total);
        }

        public List<VentasEntity> ObtenerVentas()
        {
            return db.TraerVentas();
        }

        public List<VentasEntity> ObtenerVentasPorVendedor(int idUsuario)
        {
            return db.TraerVentas().Where(v => v.Id_usuario == idUsuario).ToList();
        }

        // Eliminar una venta por ID
        public int EliminarVenta(int idVenta)
        {
            return db.EliminarVenta(idVenta);
        }

        // Actualizar una venta
        public int ActualizarVenta(int idVenta, DateTime fecha, decimal total)
        {
            return db.ActualizarVenta(idVenta, fecha, total);
        }
    }
}