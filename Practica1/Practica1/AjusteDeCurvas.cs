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
    public partial class AjusteDeCurvas : Form
    {
        public AjusteDeCurvas()
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

            //SUMATORIA x
            ex = puntosx.Sum();

            //SUMATORIA y
            ey = puntosy.Sum();

            //SUMATORIA x^2
            double ex2 = 0;
            foreach (double item in puntosx)
            {
                ex2 = ex2 + Math.Pow(item, 2);
            }

            //(SUMATORIA x)^2
            double ex2b = 0;
            ex2b = Math.Pow(ex, 2);

            //MEDIA DE Y
            double media_y = puntosy.Average();

            //MEDIA DE X
            double media_x = puntosx.Average();

           if (comboBox1.SelectedIndex == 0)
           {
                Pendiente.Visible = true;
                Ordenada.Visible = true;

                double a1 = (n * exy - ex * ey) / (n * ex2 - ex2b); //PENDIENTE
                double a0 = media_y - a1 * media_x; //ORDENADA AL ORIGEN

                NPendiente.Text = a1.ToString(); //PENDIENTE
                NOrdenada.Text = a0.ToString(); //ORDENADA

                //ST
                double ST = 0;
                foreach (double item in puntosy)
                {
                    ST = ST + Math.Pow((media_y - item), 2);
                }

                //SR
                double SR = 0;
                int d = 0;
                foreach (double item in puntosx)
                {
                    SR = SR + Math.Pow((a1 * item) + a0 - puntosy[d], 2);
                    d++;
                }

                double r = 0;
                r = Math.Sqrt((ST - SR) / ST) * 100;

                if (r > 80)
                    NAjuste.Text = "Aceptable " + r.ToString();
                else
                    NAjuste.Text = " No Aceptable " + r.ToString(); ;


            }
           else
           {
                Pendiente.Visible = false;
                Ordenada.Visible = false;

                int grado = int.Parse(textBox3.Text);
                switch (grado)
                {
                    case 1:

                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        break;
                    case 2:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        break;
                    case 3:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        break;
                    case 4:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        break;
                    case 5:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        break;
                    case 6:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        break;
                    case 7:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        break;
                    case 8:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        label8.Visible = true;
                        a8.Visible = true;
                        break;
                    case 9:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        label8.Visible = true;
                        a8.Visible = true;
                        label9.Visible = true;
                        a9.Visible = true;
                        break;
                    case 10:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        label8.Visible = true;
                        a8.Visible = true;
                        label9.Visible = true;
                        a9.Visible = true;
                        label10.Visible = true;
                        a10.Visible = true;
                        break;
                }
                double[,] matrix = new double[grado+1, grado+2];
                ex = 0;
                ey = 0;

                for (int i = 0; i <= grado; i++)
                {
                    for (int j = 0; j <= grado+1; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }

                for (int i = 0; i < n-1; i++)
                {
                    ex += puntosx[i];
                    ey += puntosy[i];
                    for (int j = 0; j <= grado; j++)
                    {
                        for (int k = 0; k <= grado; k++)
                        {
                            matrix[j, k] += Math.Pow(puntosx[i], j + k);
                        }
                        matrix[j, grado + 1] = matrix[j, grado + 1] + (puntosy[i] * Math.Pow(puntosx[i], j));
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
                        {
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
                switch (Resultados.Count)
                {
                    case 1:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;

                        break;
                    case 2:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        break;
                    case 3:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        break;
                    case 4:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        break;
                    case 5:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        break;
                    case 6:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        break;
                    case 7:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        break;
                    case 8:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        label8.Visible = true;
                        a8.Visible = true;
                        break;
                    case 9:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        label8.Visible = true;
                        a8.Visible = true;
                        label9.Visible = true;
                        a9.Visible = true;
                        break;
                    case 10:
                        label0.Visible = true;
                        a0.Visible = true;
                        label1.Visible = true;
                        a1.Visible = true;
                        label2.Visible = true;
                        a2.Visible = true;
                        label3.Visible = true;
                        a3.Visible = true;
                        label4.Visible = true;
                        a4.Visible = true;
                        label5.Visible = true;
                        a5.Visible = true;
                        label6.Visible = true;
                        a6.Visible = true;
                        label7.Visible = true;
                        a7.Visible = true;
                        label8.Visible = true;
                        a8.Visible = true;
                        label9.Visible = true;
                        a9.Visible = true;
                        label10.Visible = true;
                        a10.Visible = true;
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Pendiente.Visible = true;
                Ordenada.Visible = true;
                NPendiente.Visible = true;
                NOrdenada.Visible = true;
            }
        }
    }
}
