using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista.Admin
{
    public partial class Interfaz_Cliente : Form
    {
        public Interfaz_Cliente()
        {
            InitializeComponent();
        }

        private void Comprar_Vehiculo_Click(object sender, EventArgs e)
        {
            vista.Admin.Vechiculo_Comprar log = new vista.Admin.Vechiculo_Comprar();
            this.Hide();
            log.ShowDialog();
        }

        private void Boton_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
        }

        private void Boton_Cerrar_Sesion_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Boton_Cerrar_Sesion_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
