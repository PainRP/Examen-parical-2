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
    public partial class ActualizarBloque : Form
    {
        private BloqueService _bloqueService;
        public ActualizarBloque(BloqueService bloqueService)
        {
            InitializeComponent();
            _bloqueService = bloqueService;
            if (_bloqueService == null)
            {
                MessageBox.Show("Error interno: El servicio de bloques no fue proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Bloque bloqueAActualizar = new Bloque();

            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del bloque a actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
                return;
            }

            if (int.TryParse(textBoxID.Text, out int id))
            {
                bloqueAActualizar.Id = id;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido (número entero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del bloque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombre.Focus();
                return;
            }
            bloqueAActualizar.Nombre = textBoxNombre.Text.Trim();

            if (comboBoxTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo del bloque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxTipo.Focus();
                return;
            }

            bloqueAActualizar.Tipo = comboBoxTipo.SelectedItem.ToString();

            if (comboBoxRareza.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione la rareza del bloque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxRareza.Focus();
                return;
            }

            bloqueAActualizar.Rareza = comboBoxRareza.SelectedItem.ToString();

            _bloqueService.Actualizar(bloqueAActualizar);

            textBoxID.Clear();
            textBoxNombre.Clear();
            comboBoxTipo.SelectedIndex = -1;
            comboBoxRareza.SelectedIndex = -1;
            textBoxID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
