using Parcial2MinecraftRP.Services;
using Parcial2MinecraftRP.Models;
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
    public partial class RegistrarBloque : Form
    {
        private BloqueService _bloqueService;
        public RegistrarBloque(BloqueService bloqueService)
        {
            InitializeComponent();
            _bloqueService = bloqueService;

            if (_bloqueService == null)
            {
                MessageBox.Show("Error interno: El servicio de jugadores no fue proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }
        }

        private void RegistrarBloque_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Bloque nuevoBloque = new Bloque();
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del bloque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombre.Focus();
                return;
            }
            nuevoBloque.Nombre = textBoxNombre.Text.Trim();
            nuevoBloque.Tipo = comboBoxTipo.Text;
            nuevoBloque.Rareza = comboBoxRareza.Text;

            _bloqueService.Crear(nuevoBloque);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
