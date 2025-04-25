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
    public partial class ActualizarJugador : Form
    {
        private JugadorService _jugadorService;
        public ActualizarJugador(JugadorService jugadorService)
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

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Jugador nuevoJugador = new Jugador();
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del jugador.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
                return;
            }
            if (int.TryParse(textBoxID.Text, out int id))
            {
                nuevoJugador.Id = id;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido (número entero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del jugador.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombre.Focus();
                return;
            }
            nuevoJugador.Nombre = textBoxNombre.Text.Trim();

            if (int.TryParse(textBoxNivel.Text, out int nivel))
            {
                nuevoJugador.Nivel = nivel;
                if (nuevoJugador.Nivel < 0)
                {
                    MessageBox.Show("El nivel no puede ser negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNivel.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nivel válido (número entero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNivel.Focus();
                return;
            }
            _jugadorService.Actualizar(nuevoJugador);
            textBoxID.Clear();
            textBoxNombre.Clear();
            textBoxNivel.Clear();
            textBoxID.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
