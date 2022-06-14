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
        //Eliminar Password Char
        char password_delete;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            password_delete = txtContraseña.PasswordChar;
        }
        //PLACEHOLDERS
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Nombre de usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }          
        }
        //PLACEHOLDERS
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.PasswordChar = char.Parse("*");
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }
        //PLACEHOLDERS
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Nombre de usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }
        //PLACEHOLDERS
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.PasswordChar = password_delete;
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
            }
        }

        private void btnRegistrarLO_Click(object sender, EventArgs e)
        {
            //Invocar Formulario Registro//
            Registro formRE = new Registro();
            formRE.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarRE_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginLO_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD:Login/Form1.cs
            vista.Cliente.Catalogo catalago = new vista.Cliente.Catalogo();
            catalago.ShowDialog();
=======
            Interfaz_Administrador a = new Interfaz_Administrador();
            this.Hide();
            a.ShowDialog();

>>>>>>> pruebas:Form1.cs
        }
    }
}
