namespace Parcial2MinecraftRP
{
    partial class login
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
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(99, 71);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(99, 112);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.Size = new Size(100, 23);
            textBoxContrasena.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 74);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonSalir.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSalir.Location = new Point(26, 179);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(256, 53);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Iniciar sesión";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(301, 273);
            Controls.Add(buttonSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Label label1;
        private Label label2;
        private Button buttonSalir;
    }
}