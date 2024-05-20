using MySqlConnector;
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
            "user=progra2024;" +
            "password=progra2024;" +
            "database=progra1_2024;";
        //metodo para obtener todos los coordinadores
        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

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

                string query = "";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Estudiante estudiante = new Estudiante();
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
                string querry = "";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarEstudiante(Estudiante estudiante)
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
        public void EliminarEstudiante(int id)
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
