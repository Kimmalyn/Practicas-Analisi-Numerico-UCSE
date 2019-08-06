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
            int Funcion (string f,double lim)
            {
                int cont = 0;
                while (cont != f.Length)
                {
                    if (f[cont] == 'x' | f[cont] == 'X')
                    {
                        f[cont] = lim;
                    }
                }
                return 0;
            }

            double iter = Convert.ToDouble(text4.Text);
            double tole = Convert.ToDouble(text5.Text);
            double xi = Convert.ToDouble(text3.Text);
            double xd = Convert.ToDouble(text2.Text);
            string funcion = text1.Text;
            double errorrelativo = 0;
            int cont = 0;
            double xr = 0;
            bool band = false;
            while (Funcion(funcion, xi) * Funcion(funcion, xd) > 0)
            {
                MessageBox.Show("Ingrese los límites nuevamente.");
                text3.Clear();
                text2.Clear();
                text2.SelectAll();
            }
            while (cont < iter & band == false)
            {
                if (Funcion(funcion, xi) * Funcion(funcion, xd) == 0)
                {
                    if (Funcion(funcion, xi) == 0)
                    {
                        solucion.Text = xi.ToString();
                        band = true;
                        iteraciones.Text = cont.ToString();
                        erelativo.Text = errorrelativo.ToString();
                    }
                    else
                    {
                        solucion.Text = xd.ToString();
                        band = true;
                        iteraciones.Text = cont.ToString();
                        erelativo.Text = errorrelativo.ToString();
                    }
                }
                else
                {
                    double xant = 0;
                    xr = (xi + xd) / 2;
                    cont++;
                    errorrelativo = Math.Abs((xr - xant) / xr);
                    if (Math.Abs(Funcion(funcion,xr)) < tole | cont >= iter | errorrelativo < tole)
                    {
                        solucion.Text = xr.ToString();
                        band = true;
                        iteraciones.Text = cont.ToString();
                        erelativo.Text = errorrelativo.ToString();
                    }
                    else
                    {
                        if (Funcion(funcion, xi) * Funcion(funcion, xd) < 0)
                        {
                            xd = xr;
                        }
                        else
                        {
                            xi = xr;
                        }
                        xant = xr;
                    }
                }
            }
            
        }
    }
}
