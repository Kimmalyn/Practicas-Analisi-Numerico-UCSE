using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void bissecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariobisseccion = new Biseccion();
            formulariobisseccion.Owner = this;
            formulariobisseccion.Show();
        }

        private void reglasFalsasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioreglafalsa = new ReglaFalsa();
            formularioreglafalsa.Owner = this;
            formularioreglafalsa.Show();
        }
    }
}
