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
    public partial class Secante : Form
    {
        public Secante()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double Funcion(double x)
            {
                return (2 * (x * x)) - 5;
            }
            double valorinicial1 = Convert.ToDouble(text1.Text);
            double valorinicial2 = Convert.ToDouble(text3.Text);
            double iter = Convert.ToDouble(text4.Text);
            double tole = Convert.ToDouble(text5.Text);
            double xr = 0;
            int c = 1;
            double error = 1;
            if (Funcion(valorinicial2) != 0 & Funcion(valorinicial1) != 0)
            {
                xr = ((Funcion(valorinicial2) * valorinicial1) - (Funcion(valorinicial1) * valorinicial2)) / (Funcion(valorinicial2) - Funcion(valorinicial1));
               
                valorinicial1 = valorinicial2;
                valorinicial2 = xr;
                error = Math.Abs(valorinicial2 - valorinicial1) / valorinicial2;

                while (Math.Abs(Funcion(valorinicial2)) > tole & c < iter & error > tole)
                {
                    c = c + 1;
                    xr = ((Funcion(valorinicial2) * valorinicial1) - (Funcion(valorinicial1) * valorinicial2)) / (Funcion(valorinicial2) - Funcion(valorinicial1));
                    
                    valorinicial1 = valorinicial2;
                    valorinicial2 = xr;
                    error = Math.Abs(valorinicial2 - valorinicial1) / valorinicial2;
                    double dddd = Math.Abs(Funcion(xr));
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
                if (Funcion(valorinicial2) == 0)
                {
                    solucion.Text = valorinicial2.ToString();
                    iteraciones.Text = c.ToString();
                    erelativo.Text = error.ToString();
                }
                else
                {
                    solucion.Text = valorinicial1.ToString();
                    iteraciones.Text = c.ToString();
                    erelativo.Text = error.ToString();
                }
                
            }
        }
    }
}
