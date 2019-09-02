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
            double Funcion (double x)
            {
                return (x * x * x * x * x - 1) * Math.Pow(2.71828, x) - 10;
                //EJERCICIO 3 ((12.5*(x+2))/(Math.Pow(x,2)+4*x+5))+2;
                //PUNTO1// return (x*x*x*x*x - 1) * Math.Pow(2.71828,x) - 10;
                //                return (Math.Pow(x, 5) - 1) * Math.Exp(x) - 10;

            }
            if (Funcion(Convert.ToDouble(text3.Text)) * Funcion(Convert.ToDouble(text2.Text)) <= 0)
            {
                double iter = Convert.ToDouble(text4.Text);
                double tole = Convert.ToDouble(text5.Text);
                double xi = Convert.ToDouble(text3.Text);
                double xd = Convert.ToDouble(text2.Text);
                double errorrelativo = 0;
                int cont = 0;
                double xr = 0;
                double xant = 0;
                bool band = false;
                while (cont < iter & band == false)
                {
                    if (Funcion(xi) * Funcion(xd) == 0)
                    {
                        if (Funcion(xi) == 0)
                        {
                            solucion.Text = xi.ToString();
                            band = true;
                            iteraciones.Text = cont.ToString();
                            erelativo.Text = Convert.ToDecimal(errorrelativo).ToString();
                        }
                        else
                        {
                            solucion.Text = xd.ToString();
                            band = true;
                            iteraciones.Text = cont.ToString();
                            erelativo.Text = Convert.ToDecimal(errorrelativo).ToString();
                        }
                    }
                    else
                    {
                        xr = (xi + xd) / 2;
                        cont++;
                        errorrelativo = Math.Abs((xr - xant) / xr);
                        double funcionenxr = Math.Abs(Funcion(xr));
                        if (funcionenxr < tole | cont >= iter | errorrelativo < tole)
                        {
                            solucion.Text = xr.ToString();
                            band = true;
                            iteraciones.Text = cont.ToString();
                            erelativo.Text = Convert.ToDecimal(errorrelativo).ToString();
                        }
                        else
                        {
                            if (Funcion(xi) * Funcion(xr) < 0)
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
            else
            {
                MessageBox.Show("Ingrese los límites nuevamente.");
                text3.Clear();
                text2.Clear();
                text2.SelectAll();
            }
        }
    }
}
