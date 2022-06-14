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
    public partial class Interfaz_Admin_Agregar_Vehiculo : Form
    {
        public Interfaz_Admin_Agregar_Vehiculo()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;

            listBox1.Items.Add("Toyota");
            listBox1.Items.Add("Nisan");
            listBox1.Items.Add("Chevrolet");

            listBox2.Items.Add("Tipo 1");
            listBox2.Items.Add("Tipo 2");
            listBox2.Items.Add("Tipo 3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calidad;

            if (radioButton1.Checked == true)
            {
                calidad = "NO USADO";   
            }
            else
            {
                calidad = "SI USADO";
            }
            MessageBox.Show("Se agregó un vehículo " + listBox1.Text.ToString() + " del año " + dateTimePicker1.Text.ToString() + " en la consesionaria con la condición de " + calidad + " y con un motor " + listBox2.Text + ".", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaz_Administrador a = new Interfaz_Administrador();

            this.Hide();
            a.ShowDialog();
        }
    }
}
