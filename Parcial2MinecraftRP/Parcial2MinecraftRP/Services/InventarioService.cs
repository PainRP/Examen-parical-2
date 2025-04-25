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
    public class InventarioService
    {
        private readonly DatabaseManager _dbManager;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;

        public InventarioService(DatabaseManager dbManager, JugadorService jugadorService, BloqueService bloqueService)
        {
            _dbManager = dbManager;
            _jugadorService = jugadorService;
            _bloqueService = bloqueService;
        }

        public void Agregar(Inventario inventario)
        {
            try
            {
                // Validar que la cantidad sea positiva
                if (inventario.Cantidad <= 0)
                {
                    MessageBox.Show("Error: La cantidad debe ser un valor positivo.");
                    return;
                }

                // Verificar que el jugador existe
                var jugador = _jugadorService.ObtenerPorId(inventario.JugadorId);
                if (jugador == null)
                {
                    MessageBox.Show($"Error: No existe un jugador con ID {inventario.JugadorId}");
                    return;
                }

                // Verificar que el bloque existe
                var bloque = _bloqueService.ObtenerPorId(inventario.BloqueId);
                if (bloque == null)
                {
                    MessageBox.Show($"Error: No existe un bloque con ID {inventario.BloqueId}");
                    return;
                }

                // Verificar si ya existe este bloque en el inventario del jugador
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var checkCommand = new SqlCommand(
                    "SELECT Id, Cantidad FROM Inventario WHERE JugadorId = @JugadorId AND BloqueId = @BloqueId", connection);
                checkCommand.Parameters.AddWithValue("@JugadorId", inventario.JugadorId);
                checkCommand.Parameters.AddWithValue("@BloqueId", inventario.BloqueId);

                using var reader = checkCommand.ExecuteReader();
                if (reader.Read())
                {
                    // Ya existe, actualizamos la cantidad
                    int existingId = reader.GetInt32(0);
                    int existingCantidad = reader.GetInt32(1);
                    reader.Close();

                    var updateCommand = new SqlCommand(
                        "UPDATE Inventario SET Cantidad = @Cantidad WHERE Id = @Id", connection);
                    updateCommand.Parameters.AddWithValue("@Id", existingId);
                    updateCommand.Parameters.AddWithValue("@Cantidad", existingCantidad + inventario.Cantidad);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show($"¡Se actualizó el inventario! Nuevo total: {existingCantidad + inventario.Cantidad} {bloque.Nombre}");
                }
                else
                {
                    // No existe, creamos un nuevo registro
                    reader.Close();
                    var insertCommand = new SqlCommand(
                        "INSERT INTO Inventario (JugadorId, BloqueId, Cantidad) VALUES (@JugadorId, @BloqueId, @Cantidad); SELECT SCOPE_IDENTITY();",
                        connection);
                    insertCommand.Parameters.AddWithValue("@JugadorId", inventario.JugadorId);
                    insertCommand.Parameters.AddWithValue("@BloqueId", inventario.BloqueId);
                    insertCommand.Parameters.AddWithValue("@Cantidad", inventario.Cantidad);

                    inventario.Id = Convert.ToInt32(insertCommand.ExecuteScalar());
                    MessageBox.Show($"¡Se agregó {inventario.Cantidad} {bloque.Nombre} al inventario de {jugador.Nombre}!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar al inventario: {ex.Message}");
            }
        }

        public List<Inventario> ObtenerTodos()
        {
            var inventarios = new List<Inventario>();
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand(
                    @"SELECT i.Id, i.JugadorId, i.BloqueId, i.Cantidad, j.Nombre AS NombreJugador, b.Nombre AS NombreBloque
                    FROM Inventario i
                    INNER JOIN Jugadores j ON i.JugadorId = j.Id
                    INNER JOIN Bloques b ON i.BloqueId = b.Id", connection);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inventarios.Add(new Inventario
                    {
                        Id = reader.GetInt32(0),
                        JugadorId = reader.GetInt32(1),
                        BloqueId = reader.GetInt32(2),
                        Cantidad = reader.GetInt32(3),
                        NombreJugador = reader.GetString(4),
                        NombreBloque = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener inventarios: {ex.Message}");
            }
            return inventarios;
        }

        public List<Inventario> ObtenerPorJugador(int jugadorId)
        {
            var inventarios = new List<Inventario>();
            try
            {
                // Verificar que el jugador existe
                var jugador = _jugadorService.ObtenerPorId(jugadorId);
                if (jugador == null)
                {
                    MessageBox.Show($"Error: No existe un jugador con ID {jugadorId}");
                    return inventarios;
                }

                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand(
                    @"SELECT i.Id, i.JugadorId, i.BloqueId, i.Cantidad, j.Nombre AS NombreJugador, b.Nombre AS NombreBloque
                    FROM Inventario i
                    INNER JOIN Jugadores j ON i.JugadorId = j.Id
                    INNER JOIN Bloques b ON i.BloqueId = b.Id
                    WHERE i.JugadorId = @JugadorId", connection);
                command.Parameters.AddWithValue("@JugadorId", jugadorId);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inventarios.Add(new Inventario
                    {
                        Id = reader.GetInt32(0),
                        JugadorId = reader.GetInt32(1),
                        BloqueId = reader.GetInt32(2),
                        Cantidad = reader.GetInt32(3),
                        NombreJugador = reader.GetString(4),
                        NombreBloque = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener inventario del jugador: {ex.Message}");
            }
            return inventarios;
        }

        public void Actualizar(Inventario inventario)
        {
            try
            {
                // Validar que la cantidad sea positiva
                if (inventario.Cantidad <= 0)
                {
                    MessageBox.Show("Error: La cantidad debe ser un valor positivo.");
                    return;
                }

                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("UPDATE Inventario SET Cantidad = @Cantidad WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", inventario.Id);
                command.Parameters.AddWithValue("@Cantidad", inventario.Cantidad);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"¡Inventario actualizado con éxito!");
                else
                    MessageBox.Show("No se encontró el registro de inventario para actualizar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar inventario: {ex.Message}");
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using var connection = _dbManager.GetConnection();
                connection.Open();
                var command = new SqlCommand("DELETE FROM Inventario WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"¡Elemento del inventario eliminado con éxito!");
                else
                    MessageBox.Show("No se encontró el elemento del inventario para eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar de inventario: {ex.Message}");
            }
        }
    }
}
