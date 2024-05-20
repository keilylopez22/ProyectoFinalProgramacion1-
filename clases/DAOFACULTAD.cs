using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINALPROGRA1.clases
{
    internal class DaoFacultad
    {
        private string connectionString = "server=localhost;" +
            "user=progra2024;" +
            "password=progra2024;" +
            "database=progra1_2024;";
        //metodo para obtener todos los coordinadores
        public List<Facultad> ObtenerTodosLosCoordinadores()
        {
            List<Facultad> listaDeFacultades = new List<Facultad>();

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
                            Facultad facultad = new Facultad();

                            listaDeFacultades.Add(facultad);
                        }
                    }
                }


            }
            return listaDeFacultades;
        }

        public Facultad ObtenerFacultadPorId(int id)
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
                            Facultad facultad = new Facultad();
                            return facultad;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void Insertarfacultad(Facultad facultad)
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
        public void ActualizarFacultad(Facultad facultad)
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
        public void EliminarFacultad(int id)
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
