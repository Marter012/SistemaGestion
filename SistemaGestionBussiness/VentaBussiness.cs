using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static Venta GetVenta(int idVenta)
        {
            return VentaData.ObtenerVenta(idVenta);
        }
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }
        public static bool CrearVenta(Venta venta)
        {
            return VentaData.CrearVenta(venta);
        }
        public static bool ModificaVenta(Venta venta)
        {
            return VentaData.ModificarVenta(venta);
        }
        public static bool EliminarVenta(int idVenta)
        {
            return VentaData.EliminarVenta(idVenta);
        }
    }
}
