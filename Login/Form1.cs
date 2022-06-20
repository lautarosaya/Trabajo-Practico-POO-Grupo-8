using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char passwordchar;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 318);
            //GetPasswordChar
            passwordchar = txtContraseña.PasswordChar;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Nombre de usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }          
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '*';
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Nombre de usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            { 
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = passwordchar;
                txtContraseña.ForeColor = Color.Silver;
            }
        }

        private void btnRegistrarRE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoginLO_Click(object sender, EventArgs e)
        {
            vista.Cliente.Catalogo catalago = new vista.Cliente.Catalogo();
            catalago.ShowDialog();
        }

        private void btnRegistrarLO_Click(object sender, EventArgs e)
        {
            vista.Login.Registro registroFORM = new vista.Login.Registro();
            registroFORM.ShowDialog();
        }
    }
}
