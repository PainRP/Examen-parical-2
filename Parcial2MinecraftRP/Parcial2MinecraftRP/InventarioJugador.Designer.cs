namespace Parcial2MinecraftRP
{
    partial class InventarioJugador
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
            buttonBuscar = new Button();
            dgvInventario = new DataGridView();
            textBoxID = new TextBox();
            button1 = new Button();
            buttonExportarCsv = new Button();
            buttonExportarExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Transparent;
            buttonBuscar.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.Black;
            buttonBuscar.Location = new Point(12, 52);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(151, 36);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(12, 104);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(884, 329);
            dgvInventario.TabIndex = 10;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(39, 23);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(156, 23);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 27;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonExportarCsv
            // 
            buttonExportarCsv.BackColor = Color.Transparent;
            buttonExportarCsv.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonExportarCsv.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExportarCsv.FlatAppearance.BorderSize = 0;
            buttonExportarCsv.FlatStyle = FlatStyle.Flat;
            buttonExportarCsv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonExportarCsv.Location = new Point(651, 23);
            buttonExportarCsv.Name = "buttonExportarCsv";
            buttonExportarCsv.Size = new Size(256, 53);
            buttonExportarCsv.TabIndex = 31;
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
            buttonExportarExcel.Location = new Point(403, 23);
            buttonExportarExcel.Name = "buttonExportarExcel";
            buttonExportarExcel.Size = new Size(256, 53);
            buttonExportarExcel.TabIndex = 30;
            buttonExportarExcel.Text = "Exportar a Excel";
            buttonExportarExcel.UseVisualStyleBackColor = false;
            buttonExportarExcel.Click += buttonExportarExcel_Click;
            // 
            // InventarioJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(908, 450);
            Controls.Add(buttonExportarCsv);
            Controls.Add(buttonExportarExcel);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(dgvInventario);
            Controls.Add(textBoxID);
            Name = "InventarioJugador";
            Text = "InventarioJugador";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscar;
        private DataGridView dgvInventario;
        private TextBox textBoxID;
        private Button button1;
        private Button buttonExportarCsv;
        private Button buttonExportarExcel;
    }
}