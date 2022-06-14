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
    public partial class Interfaz_Admin_Empleado_Con : Form
    {
        public Interfaz_Admin_Empleado_Con()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interfaz_Admin_Empleado_Des a = new Interfaz_Admin_Empleado_Des();

            //Descomentando esto y comentando lo que no esta comentado es posible pasar la informacion al otro formulario al momento que lo agreaga a la organizacion. Capaz logremos implementar esto cuando sepamos como manipular la base de datos

            //a.Poner_nombre(textBox1.Text, textBox2.Text);
            //a.Show;

            MessageBox.Show("La persona " + textBox1.Text + " " + textBox2.Text + " fue contratada como empleado", "INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaz_Administrador b = new Interfaz_Administrador();

            this.Hide();
            b.ShowDialog();
            //b.Show();
        }
    }
}
