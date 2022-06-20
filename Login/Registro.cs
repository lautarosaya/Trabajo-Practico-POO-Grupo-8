using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista.Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void pctBackRE_MouseHover(object sender, EventArgs e)
        {
            pctBackRE.Image = vista.Properties.Resources.backbrightness;
        }

        private void pctBackRE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBackRE_MouseLeave(object sender, EventArgs e)
        {
            pctBackRE.Image = vista.Properties.Resources.image_removebg_preview;
        }
    }
}
