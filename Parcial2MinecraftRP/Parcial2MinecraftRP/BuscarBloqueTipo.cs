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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial2MinecraftRP
{
    public partial class BuscarBloqueTipo : Form
    {
        private BloqueService _bloqueService;
        public BuscarBloqueTipo(BloqueService bloqueService)
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxTipo.Text;

            if (!string.IsNullOrWhiteSpace(tipo))
            {
                List<Bloque> bloques = _bloqueService.BuscarPorTipo(tipo);

                if (bloques == null || bloques.Count == 0)
                {
                    MessageBox.Show("No hay bloque registrado con el Tipo proporcionado.");
                    dgvBloques.Visible = false;
                }
                else
                {
                    dgvBloques.DataSource = bloques;
                    dgvBloques.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvBloques.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Tipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
