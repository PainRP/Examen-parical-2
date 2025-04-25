namespace Parcial2MinecraftRP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            buttonGJugadores = new Button();
            buttonGBloques = new Button();
            buttonGInventario = new Button();
            buttonSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Sistema_de_Gestion_de_Mi;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(50, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(715, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonGJugadores
            // 
            buttonGJugadores.BackColor = Color.Transparent;
            buttonGJugadores.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonGJugadores.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGJugadores.FlatAppearance.BorderSize = 0;
            buttonGJugadores.FlatStyle = FlatStyle.Flat;
            buttonGJugadores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonGJugadores.ForeColor = Color.Black;
            buttonGJugadores.Location = new Point(283, 139);
            buttonGJugadores.Name = "buttonGJugadores";
            buttonGJugadores.Size = new Size(256, 53);
            buttonGJugadores.TabIndex = 1;
            buttonGJugadores.Text = "Gestionar Jugadores";
            buttonGJugadores.UseVisualStyleBackColor = false;
            buttonGJugadores.Click += buttonGJugadores_Click;
            // 
            // buttonGBloques
            // 
            buttonGBloques.BackColor = Color.Transparent;
            buttonGBloques.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonGBloques.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGBloques.FlatAppearance.BorderSize = 0;
            buttonGBloques.FlatStyle = FlatStyle.Flat;
            buttonGBloques.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonGBloques.Location = new Point(283, 212);
            buttonGBloques.Name = "buttonGBloques";
            buttonGBloques.Size = new Size(256, 53);
            buttonGBloques.TabIndex = 2;
            buttonGBloques.Text = "Gestionar Bloques";
            buttonGBloques.UseVisualStyleBackColor = false;
            buttonGBloques.Click += buttonGBloques_Click;
            // 
            // buttonGInventario
            // 
            buttonGInventario.BackColor = Color.Transparent;
            buttonGInventario.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonGInventario.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGInventario.FlatAppearance.BorderSize = 0;
            buttonGInventario.FlatStyle = FlatStyle.Flat;
            buttonGInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonGInventario.Location = new Point(283, 285);
            buttonGInventario.Name = "buttonGInventario";
            buttonGInventario.Size = new Size(256, 53);
            buttonGInventario.TabIndex = 3;
            buttonGInventario.Text = "Gestionar Inventario";
            buttonGInventario.UseVisualStyleBackColor = false;
            buttonGInventario.Click += buttonGInventario_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonSalir.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSalir.Location = new Point(283, 358);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(256, 53);
            buttonSalir.TabIndex = 4;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGInventario);
            Controls.Add(buttonGBloques);
            Controls.Add(buttonGJugadores);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Sistema de Gestión de Minecraft";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonGJugadores;
        private Button buttonGBloques;
        private Button buttonGInventario;
        private Button buttonSalir;
    }
}
