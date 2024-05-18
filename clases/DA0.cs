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
        public class Dao
        {
            private string connectionString = "server=127.0.0.1;" +
           "user=root;" +
           "password=;" +
           "database=lms;"; // Cambia el nombre de la base de datos aquí

            // Método para crear la tabla usuario en la base de datos
            
           
            public List < Usuario> ObtenerTodosLosUsuarios() 
            {
                List <Usuario> listaUsuarios = new List<Usuario>();

                using(MySqlConnection conn = new MySqlConnection(connectionString))

                {
                    //apertura conexion
                    conn.Open();
                    //diseño de la consulta
                    string querry = "SELECT id,nombre, email, contrasena FROM usuarios ";
                  
                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))

                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())

                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.id = Convert.ToInt32(reader["id"]);
                                usuario.nombre = reader["nombre"].ToString();
                                usuario.contrasena = reader["contrasena"].ToString();
                                usuario.email = reader["email"].ToString();    
                               

                                listaUsuarios.Add(usuario);
                            }
                        }
                     }
                }
                return listaUsuarios;
            }
            public Usuario ObtenerUsuariosporid(int id)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))

                {
                    //abro conexion
                    conn.Open();
                    //consulta
                    string query = "SELECT id, nombre, contrasena, email FROM usuarios WHERE id = @id";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))

                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())

                        {
                            if (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.id = Convert.ToInt32(reader["id"]);
                                usuario.nombre = reader["nombre"].ToString();
                                usuario.contrasena = reader["contrasena"].ToString();
                                usuario.email = reader["email"].ToString();
                               

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
            //metodo para insertar un nuevo usuario
            public void insertarUsuarios(Usuario Usuario)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))

                {
                    //abro la conexion
                    conn.Open();
                    //genero la consulta
                    string querry = "INSERT INTO usuarios (id, nombre, contrasena, email) VALUES " +
                    "(@nombre, @contrasena, @email, @telefono, @direccion,@profesion)";

                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", Usuario.nombre);
                        cmd.Parameters.AddWithValue("@contrasena", Usuario.contrasena);
                        cmd.Parameters.AddWithValue("@email", Usuario.email);
                        
                    
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            public void ActualizarUsuario(Usuario usuario)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string querry = "UPDATE usuarios SET nombre =  @nombre,contrasena =@contrasena, email =@email WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                        cmd.Parameters.AddWithValue("@apellido", usuario.contrasena);
                        cmd.Parameters.AddWithValue("@email", usuario.email);
                        cmd.Parameters.AddWithValue("@id", usuario.id);
                        

                        cmd.ExecuteNonQuery();
                    }
                }

            }
            public void EliminarUsuarios(int id)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    //consulta
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
