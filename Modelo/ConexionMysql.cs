using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ConexionMysql
    {
        public MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMysql()
        {
            cadenaConexion = "server=localhost;database=rodandoStore;user=root;password=;";
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return connection;

        }
    }
}
