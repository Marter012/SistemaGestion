using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static Producto GetProducto(int idProducto)
        {
            return ProductoData.ObtenerProducto(idProducto);
        }
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }
        public static bool CrearProducto(Producto producto)
        {
            return ProductoData.CrearProducto(producto);
        }
        public static bool ModificarProducto(Producto producto)
        {
            return ProductoData.ModificarProducto(producto);
        }
        public static bool EliminarProducto(int idProducto)
        {
            return ProductoData.EliminarProducto(idProducto);
        }
    }
}
