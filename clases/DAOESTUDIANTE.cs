using MySqlConnector;
using PROYECTOFINALPROGRA1.diseños_daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINALPROGRA1.clases
{
    internal class DaoEstudiante
    {
        private string connectionString = "server=localhost;" +
            "user=root;" +
            "password=;" +
            "database=lms;";
        //metodo para obtener todos los coordinadores
        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string query = "SELECT id, nombre, apellido, email, telefono, direccion, profesion, facultad, anio_de_nacimiento FROM estudiante";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudiante estudiante = new Estudiante();
                          
                            estudiante.id = Convert.ToInt32(reader["id"]);
                            estudiante.nombre = reader["nombre"].ToString();
                            estudiante.apellido = reader["apellido"].ToString();
                            estudiante.email = reader["email"].ToString();
                            estudiante.telefono = reader["telefono"].ToString();
                            estudiante.direccion = reader["direccion"].ToString();
                            estudiante.profesion = reader["profesion"].ToString();
                            estudiante.facultad = reader["facultad"].ToString();
                            estudiante.fechadenacimiento = Convert.ToDateTime(reader["anio_de_nacimiento"]);

                            listaEstudiantes.Add(estudiante);
                        }
                    }
                }


            }
            return listaEstudiantes;
        }
        public List<Estudiante> ObtenerTodosLosEstudiantesporNombre(string nombre)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string query = "SELECT id, nombre, apellido, email, telefono,facultad,profesion, anio_de_nacimiento FROM estudiante WHERE nombre =@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudiante estudiante = new Estudiante();

                            listaEstudiantes.Add(estudiante);
                        }
                    }
                }


            }
            return listaEstudiantes;
        }

        public Estudiante ObtenerEstudiantePorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, nombre, apellido, email, telefono,facultad, profesion, anio_de_nacimiento FROM estudiante WHERE id =@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Estudiante estudiante = new Estudiante();
                            estudiante.id = Convert.ToInt32(reader["id"]);
                            estudiante.nombre = reader["nombre"].ToString();
                            estudiante.apellido = reader["apellido"].ToString();
                            estudiante.email = reader["email"].ToString();
                            estudiante.telefono= reader["telefono"].ToString();
                            estudiante.direccion = reader["direccion"].ToString();
                            estudiante.profesion = reader["profesion"].ToString();
                            estudiante.facultad = reader["facultad"].ToString();
                            estudiante.fechadenacimiento = Convert.ToDateTime(reader["anio_de_nacimiento"]);

                            return estudiante;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void InsertarEstudiante(Estudiante estudiante)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                string query = "INSERT INTO estudiante (nombre, apellido, email, telefono,direccion,profesion, facultad, anio_de_nacimiento) VALUES " + "(nombre, @apellido, @email, @telefono, @direccion, @profesion, facultad, @anio_de_nacimiento )";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", estudiante.nombre);
                    cmd.Parameters.AddWithValue("@apellido", estudiante.apellido);
                    cmd.Parameters.AddWithValue("@email ", estudiante.email);
                    cmd.Parameters.AddWithValue("@telefeno ", estudiante.telefono);
                    cmd.Parameters.AddWithValue("@direccion ", estudiante.direccion);
                    cmd.Parameters.AddWithValue("@profesion ", estudiante.profesion);
                    cmd.Parameters.AddWithValue("@facultad ", estudiante.facultad);
                    cmd.Parameters.AddWithValue("@anio_de_nacimiento", estudiante.fechadenacimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarEstudiante(Estudiante estudiante)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string querry = "UPDATE estudiante (nombre, apellido, email, telefono,direccion,profesion, facultad, anio_de_nacimiento) VALUES " + "(nombre, @apellido, @email, @telefono, @direccion, @profesion, facultad, @anio_de_nacimiento )";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", estudiante.nombre);
                    cmd.Parameters.AddWithValue("@apellido", estudiante.apellido);
                    cmd.Parameters.AddWithValue("@email ", estudiante.email);
                    cmd.Parameters.AddWithValue("@telefeno ", estudiante.telefono);
                    cmd.Parameters.AddWithValue("@direccion ", estudiante.direccion);
                    cmd.Parameters.AddWithValue("@profesion ", estudiante.profesion);
                    cmd.Parameters.AddWithValue("@facultad ", estudiante.facultad);
                    cmd.Parameters.AddWithValue("@anio_de_nacimiento", estudiante.fechadenacimiento);
                    cmd.Parameters.AddWithValue("id",estudiante.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarEstudiante(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM estudiante WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
