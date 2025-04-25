using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Utils;


namespace Parcial2MinecraftRP.Services
{
    public class BloqueService
    {
        private readonly DatabaseManager _dbManager;

        public BloqueService(DatabaseManager dbManager) => _dbManager = dbManager;

        public void Crear(Bloque bloque)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("INSERT INTO Bloques (Nombre, Tipo, Rareza) VALUES (@Nombre, @Tipo, @Rareza); SELECT SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@Nombre", bloque.Nombre);
                command.Parameters.AddWithValue("@Tipo", bloque.Tipo);
                command.Parameters.AddWithValue("@Rareza", bloque.Rareza);

                // Obtener el ID generado
                bloque.Id = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show($"¡Bloque registrado con ID: {bloque.Id}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear bloque: {ex.Message}");
            }
        }

        public List<Bloque> ObtenerTodos()
        {
            var bloques = new List<Bloque>();
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("SELECT Id, Nombre, Tipo, Rareza FROM Bloques", connection);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bloques.Add(new Bloque
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Tipo = reader.GetString(2),
                        Rareza = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener bloques: {ex.Message}");
            }
            return bloques;
        }

        public List<Bloque> BuscarPorTipo(string tipo)
        {
            var bloques = new List<Bloque>();
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("SELECT Id, Nombre, Tipo, Rareza FROM Bloques WHERE Tipo LIKE @Tipo", connection);
                command.Parameters.AddWithValue("@Tipo", "%" + tipo + "%");

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bloques.Add(new Bloque
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Tipo = reader.GetString(2),
                        Rareza = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloques por tipo: {ex.Message}");
            }
            return bloques;
        }

        public List<Bloque> BuscarPorRareza(string rareza)
        {
            var bloques = new List<Bloque>();
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("SELECT Id, Nombre, Tipo, Rareza FROM Bloques WHERE Rareza LIKE @Rareza", connection);
                command.Parameters.AddWithValue("@Rareza", "%" + rareza + "%");

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bloques.Add(new Bloque
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Tipo = reader.GetString(2),
                        Rareza = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloques por rareza: {ex.Message}");
            }
            return bloques;
        }

        public Bloque ObtenerPorId(int id)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("SELECT Id, Nombre, Tipo, Rareza FROM Bloques WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Bloque
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Tipo = reader.GetString(2),
                        Rareza = reader.GetString(3)
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener bloque: {ex.Message}");
            }
            return null;
        }

        public void Actualizar(Bloque bloque)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("UPDATE Bloques SET Nombre = @Nombre, Tipo = @Tipo, Rareza = @Rareza WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", bloque.Id);
                command.Parameters.AddWithValue("@Nombre", bloque.Nombre);
                command.Parameters.AddWithValue("@Tipo", bloque.Tipo);
                command.Parameters.AddWithValue("@Rareza", bloque.Rareza);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"¡Bloque actualizado con éxito!");
                else
                    MessageBox.Show("No se encontró el bloque para actualizar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar bloque: {ex.Message}");
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();

                // Verificar si el bloque está en el inventario de algún jugador
                var checkCommand = new SqlCommand("SELECT COUNT(*) FROM Inventario WHERE BloqueId = @Id", connection);
                checkCommand.Parameters.AddWithValue("@Id", id);
                int inventoryCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (inventoryCount > 0)
                {
                    MessageBox.Show("No se puede eliminar el bloque porque está presente en el inventario de jugadores.");
                    MessageBox.Show($"Hay {inventoryCount} registros de inventario usando este bloque.");
                    return;
                }

                // Si no hay referencias, proceder con la eliminación
                var deleteCommand = new SqlCommand("DELETE FROM Bloques WHERE Id = @Id", connection);
                deleteCommand.Parameters.AddWithValue("@Id", id);

                int rowsAffected = deleteCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"¡Bloque eliminado con éxito!");
                else
                    MessageBox.Show("No se encontró el bloque para eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar bloque: {ex.Message}");
            }
        }
    }
}
