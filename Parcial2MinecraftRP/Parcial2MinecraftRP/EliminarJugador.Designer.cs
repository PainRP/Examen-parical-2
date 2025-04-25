namespace Parcial2MinecraftRP
{
    partial class EliminarJugador
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
            buttonEliminar = new Button();
            textBoxID = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Transparent;
            buttonEliminar.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEliminar.ForeColor = Color.Black;
            buttonEliminar.Location = new Point(48, 118);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(256, 53);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(118, 60);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(176, 23);
            textBoxID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 63);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 11;
            label1.Text = "ID";
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
            button1.Location = new Point(48, 177);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 27;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EliminarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(356, 288);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(textBoxID);
            Name = "EliminarJugador";
            Text = "EliminarJugador";
            Load += EliminarJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEliminar;
        private TextBox textBoxID;
        private Label label1;
        private Button button1;
    }
}