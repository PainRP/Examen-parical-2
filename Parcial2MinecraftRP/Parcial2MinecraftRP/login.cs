using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2MinecraftRP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        { 
            if (textBoxUsuario.Text == "Vegeta777" && textBoxContrasena.Text == "Willy")
            {
                MessageBox.Show("Bienvenido Vegeta777");
                this.Hide();

            }
            else if(textBoxUsuario.Text == "Admin" && textBoxContrasena.Text == "password")
            {
                MessageBox.Show("Bienvenido Admin");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
