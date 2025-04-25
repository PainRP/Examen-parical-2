namespace Parcial2MinecraftRP
{
    partial class BuscarJugadorID
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
            textBoxID = new TextBox();
            dgvJugador = new DataGridView();
            buttonBuscar = new Button();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvJugador).BeginInit();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(150, 46);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(130, 23);
            textBoxID.TabIndex = 0;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // dgvJugador
            // 
            dgvJugador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugador.Location = new Point(12, 109);
            dgvJugador.Name = "dgvJugador";
            dgvJugador.Size = new Size(871, 329);
            dgvJugador.TabIndex = 2;
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
            buttonBuscar.Location = new Point(555, 28);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(244, 53);
            buttonBuscar.TabIndex = 8;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
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
            button1.Location = new Point(286, 28);
            button1.Name = "button1";
            button1.Size = new Size(244, 53);
            button1.TabIndex = 27;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BuscarJugadorID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(895, 450);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(dgvJugador);
            Controls.Add(textBoxID);
            Name = "BuscarJugadorID";
            Text = "BuscarJugadorID";
            Load += BuscarJugadorID_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private DataGridView dgvJugador;
        private Button buttonBuscar;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
    }
}