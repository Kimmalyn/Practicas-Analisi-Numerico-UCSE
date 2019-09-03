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

        private void newtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularionewtonraphson = new Newton_Raphson();
            formularionewtonraphson.Owner = this;
            formularionewtonraphson.Show();
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariosecante = new Secante();
            formulariosecante.Owner = this;
            formulariosecante.Show();
        }

        private void MatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariomatrices = new Matrices();
            formulariomatrices.Owner = this;
            formulariomatrices.Show();
        }
    }
}
