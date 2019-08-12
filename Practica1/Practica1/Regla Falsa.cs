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
        public ReglaFalsa()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal Funcion(decimal x)
            {
                decimal fraccion = 1 / 16;
                return (fraccion * (x * x)) - 1;
            }
            decimal xi = Convert.ToDecimal(text3.Text);
            decimal xd = Convert.ToDecimal(text2.Text);
            decimal funcionenxi = Funcion(xi);
            decimal funcionenxd = Funcion(xd);
            if (Funcion(xd) * Funcion(xi) <= 0)
            {
                decimal iter = Convert.ToDecimal(text4.Text);
                decimal tole = Convert.ToDecimal(text5.Text);
                decimal errorrelativo = 0;
                int cont = 0;
                decimal xr = 0;
                decimal xant = 0;
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
                        decimal funcionenxr = Math.Abs(Funcion(xr));
                        if (funcionenxr < tole | cont >= iter | errorrelativo < tole)
                        {
                            solucion.Text = xr.ToString();
                            band = true;
                            iteraciones.Text = cont.ToString();
                            erelativo.Text = errorrelativo.ToString();
                        }
                        else
                        {
                            if (Math.Abs(Funcion(xi)) > Math.Abs(Funcion(xd)))
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
