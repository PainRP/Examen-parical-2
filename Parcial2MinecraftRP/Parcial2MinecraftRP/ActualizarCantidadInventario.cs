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

    public partial class ActualizarCantidadInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        public ActualizarCantidadInventario(InventarioService inventarioService, JugadorService jugadorService, BloqueService bloqueService)
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

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Inventario inventarioAActualizar = new Inventario();
            if (comboBoxID.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el registro de inventario a actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxID.Focus();
                return;
            }

            if (comboBoxID.SelectedValue == null)
            {
                MessageBox.Show("Error al obtener el ID del registro de inventario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int inventarioId;
            try
            {
                inventarioId = (int)comboBoxID.SelectedValue;
                inventarioAActualizar.Id = inventarioId;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error interno: El valor del ID seleccionado en el ComboBox no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese la nueva cantidad para el inventario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCantidad.Focus();
                return;
            }

            if (int.TryParse(textBoxCantidad.Text, out int cantidad))
            {
                inventarioAActualizar.Cantidad = cantidad;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida (número entero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCantidad.Focus();
                return;
            }
            _inventarioService.Actualizar(inventarioAActualizar);
            comboBoxID.SelectedIndex = -1;
            textBoxCantidad.Clear();
            comboBoxID.Focus();
        }


        private void ActualizarCantidadInventario_Load(object sender, EventArgs e)
        {
            if (_jugadorService != null && _bloqueService != null)
            {
                try
                {
                    List<Inventario> inventarios = _inventarioService.ObtenerTodos();
                    comboBoxID.DataSource = inventarios;
                    comboBoxID.DisplayMember = "Id";
                    comboBoxID.ValueMember = "Id";
                    comboBoxID.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos en ComboBoxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
