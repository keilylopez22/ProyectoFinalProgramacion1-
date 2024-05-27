
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace PROYECTOFINALPROGRA1.clases
{
    public  class DaoCatedratico
    {
        private string connectionString = "server=localhost;" +
            "user=root;" +
            "password=;" +
            "database=lms;";
        //metodo para obtener todos los coordinadores
        public List<Catedratico> ObtenerTodosLosCatedraticos()
        {
            List<Catedratico> listaCatedraticos = new List<Catedratico>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string query = "SELECT id, nombre, apellido, email, telefono, direccion, profesion, facultad, fecha_de_nacimiento FROM catedratico";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Catedratico catedraticos = new Catedratico();
                            catedraticos.Id_Catedratico = Convert.ToInt32(reader["id"]);
                            catedraticos.Nombre_Catedratico = reader["nombre"].ToString();
                            catedraticos.Apellido_Catedratico = reader["apellido"].ToString();
                            catedraticos.Email_Catedratico = reader["email"].ToString();
                            catedraticos.Telefono_Catedratico = reader["telefono"].ToString();
                            catedraticos.Direccion_Catedratico = reader["direccion"].ToString();
                            catedraticos.Profesion_Catedratico = reader["profesion"].ToString();
                            catedraticos.Facultad_Catedratico = reader["facultad"].ToString();
                            catedraticos.Fechadenacimiento_Catedratico = Convert.ToDateTime(reader["fecha_de_nacimiento"]);


                            listaCatedraticos.Add(catedraticos);
                        }
                    }
                }


            }
            return listaCatedraticos;
        }
        public List<Catedratico> ObtenerTodosLosCatedraticosporNombre(string nombre)
        {
            List<Catedratico> listaCatedraticos = new List<Catedratico>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //abriendo la conexion
                conn.Open();
                //diseñando la consulta
                string query = "SELECT id, nombre, apellido, email, telefono, direccion, profesion, facultad, fecha_de_nacimiento FROM catedratico WHERE nombre =@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Catedratico catedraticos = new Catedratico();
                            
                            catedraticos.Id_Catedratico = Convert.ToInt32(reader["id"]);
                            catedraticos.Nombre_Catedratico = reader["nombre"].ToString();
                            catedraticos.Apellido_Catedratico = reader["apellido"].ToString();
                            catedraticos.Email_Catedratico = reader["email"].ToString();
                            catedraticos.Telefono_Catedratico = reader["telefono"].ToString();
                            catedraticos.Direccion_Catedratico = reader["direccion"].ToString();
                            catedraticos.Profesion_Catedratico = reader["profesion"].ToString();
                            catedraticos.Facultad_Catedratico = reader["facultad"].ToString();
                            catedraticos.Fechadenacimiento_Catedratico = Convert.ToDateTime(reader["fecha_de_nacimiento"]);




                            listaCatedraticos.Add(catedraticos);
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

                string query = "SELECT id, nombre, apellido, email, telefono, direccion, profesion, facultad, fecha_de_nacimiento FROM catedratico WHERE id =@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Catedratico catedraticos = new Catedratico();
                            catedraticos.Id_Catedratico = Convert.ToInt32(reader["id"]);
                            catedraticos.Nombre_Catedratico = reader["nombre"].ToString();
                            catedraticos.Apellido_Catedratico = reader["apellido"].ToString();
                            catedraticos.Email_Catedratico = reader["email"].ToString();
                            catedraticos.Telefono_Catedratico = reader["telefono"].ToString();
                            catedraticos.Profesion_Catedratico = reader["profesion"].ToString();
                            catedraticos.Facultad_Catedratico = reader["facultad"].ToString();
                            catedraticos.Fechadenacimiento_Catedratico = Convert.ToDateTime(reader["fecha_de_nacimiento"]);

                            return catedraticos;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void InsertarCatedratico(Catedratico catedraticos)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                string query = "INSERT INTO catedratico (nombre, apellido, email, telefono, direccion, profesion, facultad, fecha_de_nacimiento) VALUES " + "(@nombre, @apellido, @email, @telefono, @direccion, @profesion,  @facultad, @fecha_de_nacimiento)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", catedraticos.Nombre_Catedratico);
                    cmd.Parameters.AddWithValue("@apellido", catedraticos.Apellido_Catedratico);
                    cmd.Parameters.AddWithValue("@email ", catedraticos.Email_Catedratico);
                    cmd.Parameters.AddWithValue("@telefeno ", catedraticos.Telefono_Catedratico);
                    cmd.Parameters.AddWithValue("@direccion ", catedraticos.Direccion_Catedratico);
                    cmd.Parameters.AddWithValue("@profesion ", catedraticos.Profesion_Catedratico);
                    cmd.Parameters.AddWithValue("@facultad ", catedraticos.Facultad_Catedratico);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", catedraticos.Fechadenacimiento_Catedratico);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarCatedratico(Catedratico catedraticos)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE catedratico SET nombre =@nombre, apellido =@apellido, email= @email, telefono= @telefono, direccion= @direccion, profesion=@profesion, facultad=@facultad, fecha_de_nacimiento=@fecha_de_nacimiento  WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", catedraticos.Nombre_Catedratico);
                    cmd.Parameters.AddWithValue("@apellido", catedraticos.Apellido_Catedratico);
                    cmd.Parameters.AddWithValue("@email ", catedraticos.Email_Catedratico);
                    cmd.Parameters.AddWithValue("@telefeno ", catedraticos.Telefono_Catedratico);
                    cmd.Parameters.AddWithValue("@direccion ", catedraticos.Direccion_Catedratico);
                    cmd.Parameters.AddWithValue("@profesion ", catedraticos.Profesion_Catedratico);
                    cmd.Parameters.AddWithValue("@facultad ", catedraticos.Facultad_Catedratico);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", catedraticos.Fechadenacimiento_Catedratico);
                    cmd.ExecuteNonQuery();
                    
                }
            }
        }
        public void EliminarCatedratico(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM catedratico WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
