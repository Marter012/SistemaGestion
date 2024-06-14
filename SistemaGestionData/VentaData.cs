using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        public static Venta ObtenerVenta(int idVenta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                string query = "SELECT * FROM Venta WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", idVenta);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string comentarios = reader.GetString(1);
                    int idUsuario = Convert.ToInt32(reader[2]);

                    Venta venta = new Venta();
                    venta.Id = idVenta;
                    venta.Comentarios = comentarios;
                    venta.IdUsuario = idUsuario;
                    return venta;
                }
                throw new Exception("IdVenta no fue encontrado");
            }
        }

        public static List<Venta> ListarVentas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            List<Venta> listaVentas = new List<Venta>();
            string query = "SELECT * FROM Venta";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Venta venta = new Venta();
                            venta.Id = Convert.ToInt32(dataReader["Id"]);
                            venta.Comentarios = dataReader["Comentarios"].ToString();
                            venta.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                            listaVentas.Add(venta);
                        }
                    }
                }
            }
            return listaVentas;
        }

        public static bool CrearVenta(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Venta(comentarios,idUsuario) values(@comentarios,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@comentarios", venta.Comentarios));
                command.Parameters.Add(new SqlParameter("@idUsuario", venta.IdUsuario));

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool ModificarVenta(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "UPDATE Venta SET comentarios = @comentarios, idUsuario= @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuario", venta.IdUsuario);
                command.Parameters.AddWithValue("Id", venta.Id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarVenta(int idVenta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", idVenta);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
