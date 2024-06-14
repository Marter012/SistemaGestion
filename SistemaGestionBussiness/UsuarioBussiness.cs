using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static Usuario GetUsuario(int idUsuario)
        {
            return UsuarioData.ObtenerUsuario(idUsuario);
        }
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }
        public static bool AgregarUsuario(Usuario usuario)
        {
            return UsuarioData.CrearUsuario(usuario);
        }

        public static bool ModificarUsuario(Usuario usuario)
        {
            return UsuarioData.ModificarUsuario(usuario);
        }
        public static bool EliminarUsuario(int idUsuario)
        {
            return UsuarioData.EliminarUsuario(idUsuario);
        }
    }
}
