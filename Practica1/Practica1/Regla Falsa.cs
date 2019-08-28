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
    public partial class ReglaFalsa : Form
    {
        private const double fraccion = (1/16);

        public ReglaFalsa()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double Funcion(double x)
            {
                //double fraccion = ReglaFalsa.fraccion;
                //EJERCICIO 1 // return (x * x * x * x * x - 1) * Math.Pow(2.71828, x) - 10;
                                return (x * x * x * x * x - 1) * Math.Pow(2.71828, x) - 10;
                // EJERCICIO 3 ((12.5 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            }
            double xi = Convert.ToDouble(text3.Text);
            double xd = Convert.ToDouble(text2.Text);
            double funcionenxi = Funcion(xi);
            double funcionenxd = Funcion(xd);
            if (Funcion(xd) * Funcion(xi) <= 0)
            {
                double iter = Convert.ToDouble(text4.Text);
                double tole = Convert.ToDouble(text5.Text);
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
                        xr = ((Funcion(xi) * xd) - (Funcion(xd) * xi)) / (Funcion(xi) - Funcion(xd));
                        cont++;
                        errorrelativo = Math.Abs((xr - xant) / xr);
                        double funcionenxr = Math.Abs(Funcion(xr));
                        if (funcionenxr < tole | cont >= iter | errorrelativo < tole)
                        {
                            solucion.Text = xr.ToString();
                            band = true;
                            iteraciones.Text = cont.ToString();
                            erelativo.Text = errorrelativo.ToString();
                        }
                        else
                        {
                            if (Math.Abs(Funcion(xi)) > Math.Abs(Funcion(xr)))
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
