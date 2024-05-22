using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINALPROGRA1.clases
{
    internal class DaoCatedratico
    {
        private string connectionString = "server=localhost;" +
            "user=progra2024;" +
            "password=progra2024;" +
            "database=progra1_2024;";
        //metodo para obtener todos los coordinadores
        public List<Catedratico> ObtenerTodosLosCatedraticos()
        {
            List<Catedratico> listaCatedraticos = new List<Catedratico>();

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
                            Catedratico catedratico = new Catedratico();

                            listaCatedraticos.Add(catedratico);
                        }
                    }
                }


            }
            return listaCatedraticos;
        }

        public Catedratico ObtenerCatedraticoPorId(int id)
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
                            Catedratico catedratico = new Catedratico();
                            return catedratico;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void InsertarCatedratico(Catedratico catedratico)
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
        public void ActualizarCatedratico(Catedratico catedratico)
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
        public void EliminarCatedratico(int id)
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
