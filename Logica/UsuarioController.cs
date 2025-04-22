using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class UsuarioController
    {
        private BaseDatos db = new BaseDatos();

        // Obtener todos los usuarios
        public List<UsuarioEntity> ObtenerUsuarios()
        {
            return db.TraerUsuarios();
        }

        // Agregar usuario
        public int AgregarUsuario(string nombre, int idRol)
        {
            return db.GuardarUsuario(nombre, idRol);
        }

        public Dictionary<int, string> ObtenerRoles()
        {
            return db.ObtenerRoles();
        }

        // Actualizar usuario
        public int ActualizarUsuario(int id, string nombre, int idRol)
        {
            return db.ActualizarUsuario(id, nombre, idRol);
        }

        // Eliminar usuario
        public int EliminarUsuario(int id)
        {
            return db.EliminarUsuario(id);
        }

        public UsuarioEntity ValidarCredenciales(string nombre)
        {
            List<UsuarioEntity> usuarios = db.TraerUsuarios();
            return usuarios
                .FirstOrDefault(u =>
                    u.nombre.Equals(nombre,
                        System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
