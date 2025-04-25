namespace Parcial2MinecraftRP
{
    partial class ActualizarCantidadInventario
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
            comboBoxID = new ComboBox();
            textBoxCantidad = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
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
            buttonActualizar.Location = new Point(38, 179);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(256, 53);
            buttonActualizar.TabIndex = 4;
            buttonActualizar.Text = "Actualizar cantidad en inventario";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // comboBoxID
            // 
            comboBoxID.FormattingEnabled = true;
            comboBoxID.Location = new Point(145, 68);
            comboBoxID.Name = "comboBoxID";
            comboBoxID.Size = new Size(121, 23);
            comboBoxID.TabIndex = 5;
            comboBoxID.SelectedIndexChanged += comboBoxID_SelectedIndexChanged;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(166, 117);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 23);
            textBoxCantidad.TabIndex = 6;
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
            button1.Location = new Point(38, 249);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 25;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 71);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 26;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 120);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 27;
            label2.Text = "Cantidad";
            // 
            // ActualizarCantidadInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.latest_2421108066;
            ClientSize = new Size(333, 324);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxCantidad);
            Controls.Add(comboBoxID);
            Controls.Add(buttonActualizar);
            Name = "ActualizarCantidadInventario";
            Text = "ActualizarCantidadInventario";
            Load += ActualizarCantidadInventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonActualizar;
        private ComboBox comboBoxID;
        private TextBox textBoxCantidad;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}