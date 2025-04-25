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
    public partial class EliminarBloque : Form
    {
        private BloqueService _bloqueService;
        public EliminarBloque(BloqueService bloqueService)
        {
            InitializeComponent();
            _bloqueService = bloqueService;

            if (_bloqueService == null)
            {
                MessageBox.Show("Error interno: El servicio de Bloques no fue proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }
        }

        private void EliminarBloque_Load(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int idAEliminar))
            {
                try
                {
                    Bloque bloqueParaEliminar = _bloqueService.ObtenerPorId(idAEliminar);
                    if (bloqueParaEliminar != null)
                    {
                        DialogResult result = MessageBox.Show(
                            $"¿Está seguro de que desea eliminar al jugador '{bloqueParaEliminar.Nombre}' (ID: {bloqueParaEliminar.Id})?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        );
                        if (result == DialogResult.Yes)
                        {
                            _bloqueService.Eliminar(idAEliminar);
                            textBoxID.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró un bloque con ID {idAEliminar}.", "Bloque no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, ingrese un ID de un Bloque válido (número entero).", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
