using Parcial2MinecraftRP.Models;
using Parcial2MinecraftRP.Services;
using Parcial2MinecraftRP.Utils;
using System;

namespace Parcial2MinecraftRP
{
    public partial class Form1 : Form
    {
        private DatabaseManager _dbManager;
        private JugadorService _jugadorService;
        private BloqueService _bloqueService;
        private InventarioService _inventarioService;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbManager = new DatabaseManager();

            if (!_dbManager.TestConnection())
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique la conexión e intente nuevamente.","Error de Conexión",  MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _jugadorService = new JugadorService(_dbManager);
            _bloqueService = new BloqueService(_dbManager);
            _inventarioService = new InventarioService(_dbManager, _jugadorService, _bloqueService);

            MessageBox.Show("Conexión a la base de datos establecida correctamente.","Conexión Exitosa", MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Hide();
            login formLogin = new login();
            formLogin.ShowDialog();
            this.Show();
        }

        private void buttonGJugadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeJugador formJugadores = new GeJugador(_jugadorService);
            formJugadores.ShowDialog();
            this.Show();
        }

        private void buttonGBloques_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeBloques formBloques = new GeBloques(_bloqueService);
            formBloques.ShowDialog();
            this.Show();
        }

        private void buttonGInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeInventario formInventario = new GeInventario(_inventarioService, _jugadorService, _bloqueService);
            formInventario.ShowDialog();
            this.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por usar el Sistema de Gestión de Minecraft de Rafael!","Salir", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
