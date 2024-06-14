using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static ProductoVendido GetProductoVendido(int idProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendido(idProductoVendido);
        }
        public static List<ProductoVendido> GetProductoVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }
        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.CrearProductoVendido(productoVendido);
        }
        public static bool ModificarProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
        public static bool EliminarProductoVendido(int idProductoVendido)
        {
            return ProductoVendidoData.EliminarProductoVendido(idProductoVendido);
        }
    }
}
