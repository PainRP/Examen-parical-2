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
using OfficeOpenXml; 
using System.IO;

namespace Parcial2MinecraftRP
{
    public partial class GeJugador : Form
    {
        private JugadorService _jugadorService;

        public GeJugador(JugadorService jugadorService)
        {
            InitializeComponent();
            _jugadorService = jugadorService;

            if (_jugadorService == null)
            {
                MessageBox.Show("Error interno: El servicio de jugadores no fue proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
                return;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarNuevoJugador formJugadores = new RegistrarNuevoJugador(_jugadorService);
            formJugadores.ShowDialog();
            this.Show();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadeJugadores formJugadores = new ListadeJugadores(_jugadorService);
            formJugadores.ShowDialog();
            this.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarJugadorID formJugadores = new BuscarJugadorID(_jugadorService);
            formJugadores.ShowDialog();
            this.Show();
        }
        private void buttonActualizar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarJugador formJugadores = new ActualizarJugador(_jugadorService);
            formJugadores.ShowDialog();
            this.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarJugador formJugadores = new EliminarJugador(_jugadorService);
            formJugadores.ShowDialog();
            this.Show();
        }
    }
}
