namespace Parcial2MinecraftRP
{
    partial class ListarBloques
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
            dgvBloques = new DataGridView();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvBloques).BeginInit();
            SuspendLayout();
            // 
            // dgvBloques
            // 
            dgvBloques.AllowUserToAddRows = false;
            dgvBloques.AllowUserToDeleteRows = false;
            dgvBloques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBloques.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBloques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBloques.Location = new Point(12, 12);
            dgvBloques.Name = "dgvBloques";
            dgvBloques.ReadOnly = true;
            dgvBloques.Size = new Size(776, 375);
            dgvBloques.TabIndex = 0;
            dgvBloques.CellContentClick += dgvBloques_CellContentClick;
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
            button1.Location = new Point(274, 391);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 27;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ListarBloques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgvBloques);
            Name = "ListarBloques";
            Text = "ListarBloques";
            Load += ListarBloques_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBloques).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBloques;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
    }
}