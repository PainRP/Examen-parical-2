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
    public partial class ListarInventario : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private List<Inventario> _listaInventarioCargada;

        public ListarInventario(InventarioService inventarioService, JugadorService jugadorService, BloqueService bloqueService)
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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarInventario_Load(object sender, EventArgs e)
        {
            try
            {
                _listaInventarioCargada = _inventarioService.ObtenerTodos();

                dgvInventario.DataSource = _listaInventarioCargada;

                if (_listaInventarioCargada.Count == 0)
                {
                    MessageBox.Show("No hay jugadores registrados.");
                    dgvInventario.Visible = false;
                }
                else
                {
                    dgvInventario.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar la lista de jugadores: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _listaInventarioCargada = new List<Inventario>();
                dgvInventario.DataSource = null;
                dgvInventario.Visible = false;
            }
        }

        private void buttonExportarCsv_Click(object sender, EventArgs e)
        {
            if (_listaInventarioCargada == null || !_listaInventarioCargada.Any())
            {
                MessageBox.Show("No hay datos de Inventario cargados para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de csv (*.csv)|*.csv";
                saveFileDialog.Title = "Guardar lista de Inventario como csv";
                saveFileDialog.FileName = "ListaDeInventario.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {

                        Exportador.ExportarACsv(_listaInventarioCargada, filePath, ";");

                        MessageBox.Show("Lista de Inventario exportada a csv exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar la lista de Invantario a csv: {ex.Message}", "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonExportarExcel_Click_1(object sender, EventArgs e)
        {
            if (_listaInventarioCargada == null || !_listaInventarioCargada.Any())
            {
                MessageBox.Show("No hay datos de Inventario cargados para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar lista de jugadores como Excel";
                saveFileDialog.FileName = "ListaDeInventario.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        Exportador.ExportarAExcel(_listaInventarioCargada, filePath, "Jugadores");

                        MessageBox.Show("Lista de Inventario exportada a Excel exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar la lista de Inventario a Excel: {ex.Message}", "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
