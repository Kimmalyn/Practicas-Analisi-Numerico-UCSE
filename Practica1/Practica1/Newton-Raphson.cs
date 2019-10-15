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
<<<<<<< HEAD
                return ((10 * x + 20) / ((x * x) + 4 * x + 5)) + 2;
                //Math.Abs((x * x) - 4) + 2 * x;
                //EJERCICIO 2 Math.Log(x)+(1/x)-3;
            } 
=======
                return ((10 * x + 20) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            }
>>>>>>> 910929d6e8796240642aaf2264bd90a20491452f

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
                    double funcionenvalorini = Math.Abs(Funcion(valorinicial));
                }
                if (c < iter)
                {
                    if (double.IsNaN(Funcion(valorinicial)))
                    {
                        MessageBox.Show("En este punto la Funcion es divergente.");
                    }
                    else
                    {
                        solucion.Text = xr.ToString();
                        iteraciones.Text = c.ToString();
                        erelativo.Text = Convert.ToDecimal(error).ToString();
                    }
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
                erelativo.Text = Convert.ToDecimal(error).ToString();
            }

            

        }

        private void Solucion_Click(object sender, EventArgs e)
        {

        }
    }
}
