using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace FolderControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Ventas()
        {
            return VentaBussiness.GetVentas().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetVentaById(int id)
        {
            Venta venta = VentaBussiness.GetVenta(id);

            return Ok(venta);
        }

        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int id)
        {
            VentaBussiness.EliminarVenta(id);
        }


        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaBussiness.ModificaVenta(venta);
        }
        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }
    }
}
