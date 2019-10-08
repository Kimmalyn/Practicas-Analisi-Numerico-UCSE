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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        List<double> puntosx = new List<double>();
        List<double> puntosy = new List<double>();
        double exy = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            puntosx.Add(double.Parse(textBox1.Text));
            puntosy.Add(double.Parse(textBox2.Text));

            textBox1.Text = "";
            textBox2.Text = "";

            //N
            int n = puntosx.Count;

            //SUMATORIA X.Y
            int c = 0;
            foreach (double item in puntosx)
            {
                exy = item * puntosy[c];
                c++;
            }

            //Ex
            double ex = puntosx.Sum();

            //Ey
            double ey = puntosy.Sum();

            //Ex^2
            double ex2 = 0;
            foreach (double item in puntosx)
            {
                ex2 = ex2 + Math.Pow(item, 2);
            }

            //(Ex)^2
            double ex2b = 0;
            ex2b = Math.Pow(ex, 2);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double a1 = (puntosx.Count * ())
        }
    }
}
