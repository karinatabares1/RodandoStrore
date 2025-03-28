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
        public List<VentasEntity> verVentas()
        {
            BaseDatos db = new BaseDatos();
            List<VentasEntity> ventas = db.TraerVentas();
            return ventas;
        }
        public string GuardarVenta(int idUsuario, decimal total)
        {
            BaseDatos db = new BaseDatos();
            int resultado = db.GuardarVenta(idUsuario, total);
            if (resultado > 0)
            {
                return "Venta guardada";
            }
            else
            {
                return "Error al guardar la venta";
            }
        }
    }
}
