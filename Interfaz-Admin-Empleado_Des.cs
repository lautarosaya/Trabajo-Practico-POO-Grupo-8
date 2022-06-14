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
    public partial class Interfaz_Admin_Empleado_Des : Form
    {
        public Interfaz_Admin_Empleado_Des()
        {
            InitializeComponent();
            listBox1.Items.Add("Newton");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado " + listBox1.Text.ToString() + " fue despedido.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Remove(listBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaz_Administrador a = new Interfaz_Administrador();

            this.Hide();
            a.ShowDialog();
        }

        public string Poner_nombre(string nombre, string apellido)
        {
            string nom = nombre;
            string ape = apellido;

            string agregar = nom + " " + ape;

            return listBox1.Items.Add(agregar).ToString();
        }
    }
}
