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
                
                MostrarFoto.Visible = true;
            }
            else
                MostrarFoto.Visible = false;
        }


        private void btnAudi_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelAudi);
        }

        private void btnBmw_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelBmw);
            
           
        }

        private void btnMercedes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMercedes);
            
            
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelFord);
            
        }

        private void abrirFormHijo(object formhijo)
        {
            if(this.panelHijo.Controls.Count > 0)
            {
                this.panelHijo.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelHijo.Controls.Add(fh);
            this.panelHijo.Tag = fh;
            fh.Show();
        }
        

        private void btnAllroad_Click(object sender, EventArgs e)
        {
            //abrirFormHijo(new Modelos_Autos.allroad());
            
            
        }

        private void btn330i_Click(object sender, EventArgs e)
        {
           // abrirFormHijo(new Modelos_Autos._330i());
           

        }

        private void btnC200_Click(object sender, EventArgs e)
        {
           // abrirFormHijo(new Modelos_Autos.c200());
           

        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
           // abrirFormHijo(new Modelos_Autos.focus());
           

        }
    }
}
