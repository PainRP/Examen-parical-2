using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Parcial2MinecraftRP.Utils
{
    public class DatabaseManager
    {
        private readonly string _connectionString; // Variable 

        public DatabaseManager() // Constructor
=> _connectionString = @"Data Source=PAIN\SQLEXPRESS06;Initial Catalog=Parcial2Minecraft;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection() // Método para obtener la conexión
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

        public bool TestConnection() // Método para probar la conexión
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
                return false;
            }
        }
    }
}



