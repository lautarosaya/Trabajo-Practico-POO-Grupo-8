using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        //Importando System32 para crear drag//
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Fin de código//
        private void Form1_Load(object sender, EventArgs e)
        {
            
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
          Controladora.usuarios usuarios = new Controladora.usuarios();

            switch (usuarios.identificador(txtUsuario.Text, txtContraseña.Text))
            {
                case 1:
                    vista.Interfaz_Administrador adminFORM = new vista.Interfaz_Administrador();
                    this.Hide();
                    adminFORM.ShowDialog();
                    break;
                
                default:
                    MessageBox.Show("Se ingreso el usuario o una contraseña incorrecta, por favor revisar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }                                 
        }

        private void btnRegistrarLO_Click(object sender, EventArgs e)
        {
            vista.Login.Registro registroFORM = new vista.Login.Registro();
            registroFORM.ShowDialog();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
