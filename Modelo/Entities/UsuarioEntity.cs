using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class UsuarioEntity
    {
        public int Id_usuario { get; set; }
        public string nombre { get; set; }
        public int Id_rol { get; set; }

        public RolEntity Rol { get; set; }

    }
}
