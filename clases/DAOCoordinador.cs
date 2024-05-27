using MySqlConnector;
using PROYECTOFINALPROGRA1.diseños_daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINALPROGRA1.clases
{
    public class DaoCoordinador
    {
        private string connectionString = "server=localhost;" +
            "user=root;" +
            "password=;" +
            "database=lms;";
        //metodo para obtener todos los coordinadores
        public List<Coordinador> ObtenerTodosLosCoordinadores()
        {
            List<Coordinador> listaCoordinadores = new List<Coordinador>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string  query = "SELECT id, nombre, apellido, email, telefono,facultad, fecha_de_nacimiento FROM cordinador";  

                using (MySqlCommand cmd =  new MySqlCommand(query, conn)) 
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Coordinador coordinador = new Coordinador();

                            
                            coordinador.id = Convert.ToInt32(reader["id"]);
                            coordinador.nombre = reader["nombre"].ToString();
                            coordinador.apellido = reader["apellido"].ToString();
                            coordinador.email = reader["email"].ToString();
                            coordinador.telefono = reader["telefono"].ToString();
                            coordinador.direccion = reader["direccion"].ToString();
                            coordinador.profesion = reader["profesion"].ToString();
                            coordinador.facultad = reader["facultad"].ToString();
                            coordinador.fechadenacimiento = Convert.ToDateTime(reader["fechadenacimiento"]);

                            listaCoordinadores.Add(coordinador);
                        }
                    }
                }
               
               
            }
            return listaCoordinadores;
        }
        public List<Coordinador> ObtenerTodoslosCoordinadoresporNombre(string nombre)
        {
            List<Coordinador> listaCoordinadores = new List<Coordinador>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string query = "SELECT id, nombre, apellido, email, telefono,facultad, fecha_de_nacimiento FROM cordinador WHERE nombre =@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Coordinador coordinador = new   Coordinador();

                            listaCoordinadores.Add(coordinador);
                        }
                    }
                }


            }
            return listaCoordinadores;
        }


        public Coordinador ObtenerCoordinadorPorId( int id)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, nombre, apellido, email, telefono,facultad, fecha_de_nacimiento FROM cordinador WHERE id =@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Coordinador coordinador = new Coordinador();
                            coordinador.id = Convert.ToInt32(reader["id"]);
                            coordinador.nombre = reader["nombre"].ToString();
                            coordinador.apellido = reader["apellido"].ToString();
                            coordinador.email = reader["email"].ToString();
                            coordinador.telefono = reader["telefono"].ToString();
                            coordinador.direccion = reader["direccion"].ToString();
                            coordinador.profesion = reader["profesion"].ToString();
                            coordinador.facultad = reader["facultad"].ToString();
                            coordinador.fechadenacimiento = Convert.ToDateTime(reader["fechadenacimiento"]);

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
        public void InsertarCoordinador( Coordinador coordinador )
        {
            using(MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                string querry = "INSERT INTO cordinador (nombre, apellido, email, telefono,direccion,profesion, facultad, fecha_de_nacimiento) VALUES " + "(nombre, @apellido, @email, @telefono, @direccion, @profesion, facultad, @fecha_de_nacimiento )";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", coordinador.nombre);
                    cmd.Parameters.AddWithValue("@apellido", coordinador.apellido);
                    cmd.Parameters.AddWithValue("@email ", coordinador.email);
                    cmd.Parameters.AddWithValue("@telefeno ", coordinador.telefono);
                    cmd.Parameters.AddWithValue("@direccion ", coordinador.direccion);
                    cmd.Parameters.AddWithValue("@profesion ", coordinador.profesion);
                    cmd.Parameters.AddWithValue("@facultad ", coordinador.facultad);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", coordinador.fechadenacimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarCoordinador(Coordinador coordinador)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open() ;
                string querry = "UPDATE cordinador (nombre, apellido, email, telefono , direccion, profesion, facultad, fecha_de_nacimiento) VALUES " + "(nombre, @apellido, @email, @telefono, @direccion, @profesion, facultad, @fecha_de_nacimiento )";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", coordinador.nombre);
                    cmd.Parameters.AddWithValue("@apellido", coordinador.apellido);
                    cmd.Parameters.AddWithValue("@email ", coordinador.email);
                    cmd.Parameters.AddWithValue("@telefeno ", coordinador.telefono);
                    cmd.Parameters.AddWithValue("@direccion ", coordinador.direccion);
                    cmd.Parameters.AddWithValue("@profesion ", coordinador.profesion);
                    cmd.Parameters.AddWithValue("@facultad ", coordinador.facultad);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", coordinador.fechadenacimiento);
                    cmd.Parameters.AddWithValue("id", coordinador.id);
                    cmd.ExecuteNonQuery();

                }

            }
        }
        public void EliminarCoordinador(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM csordinador WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
