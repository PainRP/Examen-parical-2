namespace Parcial2MinecraftRP
{
    partial class GeJugador
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
            pictureBox1 = new PictureBox();
            buttonRegistrar = new Button();
            buttonBuscar = new Button();
            buttonListar = new Button();
            buttonEliminar = new Button();
            buttonVolver = new Button();
            buttonActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.GESTION_DE_JUGADORES;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(129, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            buttonRegistrar.Location = new Point(129, 160);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(256, 53);
            buttonRegistrar.TabIndex = 2;
            buttonRegistrar.Text = "Registrar nuevo jugador";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
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
            buttonBuscar.Location = new Point(129, 219);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(256, 53);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar jugador por ID";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonListar
            // 
            buttonListar.BackColor = Color.Transparent;
            buttonListar.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonListar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonListar.FlatAppearance.BorderSize = 0;
            buttonListar.FlatStyle = FlatStyle.Flat;
            buttonListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonListar.ForeColor = Color.Black;
            buttonListar.Location = new Point(413, 160);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(256, 53);
            buttonListar.TabIndex = 5;
            buttonListar.Text = "Listar todos los jugadores";
            buttonListar.UseVisualStyleBackColor = false;
            buttonListar.Click += buttonListar_Click;
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
            buttonEliminar.Location = new Point(129, 278);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(256, 53);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar jugador";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Transparent;
            buttonVolver.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonVolver.BackgroundImageLayout = ImageLayout.Stretch;
            buttonVolver.FlatAppearance.BorderSize = 0;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonVolver.ForeColor = Color.Black;
            buttonVolver.Location = new Point(274, 353);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(256, 53);
            buttonVolver.TabIndex = 7;
            buttonVolver.Text = "Volver al menú principal";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
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
            buttonActualizar.Location = new Point(413, 219);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(256, 53);
            buttonActualizar.TabIndex = 6;
            buttonActualizar.Text = "Actualizar jugador";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click_1;
            // 
            // GeJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolver);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonListar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonRegistrar);
            Controls.Add(pictureBox1);
            Name = "GeJugador";
            Text = "Gestor de Jugadores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonRegistrar;
        private Button buttonBuscar;
        private Button buttonListar;
        private Button buttonEliminar;
        private Button buttonVolver;
        private Button buttonActualizar;
    }
}