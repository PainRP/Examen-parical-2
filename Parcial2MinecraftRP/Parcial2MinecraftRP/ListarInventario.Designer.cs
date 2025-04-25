namespace Parcial2MinecraftRP
{
    partial class ListarInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvInventario = new DataGridView();
            buttonSalir = new Button();
            buttonExportarCsv = new Button();
            saveFileDialog1 = new SaveFileDialog();
            buttonExportarExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(12, 12);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.Size = new Size(776, 367);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonSalir.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSalir.ForeColor = Color.Black;
            buttonSalir.Location = new Point(277, 385);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(256, 53);
            buttonSalir.TabIndex = 8;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonExportarCsv
            // 
            buttonExportarCsv.BackColor = Color.Transparent;
            buttonExportarCsv.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonExportarCsv.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExportarCsv.FlatAppearance.BorderSize = 0;
            buttonExportarCsv.FlatStyle = FlatStyle.Flat;
            buttonExportarCsv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonExportarCsv.Location = new Point(539, 385);
            buttonExportarCsv.Name = "buttonExportarCsv";
            buttonExportarCsv.Size = new Size(256, 53);
            buttonExportarCsv.TabIndex = 10;
            buttonExportarCsv.Text = "Exportar a csv";
            buttonExportarCsv.UseVisualStyleBackColor = false;
            buttonExportarCsv.Click += buttonExportarCsv_Click;
            // 
            // buttonExportarExcel
            // 
            buttonExportarExcel.BackColor = Color.Transparent;
            buttonExportarExcel.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonExportarExcel.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExportarExcel.FlatAppearance.BorderSize = 0;
            buttonExportarExcel.FlatStyle = FlatStyle.Flat;
            buttonExportarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonExportarExcel.Location = new Point(12, 385);
            buttonExportarExcel.Name = "buttonExportarExcel";
            buttonExportarExcel.Size = new Size(256, 53);
            buttonExportarExcel.TabIndex = 11;
            buttonExportarExcel.Text = "Exportar a Excel";
            buttonExportarExcel.UseVisualStyleBackColor = false;
            buttonExportarExcel.Click += buttonExportarExcel_Click_1;
            // 
            // ListarInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExportarExcel);
            Controls.Add(buttonExportarCsv);
            Controls.Add(buttonSalir);
            Controls.Add(dgvInventario);
            Name = "ListarInventario";
            Text = "ListarInventario";
            Load += ListarInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventario;
        private Button buttonSalir;
        private Button buttonExportarCsv;
        private SaveFileDialog saveFileDialog1;
        private Button buttonExportarExcel;
    }
}