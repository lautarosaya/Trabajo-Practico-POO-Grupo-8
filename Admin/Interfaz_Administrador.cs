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
        private void Boton_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
        }

        private void Boton_Comprar_Click(object sender, EventArgs e)
        {
            vista.Admin.Vechiculo_Comprar log = new vista.Admin.Vechiculo_Comprar();
            this.Hide();
            log.ShowDialog();
        }

        private void Boton_Vender_Click(object sender, EventArgs e)
        {
            vista.Admin.Vehiculo_Vender log = new vista.Admin.Vehiculo_Vender();
            this.Hide();
            log.ShowDialog();
        }

        private void Personal_Despedir_Click(object sender, EventArgs e)
        {
            vista.Admin.Empleado_Despedir log = new vista.Admin.Empleado_Despedir();
            this.Hide();
            log.ShowDialog();        }

        private void Personal_Contratar_Click(object sender, EventArgs e)
        {
            vista.Admin.Empleado_Contratar log = new vista.Admin.Empleado_Contratar();
            this.Hide();
            log.ShowDialog();
        }

        private void Catalogo_Extender_Click(object sender, EventArgs e)
        {

        }

        private void Catalogo_Recortar_Click(object sender, EventArgs e)
        {

        }

        private void Vehiculo_Remover_Click(object sender, EventArgs e)
        {
            vista.Admin.Vehiculo_Remover log = new vista.Admin.Vehiculo_Remover();
            this.Hide();
            log.ShowDialog();
        }

        private void Personal_Modificar_Click(object sender, EventArgs e)
        {
            vista.Admin.Modificar_info_Empleado log = new vista.Admin.Modificar_info_Empleado();
            this.Hide();
            log.ShowDialog();
        }

        private void Permisos_Modificar_Click(object sender, EventArgs e)
        {
            vista.Admin.Modificar_permiso log = new vista.Admin.Modificar_permiso();
            this.Hide();
            log.ShowDialog();
        }

        private void Boton_Cerrar_Sesion_MouseEnter(object sender, EventArgs e)
        {
            Boton_Cerrar_Sesion.ForeColor = Color.White;
        }

        private void Boton_Comprar_MouseEnter(object sender, EventArgs e)
        {
            Boton_Comprar.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Boton_Vender_MouseEnter(object sender, EventArgs e)
        {
            Boton_Vender.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Personal_Despedir_MouseEnter(object sender, EventArgs e)
        {
            Personal_Despedir.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Personal_Contratar_MouseEnter(object sender, EventArgs e)
        {
            Personal_Contratar.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Catalogo_Extender_MouseEnter(object sender, EventArgs e)
        {
            Catalogo_Extender.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Catalogo_Recortar_MouseEnter(object sender, EventArgs e)
        {
            Catalogo_Recortar.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Vehiculo_Remover_MouseEnter(object sender, EventArgs e)
        {
            Vehiculo_Remover.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Personal_Modificar_MouseEnter(object sender, EventArgs e)
        {
            Personal_Modificar.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Permisos_Modificar_MouseEnter(object sender, EventArgs e)
        {
            Permisos_Modificar.ForeColor = Color.FromArgb(24, 132, 108);
        }

        private void Boton_Cerrar_Sesion_MouseLeave(object sender, EventArgs e)
        {
            Boton_Cerrar_Sesion.ForeColor = Color.DimGray;
        }

        private void Boton_Comprar_MouseLeave(object sender, EventArgs e)
        {
            Boton_Comprar.ForeColor = Color.White;
        }

        private void Boton_Vender_MouseLeave(object sender, EventArgs e)
        {
            Boton_Vender.ForeColor = Color.White;
        }

        private void Personal_Despedir_MouseLeave(object sender, EventArgs e)
        {
            Personal_Despedir.ForeColor = Color.White;
        }

        private void Personal_Contratar_MouseLeave(object sender, EventArgs e)
        {
            Personal_Contratar.ForeColor = Color.White;
        }

        private void Catalogo_Extender_MouseLeave(object sender, EventArgs e)
        {
           Catalogo_Extender.ForeColor = Color.White;
        }

        private void Catalogo_Recortar_MouseLeave(object sender, EventArgs e)
        {
           Catalogo_Recortar.ForeColor = Color.White;
        }

        private void Vehiculo_Remover_MouseLeave(object sender, EventArgs e)
        {
           Vehiculo_Remover.ForeColor = Color.White;
        }

        private void Personal_Modificar_MouseLeave(object sender, EventArgs e)
        {
           Personal_Modificar.ForeColor = Color.White;
        }

        private void Permisos_Modificar_MouseLeave(object sender, EventArgs e)
        {
           Permisos_Modificar.ForeColor = Color.White;
        }        
    }
}
