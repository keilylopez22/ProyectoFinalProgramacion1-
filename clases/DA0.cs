﻿using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;



namespace PROYECTOFINALPROGRA1.clases
{
    public class Dao
    {
        private string connectionString = "server=127.0.0.1;" +
                                          "user=root;" +
                                          "password=;" +
                                          "database=lms;"; // Cambia el nombre de la base de datos aquí

        // Método para obtener todos los usuarios
        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using ( MySqlConnection conn = new MySqlConnection(connectionString))
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
                            Usuario usuario = new Usuario
                            {
                                id = Convert.ToInt32(reader["id"]),
                                nombre = reader["nombre"].ToString(),
                                contrasena = reader["contrasena"].ToString(),
                                email = reader["email"].ToString()
                            };

                            listaUsuarios.Add(usuario);
                        }
                    }
                }
            }
            return listaUsuarios;
        }

        // Método para obtener un usuario por id
        public Usuario ObtenerUsuariosPorId(int id)
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
                            Usuario usuario = new Usuario
                            {
                                id = Convert.ToInt32(reader["id"]),
                                nombre = reader["nombre"].ToString(),
                                contrasena = reader["contrasena"].ToString(),
                                email = reader["email"].ToString()
                            };

                            return usuario;
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
        public void InsertarUsuarios(Usuario usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Apertura de la conexión
                conn.Open();
                // Genero la consulta
                string query = "INSERT INTO usuarios (nombre, contrasena, email) VALUES (@nombre, @contrasena, @email)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                    cmd.Parameters.AddWithValue("@contrasena", usuario.contrasena);
                    cmd.Parameters.AddWithValue("@email", usuario.email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un usuario
        public void ActualizarUsuario(Usuario usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE usuarios SET nombre = @nombre, contrasena = @contrasena, email = @email WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                    cmd.Parameters.AddWithValue("@contrasena", usuario.contrasena);
                    cmd.Parameters.AddWithValue("@email", usuario.email);
                    cmd.Parameters.AddWithValue("@id", usuario.id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un usuario
        public void EliminarUsuarios(int id)
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
