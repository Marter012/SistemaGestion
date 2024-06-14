using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace FolderControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> Productos()
        {
            return ProductoBussiness.GetProductos().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GeProductoById(int id)
        {
            Producto producto = ProductoBussiness.GetProducto(id);

            return Ok(producto);
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int id)
        {
            ProductoBussiness.EliminarProducto(id);
        }


        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }
        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }
    }
}
