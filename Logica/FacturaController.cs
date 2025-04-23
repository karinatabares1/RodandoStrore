using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class FacturaController
    {
        private BaseDatos bd;

        public FacturaController()
        {
            bd = new BaseDatos();
        }

        public int CrearFactura(int idVentas, string metodoPago, string direccionEntrega)
        {
            return bd.GuardarFactura(idVentas, metodoPago, direccionEntrega);
        }

        public List<FacturaEntity> ObtenerFacturas()
        {
            return bd.TraerFacturas();
        }
    }
}