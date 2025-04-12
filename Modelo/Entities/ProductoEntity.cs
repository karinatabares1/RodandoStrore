using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductoEntity
    {
        public int Id_producto { get; set; }
        public string  nombre { get; set; }
        public string imagen_url { get; set; }
        public int existencia { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
    }

}
