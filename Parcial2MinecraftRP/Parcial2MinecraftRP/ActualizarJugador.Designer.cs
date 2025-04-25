namespace Parcial2MinecraftRP
{
    partial class ActualizarJugador
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
            label2 = new Label();
            label1 = new Label();
            textBoxNivel = new TextBox();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxID = new TextBox();
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
            buttonActualizar.Location = new Point(107, 175);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(256, 53);
            buttonActualizar.TabIndex = 13;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 146);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 12;
            label2.Text = "Nivel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 107);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // textBoxNivel
            // 
            textBoxNivel.Location = new Point(150, 146);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(100, 23);
            textBoxNivel.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(150, 104);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(213, 23);
            textBoxNombre.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 66);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 15;
            label3.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(150, 63);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(74, 23);
            textBoxID.TabIndex = 14;
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
            button1.Location = new Point(107, 234);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 25;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActualizarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(485, 310);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBoxID);
            Controls.Add(buttonActualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNivel);
            Controls.Add(textBoxNombre);
            Name = "ActualizarJugador";
            Text = "ActualizarUsuario";
            Load += ActualizarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonActualizar;
        private Label label2;
        private Label label1;
        private TextBox textBoxNivel;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxID;
        private Button button1;
    }
}