using System;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ConexionMysql : IDisposable
    {
        private readonly string cadenaConexion = "server=localhost;database=rodandoStore;user=root;password=;";
        public MySqlConnection connection;

        public ConexionMysql()
        {
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
                Console.WriteLine("Error al abrir la conexión: " + e.Message);
                throw; // Lanza la excepción para que pueda manejarse en el formulario
            }

            return connection;
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al cerrar la conexión: " + e.Message);
            }
        }

        public void Dispose()
        {
            CloseConnection();
            connection.Dispose();
        }
    }
}
