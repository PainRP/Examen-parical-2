using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2MinecraftRP
{
    public partial class EliminarJugador : Form
    {
        private JugadorService _jugadorService;
        public EliminarJugador(JugadorService jugadorService)
        {
            InitializeComponent();
            _jugadorService = jugadorService;

            if (_jugadorService == null)
            {
                MessageBox.Show("Error interno: El servicio de jugadores no fue proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int idAEliminar))
            {
                try
                {
                    Jugador jugadorParaEliminar = _jugadorService.ObtenerPorId(idAEliminar);
                    if (jugadorParaEliminar != null)
                    {
                        DialogResult result = MessageBox.Show(
                            $"¿Está seguro de que desea eliminar al jugador '{jugadorParaEliminar.Nombre}' (ID: {jugadorParaEliminar.Id})?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        );
                        if (result == DialogResult.Yes)
                        {
                            _jugadorService.Eliminar(idAEliminar);
                            textBoxID.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró un jugador con ID {idAEliminar}.", "Jugador no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado durante la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de jugador válido (número entero).", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
            }
        }

        private void EliminarJugador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
