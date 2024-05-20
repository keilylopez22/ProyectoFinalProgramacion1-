using MySqlConnector;
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
            "user=progra2024;" +
            "password=progra2024;" +
            "database=progra1_2024;";
        //metodo para obtener todos los coordinadores
        public List<Coordinador> ObtenerTodosLosCoordinadores()
        {
            List<Coordinador> listaCoordinadores = new List<Coordinador>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string querry = "";

                using (MySqlCommand cmd =  new MySqlCommand(querry, conn)) 
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Coordinador coordinador = new Coordinador();
                           
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

                string query = "";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Coordinador coordinador =  new Coordinador();
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
                string querry = "";
                using(MySqlCommand cmd = new MySqlCommand( querry, conn))
                {
                    cmd.ExecuteNonQuery();
                }  
            }
        }
        public void ActualizarCoordinador(Coordinador coordinador)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open() ;
                string querry = "";
                using (MySqlCommand cmd  = new MySqlCommand(querry, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarCoordinador(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "";
                using (MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
