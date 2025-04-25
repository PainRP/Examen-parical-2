namespace Parcial2MinecraftRP
{
    partial class GeInventario
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
            buttonActualizar = new Button();
            buttonVer = new Button();
            buttonListar = new Button();
            buttonAgregar = new Button();
            buttonSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            buttonEliminar.Location = new Point(132, 275);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(256, 53);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar elemento del inventario";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
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
            buttonActualizar.Location = new Point(437, 216);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(256, 53);
            buttonActualizar.TabIndex = 3;
            buttonActualizar.Text = "Actualizar cantidad en inventario";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.Transparent;
            buttonVer.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonVer.BackgroundImageLayout = ImageLayout.Stretch;
            buttonVer.FlatAppearance.BorderSize = 0;
            buttonVer.FlatStyle = FlatStyle.Flat;
            buttonVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonVer.ForeColor = Color.Black;
            buttonVer.Location = new Point(132, 216);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(256, 53);
            buttonVer.TabIndex = 4;
            buttonVer.Text = "Ver inventario de un jugador";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
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
            buttonListar.Location = new Point(437, 156);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(256, 53);
            buttonListar.TabIndex = 5;
            buttonListar.Text = "Listar todo el inventario";
            buttonListar.UseVisualStyleBackColor = false;
            buttonListar.Click += buttonListar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Transparent;
            buttonAgregar.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAgregar.ForeColor = Color.Black;
            buttonAgregar.Location = new Point(132, 156);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(256, 53);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar bloques al inventario";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources._92eac884fa29232_3491166754;
            buttonSalir.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSalir.ForeColor = Color.Black;
            buttonSalir.Location = new Point(280, 370);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(256, 53);
            buttonSalir.TabIndex = 7;
            buttonSalir.Text = "Volver al menú principal";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.GESTION_DE_INVENTARIO;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(132, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 92);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // GeInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonListar);
            Controls.Add(buttonVer);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Name = "GeInventario";
            Text = "GeInventario";
            Load += GeInventario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEliminar;
        private Button buttonActualizar;
        private Button buttonVer;
        private Button buttonListar;
        private Button buttonAgregar;
        private Button buttonSalir;
        private PictureBox pictureBox1;
    }
}