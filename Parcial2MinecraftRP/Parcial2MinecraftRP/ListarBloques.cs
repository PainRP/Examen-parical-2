using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Services;
using Parcial2MinecraftRP.Utils;
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
    public partial class ListarBloques : Form
    {
        private BloqueService _bloqueService;
        private List<Bloque> _listaBloquesCargada;
        public ListarBloques(BloqueService bloqueService)
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

        private void dgvBloques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarBloques_Load(object sender, EventArgs e)
        {
            _listaBloquesCargada = _bloqueService.ObtenerTodos();
            dgvBloques.DataSource = _listaBloquesCargada;

            if (_listaBloquesCargada.Count == 0)
            {

                MessageBox.Show("No hay Bloques registrados.");
                dgvBloques.Visible = false;
            }
            else
            {
                dgvBloques.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
