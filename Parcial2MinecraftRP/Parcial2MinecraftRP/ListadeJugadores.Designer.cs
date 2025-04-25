namespace Parcial2MinecraftRP
{
    partial class ListadeJugadores
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
            dgvListaJugadores = new DataGridView();
            buttonSalir = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvListaJugadores).BeginInit();
            SuspendLayout();
            // 
            // dgvListaJugadores
            // 
            dgvListaJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaJugadores.Location = new Point(12, 12);
            dgvListaJugadores.Name = "dgvListaJugadores";
            dgvListaJugadores.Size = new Size(776, 381);
            dgvListaJugadores.TabIndex = 0;
            dgvListaJugadores.CellContentClick += dgvListaJugadores_CellContentClick;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonSalir.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSalir.Location = new Point(274, 395);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(256, 53);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // ListadeJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(dgvListaJugadores);
            Name = "ListadeJugadores";
            Text = "ListadeJugadores";
            Load += ListadeJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaJugadores;
        private Button buttonSalir;
        private SaveFileDialog saveFileDialog1;
    }
}