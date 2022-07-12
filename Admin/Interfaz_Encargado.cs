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
    public partial class Interfaz_Encargado : Form
    {
        public Interfaz_Encargado()
        {
            InitializeComponent();
        }

        private void Boton_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
        }

        private void Personal_Despedir_Click(object sender, EventArgs e)
        {
            vista.Admin.Vechiculo_Comprar log = new vista.Admin.Vechiculo_Comprar();
            log.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vista.Admin.Empleado_Contratar log = new vista.Admin.Empleado_Contratar();
            log.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Cerrar_Sesion_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Boton_Cerrar_Sesion_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
