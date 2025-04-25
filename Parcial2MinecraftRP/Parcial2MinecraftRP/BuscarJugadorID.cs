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
    public partial class BuscarJugadorID : Form
    {
        private JugadorService _jugadorService;
        private List<Jugador> _listaJugadoresCargada;
        public BuscarJugadorID(JugadorService jugadorService)
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

        private void BuscarJugadorID_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (_listaJugadoresCargada == null || !_listaJugadoresCargada.Any())
            {
                _listaJugadoresCargada = _jugadorService.ObtenerTodos();

                if (int.TryParse(textBoxID.Text, out int idBuscar))
                {
                    Jugador jugadorEncontrado = _jugadorService.ObtenerPorId(idBuscar);

                    if (jugadorEncontrado == null)
                    {
                        MessageBox.Show("No hay jugadores registrados con el ID proporcionado.");
                        dgvJugador.Visible = false;
                    }
                    else
                    {
                        List<Jugador> listaDeJugadores = new List<Jugador> { jugadorEncontrado };
                        dgvJugador.DataSource = listaDeJugadores;
                        dgvJugador.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (int.TryParse(textBoxID.Text, out int idBuscarFinal))
            {
                Jugador jugadorEncontradoFinal = _listaJugadoresCargada.FirstOrDefault(j => j.Id == idBuscarFinal);

                if (jugadorEncontradoFinal == null)
                {
                    MessageBox.Show("No hay jugadores registrados con el ID proporcionado.");
                    dgvJugador.Visible = false;
                }
                else
                {
                    List<Jugador> listaDeJugadores = new List<Jugador> { jugadorEncontradoFinal };
                    dgvJugador.DataSource = listaDeJugadores;
                    dgvJugador.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
