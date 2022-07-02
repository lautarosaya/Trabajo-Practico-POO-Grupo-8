using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace vista.Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void pctBackRE_MouseHover(object sender, EventArgs e)
        {
            pctBackRE.Image = vista.Properties.Resources.backbrightness;
        }

        private void pctBackRE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBackRE_MouseLeave(object sender, EventArgs e)
        {
            pctBackRE.Image = vista.Properties.Resources.image_removebg_preview;
        }

        private void btnRegistrarRE_Click(object sender, EventArgs e)
        {
            Controladora.usuarios controladora = new Controladora.usuarios();

            string nombre = txtNombreRE.Text;
            string apellido = txtApellidoRE.Text;
            string mail = txtUsuarioRE.Text;
            string contraseña = txtContraseñaRE.Text;

            if (txtNombreRE.Text == "")
            {
                label1.Visible = true;
            }
            if (txtApellidoRE.Text == "")
            {
                label7.Visible = true;
            }
            if (txtUsuarioRE.Text == "")
            {
                label8.Visible = true;
            }
            if (txtContraseñaRE.Text == "")
            {
                label9.Visible = true;

                throw new Campo_vacioException("Revise los campos nuevamente");
            }

            try
            {
                SmtpClient cliente = controladora.SmtpClient();

                MailMessage correo = controladora.Mail_Registro(mail, nombre, apellido);

                cliente.Send(correo);
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if(DialogResult.OK == dialog)
                {
                    label1.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                }
            }

        }
    }

    public class Campo_vacioException : Exception
    {
        public string Campo_vacio { get; }
        public Campo_vacioException() { }
        public Campo_vacioException(string message):base(message) { }
        public Campo_vacioException(string message, Exception inner) : base(message, inner) { }
        public Campo_vacioException(string message, string campo_vacio) : this(message)
        {
            Campo_vacio = campo_vacio;
        }
    }
}
