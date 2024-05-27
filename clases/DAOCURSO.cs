using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROYECTOFINALPROGRA1.clases
{
    internal class DaoCurso
    {
        private string connectionString = "server=localhost;" +
            "user=root;" +
            "password=;" +
            "database=lms;";
        //metodo para obtener todos los cursos de la base de datos
        public List<Curso> ObtenerTodosLosCursos()
        {
            List<Curso> listaCursos = new List<Curso>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string query = "SELECT id, nombre, horario, facultad FROM curso";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Curso curso = new Curso();
                            curso.Id = Convert.ToInt32(reader["id"]);
                            curso.Nombre = reader["nombre"].ToString();
                            curso.Horario = reader["horario"].ToString();
                            curso.Facultad = reader["facultad"].ToString();

                            listaCursos.Add(curso);
                        }
                    }
                }


            }
            return listaCursos;
        }

        public Curso ObtenerCursosPorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, nombre, horario, facultad FROM curso WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Curso curso = new Curso();
                            curso.Id = Convert.ToInt32(reader["id"]);
                            curso.Nombre = reader["nombre"].ToString();
                            curso.Horario = reader["horario"].ToString();
                            curso.Facultad = reader["facultad"].ToString();

                            return curso;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void InsertarCursos(Curso curso)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();

                string query = "INSERT INTO curso (nombre, horario, facultad) VALUES " + "(@nombre, @horario, @facultad)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@horario", curso.Horario);
                    cmd.Parameters.AddWithValue("@facultad", curso.Facultad);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarCursos(Curso curso)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE curso SET nombre = @nombre, horario = @horario, facultad= @facultad  WHERE id =  @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@horario", curso.Horario);
                    cmd.Parameters.AddWithValue("@facultad", curso.Facultad);
                    cmd.Parameters.AddWithValue("id", curso.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarCurso(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM curso WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
