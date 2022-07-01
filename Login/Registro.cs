using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista.Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        char passwordchar;
        //varText//
        string Nombretxt = "Nombre";
        string Apellidotxt = "Apellido";
        string Usuariotxt = "Nombre de Usuario";
        string Correotxt = "Correo Electronico";
        // // // // // // // // // // // // // //
        //Colores Set//
        Color pctOn = Color.FromArgb(65, 168, 95);
        Color pctOff = Color.DarkGray;
        // // // // // // // // // // // // // //

        private void pctBackRE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {           
            placeholder(txtUsuario,1,Usuariotxt);
            pctLineDecoration(pctUsuario, 1);

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            placeholder(txtUsuario,2,Usuariotxt);
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
            pctLineDecoration(pctContraseña, 1);
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = passwordchar;
                txtContraseña.ForeColor = Color.Silver;
            }
            pctLineDecoration(pctContraseña, 2);
        }
            
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            placeholder(txtApellido, 1, Apellidotxt);
            pctLineDecoration(pctApellido, 1);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            placeholder(txtApellido, 2, Apellidotxt);
            pctLineDecoration(pctApellido, 2);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            placeholder(txtNombre, 1, Nombretxt);
            pctLineDecoration(pctNombre, 1);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            placeholder(txtNombre,2, Nombretxt);
            pctLineDecoration(pctNombre, 2);
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            placeholder(txtMail,1,Correotxt);
            pctLineDecoration(pctCorreo, 1);
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            placeholder(txtMail, 2, Correotxt);
            pctLineDecoration(pctCorreo, 2);
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

        public void pctLineDecoration(PictureBox a, int caso)
        {
            //Está función la uso para las lineas de color verde y gris, una decoración bastante moderna//
            //Caso 1 significa que el usuario entro al TextBox y Caso 2 Significa que el usuario salió del TextBox//
            switch (caso)
            {
                case 1:
                    int i = a.Size.Width;
                    a.Size = new Size(i, 24);
                    a.BackColor = pctOn;
                    break;

                case 2:
                    int j = a.Size.Width;
                    a.Size = new Size(j, 23);
                    a.BackColor = pctOff;
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
