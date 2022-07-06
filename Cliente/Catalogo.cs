using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista.Cliente
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
            personalizadaBarra();
        }

        private void personalizadaBarra()
        {
            panelAudi.Visible = false;
            panelBmw.Visible = false;
            panelFord.Visible = false;
            panelMercedes.Visible = false;
        }

        private void ocultarSubmenu()
        {
            if (panelAudi.Visible == true)
            {
                panelAudi.Visible = false;
            }
            if (panelBmw.Visible == true)
            {
                panelBmw.Visible = false;
            }
            if(panelFord.Visible == true)
            {
                panelFord.Visible = false;
            }
            if(panelMercedes.Visible == true)
            {
                panelMercedes.Visible = false;
            }
        }

        private void ocultarFoto()
        {
            if(pictureFord.Visible == true)
            {
                pictureFord.Visible = false;
            }
            if(pictureAudi.Visible == true)
            {
                pictureAudi.Visible = false;
            }
            if(pictureBmw.Visible == true)
            {
                pictureBmw.Visible = false;
            }
            if (pictureMercedes.Visible == true)
            {
                pictureMercedes.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void mostrarFoto(PictureBox MostrarFoto)
        {
            if (MostrarFoto.Visible == false)
            {
                ocultarFoto();
                MostrarFoto.Visible = true;
            }
            else
                MostrarFoto.Visible = false;
        }


        private void btnAudi_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelAudi);
            mostrarFoto(pictureAudi);
        }

        private void btnBmw_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelBmw);
            mostrarFoto(pictureBmw);
        }

        private void btnMercedes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMercedes);
            mostrarFoto(pictureMercedes);
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelFord);
            mostrarFoto(pictureFord);
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            pictureFord.Visible=false;
            pictureAudi.Visible=false;
            pictureBmw.Visible=false;
            pictureMercedes.Visible=false;
        }
    }
}
