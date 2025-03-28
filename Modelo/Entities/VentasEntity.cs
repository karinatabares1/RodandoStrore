using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class VentasEntity
    {
        public int Id_ventas { get; set; }
        public int Id_usuario { get; set; }
        public DateTime fecha{ get; set; } = DateTime.Now;
        public decimal total { get; set; } 

        // esta va a ser relacion con usuario

        public UsuarioEntity usuario {  get; set; }

        public List<DetalleVentaEntity>
            DetallesVentas
        { get; set; } = new List<DetalleVentaEntity>();
    }
}
