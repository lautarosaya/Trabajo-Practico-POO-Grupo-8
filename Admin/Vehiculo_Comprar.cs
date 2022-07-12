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
    public partial class Vechiculo_Comprar : Form
    {
        public Vechiculo_Comprar()
        {
            InitializeComponent();
            autos_audi.Items.Add("All Road");
            autos_bmw.Items.Add("330i");
            autos_ford.Items.Add("Focus");
            autos_mercedes.Items.Add("C200");
        }

        private void Boton_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Close();
            log.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vista.Interfaz_Administrador admin = new vista.Interfaz_Administrador();
            this.Hide();
            admin.ShowDialog();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Boton_Cerrar_Sesion_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Boton_Cerrar_Sesion_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
