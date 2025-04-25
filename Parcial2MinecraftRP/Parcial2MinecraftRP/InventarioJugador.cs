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
    public partial class InventarioJugador : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private List<Inventario> _listaInventariosCargada;

        public InventarioJugador(InventarioService inventarioService, JugadorService jugadorService, BloqueService bloqueService)
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (_listaInventariosCargada == null || !_listaInventariosCargada.Any())
            {
                _listaInventariosCargada = _inventarioService.ObtenerTodos();
            }

            if (int.TryParse(textBoxID.Text, out int idBuscar))
            {
                var inventariosFiltrados = _inventarioService.ObtenerPorJugador(idBuscar);

                if (inventariosFiltrados == null || !inventariosFiltrados.Any())
                {
                    MessageBox.Show("No hay inventarios registrados para el jugador con el ID proporcionado.");
                    dgvInventario.Visible = false;
                }
                else
                {
                    dgvInventario.DataSource = inventariosFiltrados;
                    dgvInventario.Visible = true;
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

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos de inventarios visibles para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar Invetario de jugador como Excel";
                saveFileDialog.FileName = "InventarioJugador.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName; 
                    try
                    {
                        List<Inventario> inventariosVisibles = new List<Inventario>();
                        foreach (DataGridViewRow row in dgvInventario.Rows)
                        {
                            if (row.DataBoundItem is Inventario inventario)
                            {
                                inventariosVisibles.Add(inventario);
                            }
                        }

                        Exportador.ExportarAExcel(inventariosVisibles, filePath, "Inventarios");

                        MessageBox.Show("Inventario exportado a Excel exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar el Inventario a Excel: {ex.Message}", "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonExportarCsv_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos de inventario visibles para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de csv (*.csv)|*.csv";
                saveFileDialog.Title = "Guardar inventario como CSV";
                saveFileDialog.FileName = "InvantarioJugadorcsv.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        List<Inventario> inventarios = new List<Inventario>();
                        foreach (DataGridViewRow row in dgvInventario.Rows)
                        {
                            if (row.DataBoundItem is Inventario inventario)
                            {
                                inventarios.Add(inventario);
                            }
                        }

                        Exportador.ExportarACsv(inventarios, filePath, ";");

                        MessageBox.Show("Inventario exportado a CSV exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar el Inventario a CSV: {ex.Message}", "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
