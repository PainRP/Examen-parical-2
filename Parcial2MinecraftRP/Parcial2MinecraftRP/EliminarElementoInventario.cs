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
    public partial class EliminarElementoInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        public EliminarElementoInventario(InventarioService inventarioService, JugadorService jugadorService, BloqueService bloqueService)
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

        private void EliminarElementoInventario_Load(object sender, EventArgs e)
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

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (comboBoxID.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el registro de inventario a eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxID.Focus();
                return;
            }
            if (comboBoxID.SelectedValue == null)
            {
                MessageBox.Show("Error al obtener el ID del registro de inventario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int inventarioIdParaEliminar;
            try
            {
                inventarioIdParaEliminar = (int)comboBoxID.SelectedValue;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error interno: El valor del ID seleccionado en el ComboBox no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult confirmResult = MessageBox.Show(
                "¿Está seguro de que desea eliminar este registro de inventario?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            _inventarioService.Eliminar(inventarioIdParaEliminar);


            comboBoxID.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


