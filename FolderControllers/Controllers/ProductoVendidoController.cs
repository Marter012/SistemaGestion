using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace FolderControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> ProductosVendidos()
        {
            return ProductoVendidoBussiness.GetProductoVendidos().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoVendidoById(int id)
        {
            ProductoVendido productoVendido = ProductoVendidoBussiness.GetProductoVendido(id);

            return Ok(productoVendido);
        }

        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(id);
        }


        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }
        [HttpPost(Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }
    }
}
