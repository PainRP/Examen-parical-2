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
    public partial class AgregarBloquesInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;

        public AgregarBloquesInventario(InventarioService inventarioService, JugadorService jugadorService, BloqueService bloqueService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _jugadorService = jugadorService;
            _bloqueService = bloqueService;

            if (_inventarioService == null || _bloqueService == null || _jugadorService == null)
            {
                MessageBox.Show("Error interno: Algún servicio no fue proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxJugador.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un jugador.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxBloque.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un bloque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int jugadorId = (int)comboBoxJugador.SelectedValue;
            int bloqueId = (int)comboBoxBloque.SelectedValue;
            if (!int.TryParse(textBoxCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida (número entero positivo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCantidad.Focus();
                return;
            }


            Inventario nuevoItemInventario = new Inventario
            {
                JugadorId = jugadorId,
                BloqueId = bloqueId,
                Cantidad = cantidad

            };
            _inventarioService.Agregar(nuevoItemInventario);

            comboBoxJugador.SelectedIndex = -1;
            comboBoxBloque.SelectedIndex = -1;
            textBoxCantidad.Clear();
            comboBoxJugador.Focus();
        }

        private void AgregarBloquesInventario_Load(object sender, EventArgs e)
        {
            if (_jugadorService != null && _bloqueService != null)
            {
                try
                {
                    List<Jugador> jugadores = _jugadorService.ObtenerTodos(); // Asume que tienes este método
                    comboBoxJugador.DataSource = jugadores;
                    comboBoxJugador.DisplayMember = "Nombre";
                    comboBoxJugador.ValueMember = "Id";
                    comboBoxJugador.SelectedIndex = -1;


                    List<Bloque> bloques = _bloqueService.ObtenerTodos();
                    comboBoxBloque.DataSource = bloques;
                    comboBoxBloque.DisplayMember = "Nombre";
                    comboBoxBloque.ValueMember = "Id";
                    comboBoxBloque.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos en ComboBoxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxBloque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
