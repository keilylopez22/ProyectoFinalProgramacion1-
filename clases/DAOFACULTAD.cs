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
            "user=rot;" +
            "password=;" +
            "database=lms;";
        //metodo para obtener todos los coordinadores
        public List<Facultad> ObtenerTodasLasFacultades()
        {
            List<Facultad> listaDeFacultades = new List<Facultad>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string querry = "SELECT id, nombre, coordinador FROM facultad";

                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Facultad facultad = new Facultad();
                            facultad.id = Convert.ToInt32(reader["iD"]);
                            facultad.nombre = reader["nombre"].ToString();
                            facultad.coordinador = reader["coordinador"].ToString();


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

                string query = "SELEC id, nombre, coordinador FROM facultad WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Facultad facultad = new Facultad();
                            facultad.id = Convert.ToInt32(reader["iD"]);
                            facultad.nombre = reader["nombre"].ToString();
                            facultad.coordinador = reader["coordinador"].ToString();

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
                string querry = "INSERT INTO facultad (nombre, coordinador) VALUES "+"(@nombre, @coordinador)";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", facultad.nombre);
                    cmd.Parameters.AddWithValue("@coordinador", facultad.coordinador);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarFacultad(Facultad facultad)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string querry = "UPDATE facultad SET nombre = @nombre, coordinador= @coordinador WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(querry, conn))
                {

                    cmd.Parameters.AddWithValue("@nombre", facultad.nombre);
                    cmd.Parameters.AddWithValue("@coordinador", facultad.coordinador);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarFacultad(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM facultad WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
