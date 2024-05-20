using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PROYECTOFINALPROGRA1.clases
{
    internal class conexionBD
    {
        SqlConnection conexion = new SqlConnection();
        static string servidor = "localhost";
        static string bd = "lms";
        static string usuario = "root";
        static string password ="";
        static string port= "3306";

        string cadenaConexion = "Data Source=" + servidor + "," + port + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";
        public SqlConnection establecerConexion(){
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("se conecto sastifactoriamente a  la base de datos");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro conectar a la base de datos" + e.ToString()); 
            }
            return conexion;
        }
    }
}
