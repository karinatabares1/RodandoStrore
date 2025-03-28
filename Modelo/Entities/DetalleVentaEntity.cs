using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class DetalleVentaEntity
    {
        public int Id_detalle_venta { get; set; }
        public int Id_ventas { get; set; }
        public int Id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        public VentasEntity ventas { get; set; }

        public ProductoEntity Producto { get; set; }

    }
}
