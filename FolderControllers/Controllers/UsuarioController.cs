using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace FolderControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Usuarios()
        {
            return UsuarioBussiness.GetUsuarios().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            Usuario usuario = UsuarioBussiness.GetUsuario(id);

            return Ok(usuario);
        }

        [HttpDelete(Name = "EliminarUsuario")]
        public void Delete([FromBody] int id)
        {
            UsuarioBussiness.EliminarUsuario(id);
        }


        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }
        [HttpPost(Name = "AltaUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.AgregarUsuario(usuario);
        }
    }
}
