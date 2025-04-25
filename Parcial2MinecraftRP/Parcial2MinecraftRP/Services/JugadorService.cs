using Microsoft.Data.SqlClient;
using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2MinecraftRP.Services
{
    public class JugadorService
    {
        private readonly DatabaseManager _dbManager;

        public JugadorService(DatabaseManager dbManager) => _dbManager = dbManager;

        public void Crear(Jugador jugador)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("INSERT INTO Jugadores (Nombre, Nivel) VALUES (@Nombre, @Nivel); SELECT SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                command.Parameters.AddWithValue("@Nivel", jugador.Nivel);

                // Obtener el ID generado
                jugador.Id = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show($"¡Jugador registrado con ID: {jugador.Id}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear jugador: {ex.Message}");
                throw;
            }
        }

        public List<Jugador> ObtenerTodos()
        {
            var jugadores = new List<Jugador>();
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("SELECT Id, Nombre, Nivel, FechaCreacion FROM Jugadores", connection);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    jugadores.Add(new Jugador
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Nivel = reader.GetInt32(2),
                        FechaCreacion = reader.GetDateTime(3)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener jugadores: {ex.Message}");
            }
            return jugadores;
        }

        public Jugador ObtenerPorId(int id)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("SELECT Id, Nombre, Nivel, FechaCreacion FROM Jugadores WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Jugador
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Nivel = reader.GetInt32(2),
                        FechaCreacion = reader.GetDateTime(3)
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener jugador: {ex.Message}");
            }
            return null;
        }

        public void Actualizar(Jugador jugador)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("UPDATE Jugadores SET Nombre = @Nombre, Nivel = @Nivel WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", jugador.Id);
                command.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                command.Parameters.AddWithValue("@Nivel", jugador.Nivel);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"¡Jugador actualizado con éxito!");
                else
                    MessageBox.Show("No se encontró el jugador para actualizar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar jugador: {ex.Message}");
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                // Primero verificamos si el jugador tiene inventario
                using var connection = _dbManager.GetConnection();
                connection.Open();

                // Verificar si el jugador tiene elementos en su inventario
                var checkCommand = new SqlCommand("SELECT COUNT(*) FROM Inventario WHERE JugadorId = @Id", connection);
                checkCommand.Parameters.AddWithValue("@Id", id);
                int inventoryCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (inventoryCount > 0)
                {
                    MessageBox.Show("No se puede eliminar el jugador porque tiene elementos en su inventario.");
                    MessageBox.Show($"Elimina primero los {inventoryCount} elementos del inventario asociados a este jugador.");
                    return;
                }

                // Si no tiene inventario, procedemos a eliminar
                var deleteCommand = new SqlCommand("DELETE FROM Jugadores WHERE Id = @Id", connection);
                deleteCommand.Parameters.AddWithValue("@Id", id);

                int rowsAffected = deleteCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"¡Jugador eliminado con éxito!");
                else
                    MessageBox.Show("No se encontró el jugador para eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar jugador: {ex.Message}");
            }
        }
    }
}
