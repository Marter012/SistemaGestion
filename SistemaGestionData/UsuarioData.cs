using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        public static Usuario ObtenerUsuario(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                string query = "SELECT * FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int _id = Convert.ToInt32(reader[0]);
                    string _name = reader.GetString(1);
                    string _apellido = reader.GetString(2);
                    string _nombreUsuario = reader.GetString(3);
                    string _contraseña = reader.GetString(4);
                    string _email = reader.GetString(5);

                    Usuario usuario = new Usuario();
                    usuario.Id = _id;
                    usuario.Nombre = _name;
                    usuario.NombreUsuario = _nombreUsuario;
                    usuario.Apellido = _apellido;
                    usuario.Contraseña = _contraseña;
                    usuario.Email = _email;
                    return usuario;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static List<Usuario> ListarUsuarios()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT * FROM Usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Email = dataReader["Mail"].ToString();

                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return listaUsuarios;
            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO USUARIO(Nombre, Apellido,NombreUsuario,Contraseña,Mail) values(@Nombre, @Apellido,@NombreUsuario,@Contraseña,@Mail)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", usuario.Apellido));
                command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreUsuario));
                command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contraseña));
                command.Parameters.Add(new SqlParameter("@Mail", usuario.Email));

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, nombreUsuario= @nombreUsuario, contraseña = @password, mail = @email WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Contraseña);
                command.Parameters.AddWithValue("email", usuario.Email);
                command.Parameters.AddWithValue("id", usuario.Id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarUsuario(int userId)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", userId);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
