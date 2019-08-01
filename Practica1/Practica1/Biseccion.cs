using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            public int Funcion (string f, int lim)
            {
                int cont = 0;
                while (cont != f.Length)
                {
                    if (f[cont] == 'x' | f[cont] == 'X')
                    {
                        f[cont] = lim;
                    }
                }
            }

        }
    }
}
