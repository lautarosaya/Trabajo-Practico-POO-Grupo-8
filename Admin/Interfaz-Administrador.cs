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
    public partial class Interfaz_Administrador : Form
    {
        public Interfaz_Administrador()
        {
            InitializeComponent();
        }

        private void Interfaz_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void Purchase_Button_Click(object sender, EventArgs e)
        {
            Interfaz_Admin_Agregar_Vehiculo a = new Interfaz_Admin_Agregar_Vehiculo();

            this.Hide();
            a.ShowDialog();
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Interfaz_Admin_Empleado_Con b =new Interfaz_Admin_Empleado_Con();
            this.Hide();
            b.ShowDialog();
        }

        private void Kick_Employee_Click(object sender, EventArgs e)
        {
            Interfaz_Admin_Empleado_Des c =new Interfaz_Admin_Empleado_Des();

            this.Hide();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaz_Admin_Remover_Vehiculo d = new Interfaz_Admin_Remover_Vehiculo();
            this.Hide();
            d.ShowDialog();
        }
    }
}
