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
    public partial class Newton_Raphson : Form
    {
        public Newton_Raphson()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double Funcion(double x)
            {
                return 2 * (x * x) - 5;
            }

            double valorinicial = Convert.ToDouble(text3.Text);
            double iter = Convert.ToDouble(text4.Text);
            double tole = Convert.ToDouble(text5.Text);
            double xr = 0;
            int c = 0;
            double error = 1;
            if (Funcion(valorinicial) != 0)
            {
                double xant = 0;
                
                while (Math.Abs(Funcion(valorinicial)) > tole & c < iter & error > tole)
                {
                    double derivada = (Funcion(valorinicial + tole) - Funcion(valorinicial)) / tole;

                    xr = valorinicial - (Funcion(valorinicial) / derivada);

                    error = Math.Abs((xr - xant) / xr);

                    c = c + 1;
                    valorinicial = xr;
                    xant = xr;
                }
                if (c < iter)
                {
                    solucion.Text = xr.ToString();
                    iteraciones.Text = c.ToString();
                    erelativo.Text = error.ToString();
                }
                else
                {
                    MessageBox.Show("La funcion es divergente.");
                }
            }
            else
            {
                solucion.Text = valorinicial.ToString();
                iteraciones.Text = c.ToString();
                erelativo.Text = error.ToString();
            }

            

        }
    }
}
