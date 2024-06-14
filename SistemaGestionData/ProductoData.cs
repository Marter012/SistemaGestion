using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoData
    {
        public static Producto ObtenerProducto(int idProducto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                string query = "SELECT * FROM Producto WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", idProducto);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string descripcion = reader.GetString(1);
                    double costo = Convert.ToDouble(reader[2]);
                    int precioVenta = Convert.ToInt32(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUsuario = Convert.ToInt32(reader[5]);


                    Producto producto = new Producto();
                    producto.Id = id;
                    producto.Descripcion = descripcion;
                    producto.Costo = costo;
                    producto.PrecioVenta = precioVenta;
                    producto.Stock = stock;
                    producto.IdUsuario = idUsuario;
                    return producto;
                }
                throw new Exception("IdProducto no fue encontrado");
            }
        }

        public static List<Producto> ListarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();


            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            var query = "SELECT * FROM Producto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["idUsuario"]);
                                listaProductos.Add(producto);

                            }
                        }
                        return listaProductos;

                    }


                }
            }
        }

        public static bool CrearProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Descripciones", producto.Descripcion));
                command.Parameters.Add(new SqlParameter("@Costo", producto.Costo));
                command.Parameters.Add(new SqlParameter("@PrecioVenta", producto.PrecioVenta));
                command.Parameters.Add(new SqlParameter("@Stock", producto.Stock));
                command.Parameters.Add(new SqlParameter("@IdUsuario", producto.IdUsuario));

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET Descripciones = @descripciones, Costo = @costo, PrecioVenta= @precioVenta, Stock = @stock, IdUsuario = @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("descripciones", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                command.Parameters.AddWithValue("id", producto.Id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarProducto(int idProducto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", idProducto);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
