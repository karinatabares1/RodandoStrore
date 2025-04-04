using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class ProveedorController
    {
        private BaseDatos db;

        public ProveedorController()
        {
            db = new BaseDatos();
        }

        // Obtener todos los proveedores
        public List<ProveedorEntity> ObtenerProveedores()
        {
            return db.TraerProveedores();
        }

        // Agregar un proveedor
        public int AgregarProveedor(string nombre, string telefono, string direccion, DateTime fecha)
        {
            return db.GuardarProveedor(nombre, telefono, direccion, fecha);
        }

        // Actualizar un proveedor
        public int ActualizarProveedor(int idProveedor, string nombre, string telefono, string direccion, DateTime fecha)
        {
            return db.ActualizarProveedor(idProveedor, nombre, telefono, direccion, fecha);
        }

        // Eliminar un proveedor
        public int EliminarProveedor(int idProveedor)
        {
            return db.EliminarProveedor(idProveedor);
        }

        // Asignar un producto a un proveedor
        public int AsignarProductoProveedor(int idProveedor, int idProducto)
        {
            return db.AsignarProductoProveedor(idProveedor, idProducto);
        }
    }
}