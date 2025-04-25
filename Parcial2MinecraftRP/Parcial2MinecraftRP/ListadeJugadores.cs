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
    public partial class ListadeJugadores : Form
    {
        private JugadorService _jugadorService;
        private List<Jugador> _listaJugadoresCargada;
        public ListadeJugadores(JugadorService jugadorService)
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

        private void ListadeJugadores_Load(object sender, EventArgs e)
        {
            try
            {
                _listaJugadoresCargada = _jugadorService.ObtenerTodos();

                dgvListaJugadores.DataSource = _listaJugadoresCargada;

                if (_listaJugadoresCargada.Count == 0)
                {
                    MessageBox.Show("No hay jugadores registrados.");
                    dgvListaJugadores.Visible = false;
                }
                else
                {
                    dgvListaJugadores.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar la lista de jugadores: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _listaJugadoresCargada = new List<Jugador>();
                dgvListaJugadores.DataSource = null;
                dgvListaJugadores.Visible = false;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

