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
    public partial class Empleado_Despedir : Form
    {
        public Empleado_Despedir()
        {
            InitializeComponent();
        }

        private void Boton_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
        }

        private void button1_Des_Click(object sender, EventArgs e)
        {
            vista.Interfaz_Administrador admin = new vista.Interfaz_Administrador();
            this.Hide();
            admin.ShowDialog();
        }

        private void button1_Des_MouseEnter(object sender, EventArgs e)
        {
            button1_Des.ForeColor = Color.White;
        }

        private void button1_Des_MouseLeave(object sender, EventArgs e)
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
