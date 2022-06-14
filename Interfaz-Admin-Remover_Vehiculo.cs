using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class Interfaz_Admin_Remover_Vehiculo : Form
    {
        public Interfaz_Admin_Remover_Vehiculo()
        {
            InitializeComponent();
            listBox1.Items.Add("Nton");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El vehiculo " + listBox1.Text + " fue removido de la consecionaria", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Remove(listBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaz_Administrador a = new Interfaz_Administrador();

            this.Hide();
            a.ShowDialog();
        }
    }
}
