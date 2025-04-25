using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Services;


namespace Parcial2MinecraftRP
{
    public partial class GeInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;

        public GeInventario(InventarioService inventarioService, JugadorService jugadorService, BloqueService bloqueService)
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

        private void buttonListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listarInventario = new ListarInventario(_inventarioService, _jugadorService, _bloqueService);
            listarInventario.ShowDialog();
            this.Show();
        }

        private void GeInventario_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var verInventario = new InventarioJugador(_inventarioService, _jugadorService, _bloqueService);
            verInventario.ShowDialog();
            this.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var agregarInventario = new AgregarBloquesInventario(_inventarioService, _jugadorService, _bloqueService);
            agregarInventario.ShowDialog();
            this.Show();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var actualizarInventario = new ActualizarCantidadInventario(_inventarioService, _jugadorService, _bloqueService);
            actualizarInventario.ShowDialog();
            this.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var eliminarInventario = new EliminarElementoInventario(_inventarioService, _jugadorService, _bloqueService);
            eliminarInventario.ShowDialog();
            this.Show();
        }
    }
}
