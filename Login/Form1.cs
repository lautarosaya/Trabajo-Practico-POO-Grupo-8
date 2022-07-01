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
        //Variables//

        string Usuariotxt = "Nombre de usuario";
        char passwordchar;
        //Colores Seteados//
        Color greenHoover = Color.FromArgb(20, 135, 104);
        Color grisHoover = Color.FromArgb(126, 140, 137);
        Color greenLeave = Color.FromArgb(65, 168, 95);
        Color pctOn = Color.FromArgb(65, 168, 95);
        Color pctOff = Color.DarkGray;
        
        //DRAG MOVE, Mover formulario con panel//
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]

        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //Fin del código mover (drag)//

        /*
        if (e.Button == MouseButtons.Left)

        {

        ReleaseCapture();

        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

        }*/

    private void Form1_Load(object sender, EventArgs e)
        {
            
            //GetPasswordChar
            passwordchar = txtContraseña.PasswordChar;
            btnLoginLO.FlatAppearance.MouseOverBackColor = greenHoover;
            btnIniciar.FlatAppearance.MouseOverBackColor = greenHoover;
            btnRegistrarLO.FlatAppearance.MouseOverBackColor = grisHoover;          
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            placeholder(txtUsuario, 1, Usuariotxt);
            pctLineDecoration(pctUsuario, 1);                   
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            placeholder(txtUsuario, 2, Usuariotxt);
            pctLineDecoration(pctUsuario, 2);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '*';
                txtContraseña.ForeColor = Color.Black;
            }
            pctLineDecoration(pctPassword, 1);
        }


        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            { 
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = passwordchar;
                txtContraseña.ForeColor = Color.Silver;
            }
            pctLineDecoration(pctPassword, 2);
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
            this.Hide();
            registroFORM.ShowDialog();
            this.Show();
        }
     
        private void btnRegistrarLO_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarLO.ForeColor = Color.DimGray;
        }

        private void btnRegistrarLO_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarLO.ForeColor = Color.White;
        }

        public void pctLineDecoration(PictureBox a, int caso)
        {
            //Está función la uso para las lineas de color verde y gris, una decoración bastante moderna//
            //Caso 1 significa que el usuario entro al TextBox y Caso 2 Significa que el usuario salió del TextBox//
            switch (caso)
            {
                case 1:
                    a.Size = new Size(312, 24);
                    a.BackColor = pctOn;
                    break;

                case 2:
                    a.Size = new Size(312, 23);
                    a.BackColor = pctOff;
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        public void placeholder(TextBox a, int caso, string varText)
        {
            //Caso 1 Usuario Ingreso al TextBox y Caso2 Usuario sale del TextBox//
            switch (caso)
            {
                case 1:
                    if (a.Text == varText)
                    {
                        a.Text = "";
                        a.ForeColor = Color.Black;
                    }
                    break;

                case 2:
                    if (a.Text == "")
                    {
                        a.Text = varText;
                        a.ForeColor = Color.Silver;
                    }
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
    }
}
