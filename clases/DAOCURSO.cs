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
            "user=progra2024;" +
            "password=progra2024;" +
            "database=progra1_2024;";
        //metodo para obtener todos los coordinadores
        public List<Curso> ObtenerTodosLosCoordinadores()
        {
            List<Curso> listaCursos = new List<Curso>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string querry = "";

                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Curso curso = new Curso();

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

                string query = "";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Curso curso = new Curso();

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
                string querry = "";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarCursos(Curso curso)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string querry = "";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarCurso(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
