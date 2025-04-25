namespace Parcial2MinecraftRP
{
    partial class AgregarBloquesInventario
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
            buttonAgregar = new Button();
            comboBoxJugador = new ComboBox();
            comboBoxBloque = new ComboBox();
            textBoxCantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSalir = new Button();
            SuspendLayout();
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
            buttonAgregar.Location = new Point(20, 140);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(256, 53);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar bloque al inventario";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // comboBoxJugador
            // 
            comboBoxJugador.FormattingEnabled = true;
            comboBoxJugador.Location = new Point(131, 25);
            comboBoxJugador.Name = "comboBoxJugador";
            comboBoxJugador.Size = new Size(121, 23);
            comboBoxJugador.TabIndex = 8;
            // 
            // comboBoxBloque
            // 
            comboBoxBloque.FormattingEnabled = true;
            comboBoxBloque.Location = new Point(131, 63);
            comboBoxBloque.Name = "comboBoxBloque";
            comboBoxBloque.Size = new Size(121, 23);
            comboBoxBloque.TabIndex = 9;
            comboBoxBloque.SelectedIndexChanged += comboBoxBloque_SelectedIndexChanged;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(152, 103);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 11;
            label1.Text = "Jugador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 66);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "Bloque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 106);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 13;
            label3.Text = "Cantidad";
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
            buttonSalir.Location = new Point(20, 213);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(256, 53);
            buttonSalir.TabIndex = 14;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // AgregarBloquesInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(298, 278);
            Controls.Add(buttonSalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCantidad);
            Controls.Add(comboBoxBloque);
            Controls.Add(comboBoxJugador);
            Controls.Add(buttonAgregar);
            Name = "AgregarBloquesInventario";
            Text = "AgregarBloquesInventario";
            Load += AgregarBloquesInventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private ComboBox comboBoxJugador;
        private ComboBox comboBoxBloque;
        private TextBox textBoxCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSalir;
    }
}