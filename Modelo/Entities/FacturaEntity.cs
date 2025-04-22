using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaEntity
    {
        public int Id_factura { get; set; }
        public int Id_ventas { get; set; }
        public DateTime Fecha_emision { get; set; }
        public string Metodo_pago { get; set; }
        public string Direccion_entrega { get; set; }
    }

}
