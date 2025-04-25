namespace Parcial2MinecraftRP
{
    partial class BuscarBloqueID
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
            dgvBloques = new DataGridView();
            textBoxID = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBloques).BeginInit();
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
            buttonBuscar.Location = new Point(232, 17);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(256, 53);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dgvBloques
            // 
            dgvBloques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBloques.Location = new Point(12, 104);
            dgvBloques.Name = "dgvBloques";
            dgvBloques.Size = new Size(776, 329);
            dgvBloques.TabIndex = 10;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(36, 35);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(176, 23);
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
            button1.Location = new Point(513, 17);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 25;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BuscarBloqueID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(dgvBloques);
            Controls.Add(textBoxID);
            Name = "BuscarBloqueID";
            Text = "BuscarBloqueID";
            Load += BuscarBloqueID_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBloques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscar;
        private DataGridView dgvBloques;
        private TextBox textBoxID;
        private Button button1;
    }
}