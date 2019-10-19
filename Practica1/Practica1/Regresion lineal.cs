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
        int n = 0;
        //Ex
        double ex = 0;
        //Ey
        double ey = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            puntosx.Add(double.Parse(textBox1.Text));
            puntosy.Add(double.Parse(textBox2.Text));

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //N
            n = puntosx.Count;

            //SUMATORIA X.Y
            int c = 0;
            foreach (double item in puntosx)
            {
                exy = item * puntosy[c];
                c++;
            }

            //Ex
            ex = puntosx.Sum();

            //Ey
            ey = puntosy.Sum();

            //Ex^2
            double ex2 = 0;
            foreach (double item in puntosx)
            {
                ex2 = ex2 + Math.Pow(item, 2);
            }

            //(Ex)^2
            double ex2b = 0;
            ex2b = Math.Pow(ex, 2);

            //double a1 = (puntosx.Count * ());

           if (comboBox1.SelectedIndex == 0)
           {
            
           }
           else
           {
                int grado = int.Parse(textBox3.Text);
                double[,] matrix;
                matrix = new double[grado-1,grado];
                ex = 0;
                ey = 0;
                
                for (int i = 0; i < n-1; i++)
                {
                    ex += puntosx[i];
                    ey += puntosy[i];
                    for (int j = 0; j < grado; j++)
                    {
                        for (int k = 0; k < grado; k++)
                        {
                            matrix[j, k] += Math.Pow(puntosx[i], j + k);
                        }
                        matrix[j, grado + 1] += puntosy[i] * Math.Pow(puntosx[i], j);
                    }
                }

                List<double> Resultados = new List<double>();
                double coeficiente = 0;
                int a = 0;
                int b = 0;
                int d = 0;
                for (a = 0; a < grado+1; a++)
                {
                    coeficiente = matrix[a, a];
                    for (b = 0; b <= grado+1; b++)
                    {
                        matrix[a, b] = matrix[a, b] / coeficiente;
                    }
                    for (b = 0; b < grado+1; b++)
                    {
                        if (a != b)
                        {4
                            coeficiente = matrix[b, a];
                            for (d = 0; d <= grado+1; d++)
                            {
                                matrix[b, d] = matrix[b, d] - (coeficiente * matrix[a, d]);
                            }
                        }
                    }
                }
                for (a = 0; a < grado+1; a++)
                {
                    Resultados.Add(matrix[a, grado+1]);
                }
           }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
