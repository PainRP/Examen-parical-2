namespace Parcial2MinecraftRP
{
    partial class EliminarElementoInventario
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
            comboBoxID = new ComboBox();
            buttonActualizar = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxID
            // 
            comboBoxID.FormattingEnabled = true;
            comboBoxID.Location = new Point(112, 61);
            comboBoxID.Name = "comboBoxID";
            comboBoxID.Size = new Size(121, 23);
            comboBoxID.TabIndex = 7;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.Transparent;
            buttonActualizar.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonActualizar.FlatAppearance.BorderSize = 0;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonActualizar.ForeColor = Color.Black;
            buttonActualizar.Location = new Point(21, 121);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(256, 53);
            buttonActualizar.TabIndex = 6;
            buttonActualizar.Text = "Eliminar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
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
            button1.Location = new Point(21, 180);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // EliminarElementoInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(307, 270);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBoxID);
            Controls.Add(buttonActualizar);
            Name = "EliminarElementoInventario";
            Text = "EliminarElementoInventario";
            Load += EliminarElementoInventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxID;
        private Button buttonActualizar;
        private Button button1;
        private Label label1;
    }
}