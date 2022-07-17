﻿using System;
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
    public partial class InterfazC : Form
    {
        public InterfazC()
        {
            InitializeComponent();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Form catalogo=new Cliente.Catalogo();
            catalogo.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Form facturas = new Cliente.Factura();
            facturas.ShowDialog();
        }
    }
}
