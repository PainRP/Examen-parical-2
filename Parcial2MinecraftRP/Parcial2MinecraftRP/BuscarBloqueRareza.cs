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
    public partial class BuscarBloqueRareza : Form
    {
        private BloqueService _bloqueService;
        public BuscarBloqueRareza(BloqueService bloqueService)
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

        private void BuscarBloqueRareza_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxRareza.Text;

            if (!string.IsNullOrWhiteSpace(tipo))
            {
                List<Bloque> bloques = _bloqueService.BuscarPorRareza(tipo);

                if (bloques == null || bloques.Count == 0)
                {
                    MessageBox.Show("No hay bloque registrado con la Rareza proporcionada.");
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
                MessageBox.Show("Por favor, ingrese un de Rareza válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
