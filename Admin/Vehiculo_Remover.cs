﻿using System;
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
    public partial class Vehiculo_Remover : Form
    {
        public Vehiculo_Remover()
        {
            InitializeComponent();
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
    }
}
