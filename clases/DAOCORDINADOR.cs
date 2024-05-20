using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using MySqlConnector;
using System.Xml.Linq;

namespace PROYECTOFINALPROGRA1.clases
{
    public class DaoCoordinador
        {

        private string connectionString = "server=127.0.0.1;" +
                                          "user=root;" +
                                          "password=;" +
                                          "database=lms;"; // Cambia el nombre de la base de datos aquí

        // Método para obtener todos los usuarios
        public List<Coordinador> ObtenerTodosLosCoordinadores()
        {
            List<Coordinador> listaCoordinadores = new List<Coordinador>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Apertura de la conexión
                conn.Open();
                // Diseño de la consulta
                string query = "SELECT id, nombre, email, contrasena FROM usuarios";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Coordinador coordinador = new Coordinador
                            {
                                id = Convert.ToInt32(reader["id"]),
                                nombre = reader["nombre"].ToString(),
                                contrasena = reader["contrasena"].ToString(),
                                email = reader["email"].ToString()
                            };

                            listaCoordinadores.Add(usuario);
                        }
                    }
                }
            }
            return listaCoordinadores;
        }

        // Método para obtener un usuario por id
        public Usuario ObtenerCoordinadorPorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Apertura de la conexión
                conn.Open();
                // Consulta
                string query = "SELECT id, nombre, contrasena, email FROM usuarios WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Coordinador coordinador = new Coordinador
                            {
                                id = Convert.ToInt32(reader["id"]),
                                nombre = reader["nombre"].ToString(),
                                contrasena = reader["contrasena"].ToString(),
                                email = reader["email"].ToString()
                            };

                            return coordinador;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        // Método para insertar un nuevo usuario
        public void InsertarCoordinador(Coordinador coordinador)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Apertura de la conexión
                conn.Open();
                // Genero la consulta
                string query = "INSERT INTO usuarios (nombre, contrasena, email) VALUES (@nombre, @contrasena, @email)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", coordinador.nombre);
                    cmd.Parameters.AddWithValue("@contrasena", coordinador.contrasena);
                    cmd.Parameters.AddWithValue("@email", coordinador.email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un usuario
        public void Actualizoordinador coordinador)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE usuarios SET nombre = @nombre, contrasena = @contrasena, email = @email WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", coordinador.nombre);
                    cmd.Parameters.AddWithValue("@contrasena", coordinador.contrasena);
                    cmd.Parameters.AddWithValue("@email", coordinador.email);
                    cmd.Parameters.AddWithValue("@id", coordinador.id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un usuario
        public void EliminarCoordinador(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Consulta
                string query = "DELETE FROM usuarios WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
    
}
