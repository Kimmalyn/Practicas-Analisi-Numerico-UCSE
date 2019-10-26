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
            //Modifica la visibilidad de los labels
            {
                label0.Visible = false;
                a0.Visible = false;
                label1.Visible = false;
                a1.Visible = false;
                label2.Visible = false;
                a2.Visible = false;
                label3.Visible = false;
                a3.Visible = false;
                label4.Visible = false;
                a4.Visible = false;
                label5.Visible = false;
                a5.Visible = false;
                label6.Visible = false;
                a6.Visible = false;
                label7.Visible = false;
                a7.Visible = false;
                label8.Visible = false;
                a8.Visible = false;
                label9.Visible = false;
                a9.Visible = false;
                label10.Visible = false;
                a10.Visible = false;
            }
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

            if (checkedListBox1.GetItemChecked(0) == true) //REGRESION LINEAL
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
                    NAjuste.Text = " No Aceptable " + r.ToString();
            }
            else
            {
                if (checkedListBox1.GetItemChecked(1) == true) //REGRESION POLINOMIAL
                {
                    Pendiente.Visible = false;
                    Ordenada.Visible = false;

                    //GRADO
                    int grado = int.Parse(textBox3.Text);

                    double[,] matrix = new double[grado + 1, grado + 2];
                    ex = 0;
                    ey = 0;

                    //CICLO INICIALIZA LA MATRIZ EN 0
                    for (int i = 0; i <= grado; i++)
                    {
                        for (int j = 0; j <= grado + 1; j++)
                        {
                            matrix[i, j] = 0;
                        }
                    }

                    for (int i = 0; i <= n - 1; i++)
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

                    //RESULTADOS
                    List<double> Resultados = new List<double>();
                    double coeficiente = 0;
                    int a = 0;
                    int b = 0;
                    int d = 0;
                    for (a = 0; a < grado + 1; a++)
                    {
                        coeficiente = matrix[a, a];
                        for (b = 0; b <= grado + 1; b++)
                        {
                            matrix[a, b] = matrix[a, b] / coeficiente;
                        }
                        for (b = 0; b < grado + 1; b++)
                        {
                            if (a != b)
                            {
                                coeficiente = matrix[b, a];
                                for (d = 0; d <= grado + 1; d++)
                                {
                                    matrix[b, d] = matrix[b, d] - (coeficiente * matrix[a, d]);
                                }
                            }
                        }
                    }

                    //VERIFICACION DE AJUSTE R
                    double ST = 0;
                    double SR = 0;
                    double S = 0;
                    for (int i = 0; i < n; i++)
                    {
                        ST = ST + Math.Pow((media_y - puntosy[i]), 2);
                        S = 0;
                        for (int j = 0; j <= grado; j++)
                        {
                            S = S + (matrix[j, grado + 1] * (Math.Pow(puntosx[i], j)));
                        }
                        SR = SR + (Math.Pow(S - puntosy[i], 2));
                    }
                    if (ST != 0)
                    {
                        for (a = 0; a < grado + 1; a++)
                        {
                            Resultados.Add(matrix[a, grado + 1]);
                        }
                        int ultimo = Resultados.Count() - 1;
                        switch (Resultados.Count - 1)
                        {
                            case 1:

                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[0].ToString();
                                break;
                            case 2:
                                label0.Visible = true;
                                a0.Visible = true;
                                label1.Visible = true;
                                a1.Visible = true;
                                label2.Visible = true;
                                a2.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                a1.Text = Resultados[1].ToString();
                                a2.Text = Resultados[0].ToString();
                                break;
                            case 3:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[2].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[1].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[0].ToString();
                                break;
                            case 4:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[3].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[2].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[1].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[0].ToString();
                                break;
                            case 5:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[4].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[3].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[2].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[1].ToString();
                                label5.Visible = true;
                                a5.Visible = true;
                                a5.Text = Resultados[0].ToString();
                                break;
                            case 6:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[5].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[4].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[3].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[2].ToString();
                                label5.Visible = true;
                                a5.Visible = true;
                                a5.Text = Resultados[1].ToString();
                                label6.Visible = true;
                                a6.Visible = true;
                                a6.Text = Resultados[0].ToString();
                                break;
                            case 7:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[6].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[5].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[4].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[3].ToString();
                                label5.Visible = true;
                                a5.Visible = true;
                                a5.Text = Resultados[2].ToString();
                                label6.Visible = true;
                                a6.Visible = true;
                                a6.Text = Resultados[1].ToString();
                                label7.Visible = true;
                                a7.Visible = true;
                                a7.Text = Resultados[0].ToString();
                                break;
                            case 8:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[7].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[6].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[5].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[4].ToString();
                                label5.Visible = true;
                                a5.Visible = true;
                                a5.Text = Resultados[3].ToString();
                                label6.Visible = true;
                                a6.Visible = true;
                                a6.Text = Resultados[2].ToString();
                                label7.Visible = true;
                                a7.Visible = true;
                                a7.Text = Resultados[1].ToString();
                                label8.Visible = true;
                                a8.Visible = true;
                                a8.Text = Resultados[0].ToString();
                                break;
                            case 9:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[8].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[7].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[6].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[5].ToString();
                                label5.Visible = true;
                                a5.Visible = true;
                                a5.Text = Resultados[4].ToString();
                                label6.Visible = true;
                                a6.Visible = true;
                                a6.Text = Resultados[3].ToString();
                                label7.Visible = true;
                                a7.Visible = true;
                                a7.Text = Resultados[2].ToString();
                                label8.Visible = true;
                                a8.Visible = true;
                                a8.Text = Resultados[1].ToString();
                                label9.Visible = true;
                                a9.Visible = true;
                                a9.Text = Resultados[0].ToString();
                                break;
                            case 10:
                                label0.Visible = true;
                                a0.Visible = true;
                                a0.Text = Resultados[ultimo].ToString();
                                label1.Visible = true;
                                a1.Visible = true;
                                a1.Text = Resultados[9].ToString();
                                label2.Visible = true;
                                a2.Visible = true;
                                a2.Text = Resultados[8].ToString();
                                label3.Visible = true;
                                a3.Visible = true;
                                a3.Text = Resultados[7].ToString();
                                label4.Visible = true;
                                a4.Visible = true;
                                a4.Text = Resultados[6].ToString();
                                label5.Visible = true;
                                a5.Visible = true;
                                a5.Text = Resultados[5].ToString();
                                label6.Visible = true;
                                a6.Visible = true;
                                a6.Text = Resultados[4].ToString();
                                label7.Visible = true;
                                a7.Visible = true;
                                a7.Text = Resultados[3].ToString();
                                label8.Visible = true;
                                a8.Visible = true;
                                a8.Text = Resultados[2].ToString();
                                label9.Visible = true;
                                a9.Visible = true;
                                a9.Text = Resultados[1].ToString();
                                label10.Visible = true;
                                a10.Visible = true;
                                a10.Text = Resultados[0].ToString();
                                break;
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
                        NAjuste.Text = "Error: Division por cero.";
                    }
                }
                else //LAGRANGE
                {
                    int i = 0;
                    double S = 0;
                    double Sa = 0;
                    double Sb = 0;

                    //GRADO
                    int grado = int.Parse(textBox3.Text);

                    while (i <= grado-1)
                    {

                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            puntosx.Clear();
            puntosy.Clear();

            a0.Text = "";
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";
            a6.Text = "";
            a7.Text = "";
            a8.Text = "";
            a9.Text = "";
            a10.Text = "";
            label0.Visible = false;
            a0.Visible = false;
            label1.Visible = false;
            a1.Visible = false;
            label2.Visible = false;
            a2.Visible = false;
            label3.Visible = false;
            a3.Visible = false;
            label4.Visible = false;
            a4.Visible = false;
            label5.Visible = false;
            a5.Visible = false;
            label6.Visible = false;
            a6.Visible = false;
            label7.Visible = false;
            a7.Visible = false;
            label8.Visible = false;
            a8.Visible = false;
            label9.Visible = false;
            a9.Visible = false;
            label10.Visible = false;
            a10.Visible = false;
            Pendiente.Visible = false;
            Ordenada.Visible = false;

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }

            if (checkedListBox1.SelectedIndex == 0) //Muestra los labels de Lineal
            {
                Pendiente.Visible = true;
                Ordenada.Visible = true;
                NPendiente.Visible = true;
                NOrdenada.Visible = true;
            }
            else
            {
                if (checkedListBox1.SelectedIndex == 1) //Oculta los labels de Lineal
                {
                    Pendiente.Visible = false;
                    Ordenada.Visible = false;
                    NPendiente.Visible = false;
                    NOrdenada.Visible = false;
                }
            }
        }
    }
}
