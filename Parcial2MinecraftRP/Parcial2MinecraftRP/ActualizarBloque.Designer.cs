namespace Parcial2MinecraftRP
{
    partial class ActualizarBloque
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
            buttonActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxID = new TextBox();
            textBoxNombre = new TextBox();
            comboBoxTipo = new ComboBox();
            comboBoxRareza = new ComboBox();
            button1 = new Button();
            SuspendLayout();
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
            buttonActualizar.Location = new Point(63, 222);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(256, 53);
            buttonActualizar.TabIndex = 14;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 81);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 119);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 158);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 17;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 196);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 18;
            label4.Text = "Rareza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 196);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 19;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(162, 78);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 20;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(162, 116);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 21;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Construcción", "Funcional ", "Generados por estructura", "Madera", "Mineral", "Naturales", "Vegetales" });
            comboBoxTipo.Location = new Point(162, 155);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 23;
            // 
            // comboBoxRareza
            // 
            comboBoxRareza.FormattingEnabled = true;
            comboBoxRareza.Items.AddRange(new object[] { "Común", "Raro", "Épico", "Legendario" });
            comboBoxRareza.Location = new Point(162, 193);
            comboBoxRareza.Name = "comboBoxRareza";
            comboBoxRareza.Size = new Size(121, 23);
            comboBoxRareza.TabIndex = 22;
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
            button1.Location = new Point(63, 281);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 24;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActualizarBloque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(392, 359);
            Controls.Add(button1);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxRareza);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonActualizar);
            Name = "ActualizarBloque";
            Text = "ActualizarBloque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxID;
        private TextBox textBoxNombre;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxRareza;
        private Button button1;
    }
}