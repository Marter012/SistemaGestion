using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int idProductoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                string query = "SELECT * FROM ProductoVendido WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", idProductoVendido);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    int _id = Convert.ToInt32(reader[0]);
                    int idProducto = Convert.ToInt32(reader[1]);
                    int stock = Convert.ToInt32(reader[2]);
                    int idVenta = Convert.ToInt32(reader[3]);

                    ProductoVendido productoVendido = new ProductoVendido();
                    productoVendido.Id = _id;
                    productoVendido.IdProducto = idProducto;
                    productoVendido.Stock = stock;
                    productoVendido.IdVenta = idVenta;
                    return productoVendido;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            List<ProductoVendido> listaProductosVendidos = new List<ProductoVendido>();
            string query = "SELECT * FROM ProductoVendido";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            ProductoVendido productoVendido = new ProductoVendido();
                            productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                            productoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                            productoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                            productoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);

                            listaProductosVendidos.Add(productoVendido);
                        }
                    }
                }
            }
            return listaProductosVendidos;
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ProductoVendido(idProducto,stock,idVenta) values(@idProducto,@stock,@idVenta)";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("idProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("stock", productoVendido.Stock);
                command.Parameters.AddWithValue("idVenta", productoVendido.IdVenta);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ProductoVendido SET idProducto = @idProducto, stock = @stock, idVenta= @idVenta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("idProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("stock", productoVendido.Stock);
                command.Parameters.AddWithValue("idVenta", productoVendido.IdVenta);
                command.Parameters.AddWithValue("id", productoVendido.Id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }

        public static bool EliminarProductoVendido(int idProductoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ProductoVendido WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", idProductoVendido);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
