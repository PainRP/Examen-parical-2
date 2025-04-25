namespace Parcial2MinecraftRP
{
    partial class RegistrarNuevoJugador
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
            textBoxNombre = new TextBox();
            textBoxNivel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonRegistrar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(122, 30);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(213, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxNivel
            // 
            textBoxNivel.Location = new Point(122, 73);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(100, 23);
            textBoxNivel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 73);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Nivel";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Transparent;
            buttonRegistrar.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRegistrar.FlatAppearance.BorderSize = 0;
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonRegistrar.ForeColor = Color.Black;
            buttonRegistrar.Location = new Point(66, 126);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(256, 53);
            buttonRegistrar.TabIndex = 8;
            buttonRegistrar.Text = "Agregar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
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
            button1.Location = new Point(66, 185);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 27;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegistrarNuevoJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(388, 257);
            Controls.Add(button1);
            Controls.Add(buttonRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNivel);
            Controls.Add(textBoxNombre);
            Name = "RegistrarNuevoJugador";
            Text = "RegistrarNuevoJugador";
            Load += RegistrarNuevoJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxNivel;
        private Label label1;
        private Label label2;
        private Button buttonRegistrar;
        private Button button1;
    }
}