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
    public partial class Vehiculo_Agregar : Form
    {
        public Vehiculo_Agregar()
        {
            InitializeComponent();
            autos_audi.Items.Add("All Road");
            autos_bmw.Items.Add("330i");
            autos_ford.Items.Add("Focus");
            Autos_mercedes.Items.Add("C200");           
        }

        private void Boton_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vista.Interfaz_Administrador interfaz_Administrador = new vista.Interfaz_Administrador();
            this.Hide();
            interfaz_Administrador.ShowDialog();

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
