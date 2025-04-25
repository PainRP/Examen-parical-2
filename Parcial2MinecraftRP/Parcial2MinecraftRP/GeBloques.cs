using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Services;

namespace Parcial2MinecraftRP
{
    public partial class GeBloques : Form
    {
        private BloqueService _bloqueService;
        public GeBloques(BloqueService bloqueService)
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

        private void GeBloques_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarBloque formRegistrarBloque = new RegistrarBloque(_bloqueService);
            formRegistrarBloque.ShowDialog();
            this.Show();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarBloques formListarBloques = new ListarBloques(_bloqueService);
            formListarBloques.ShowDialog();
            this.Show();
        }

        private void buttonBuscarID_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarBloqueID formBuscarBloque = new BuscarBloqueID(_bloqueService);
            formBuscarBloque.ShowDialog();
            this.Show();
        }

        private void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarBloqueTipo formBuscarBloqueTipo = new BuscarBloqueTipo(_bloqueService);
            formBuscarBloqueTipo.ShowDialog();
            this.Show();
        }

        private void buttonBuscarRareza_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarBloqueRareza formBuscarBloqueRareza = new BuscarBloqueRareza(_bloqueService);
            formBuscarBloqueRareza.ShowDialog();
            this.Show();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarBloque formActualizarBloque = new ActualizarBloque(_bloqueService);
            formActualizarBloque.ShowDialog();
            this.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarBloque formEliminarBloque = new EliminarBloque(_bloqueService);
            formEliminarBloque.ShowDialog();
            this.Show();
        }
    }
}
