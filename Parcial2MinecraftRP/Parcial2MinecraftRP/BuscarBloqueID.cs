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
    public partial class BuscarBloqueID : Form
    {
        private BloqueService _bloqueService;
        public BuscarBloqueID(BloqueService bloqueService)
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

        private void BuscarBloqueID_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int id))
            {

                Bloque bloque = _bloqueService.ObtenerPorId(id);

                if (bloque == null)
                {
                    MessageBox.Show("No hay bloque registrado con el ID proporcionado.");
                    dgvBloques.Visible = false;
                }
                else
                {

                    List<Bloque> listaDeBloques = new List<Bloque> { bloque };
                    dgvBloques.DataSource = listaDeBloques;
                    dgvBloques.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvBloques.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
