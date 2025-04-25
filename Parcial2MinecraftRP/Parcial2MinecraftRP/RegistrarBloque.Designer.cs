namespace Parcial2MinecraftRP
{
    partial class RegistrarBloque
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
            buttonRegistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxRareza = new ComboBox();
            comboBoxTipo = new ComboBox();
            textBoxNombre = new TextBox();
            button1 = new Button();
            SuspendLayout();
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
            buttonRegistrar.Location = new Point(84, 196);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(256, 53);
            buttonRegistrar.TabIndex = 9;
            buttonRegistrar.Text = "Agregar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 97);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 13;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 143);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 15;
            label3.Text = "Rareza";
            // 
            // comboBoxRareza
            // 
            comboBoxRareza.FormattingEnabled = true;
            comboBoxRareza.Items.AddRange(new object[] { "Común", "Raro", "Épico", "Legendario" });
            comboBoxRareza.Location = new Point(206, 140);
            comboBoxRareza.Name = "comboBoxRareza";
            comboBoxRareza.Size = new Size(121, 23);
            comboBoxRareza.TabIndex = 16;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Construcción", "Funcional ", "Generados por estructura", "Madera", "Mineral", "Naturales", "Vegetales" });
            comboBoxTipo.Location = new Point(206, 89);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 17;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(206, 46);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(121, 23);
            textBoxNombre.TabIndex = 18;
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
            button1.Location = new Point(84, 255);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 27;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegistrarBloque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(435, 322);
            Controls.Add(button1);
            Controls.Add(textBoxNombre);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxRareza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegistrar);
            Name = "RegistrarBloque";
            Text = "RegistrarBloque";
            Load += RegistrarBloque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxRareza;
        private ComboBox comboBoxTipo;
        private TextBox textBoxNombre;
        private Button button1;
    }
}