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
        public List<UsuarioEntity> verUsuarios()
        {
            BaseDatos db = new BaseDatos();
            List<UsuarioEntity> usuarios = db.TraerUsuarios();
            return usuarios;

        }

        public string GuardarUsuario(string nombre, int Id_Rol)
        {
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.GuardarUsuario(nombre, Id_Rol);
            if (filasAfectadas > 0)
            {
                return "Usuario guardado";
            }
            else
            {
                return "Error al guardar el usuario";
            }
        }
    }
}
