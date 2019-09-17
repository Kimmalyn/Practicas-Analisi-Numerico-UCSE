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
    public partial class Matrices : Form
    {
        public Matrices()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            int max = 0;
            double[,] M = new double[5, 6];
            List<double> Resultados = new List<double>();
            List<TextBox> lista_txt = new List<TextBox>();
            double tole = 0.0001;
            switch (checkedListBox1.SelectedIndex)
            {
                case 0: //3x3
                    lista_txt.Add(m11); lista_txt.Add(m12); lista_txt.Add(m13); lista_txt.Add(r1);
                    lista_txt.Add(m21); lista_txt.Add(m22); lista_txt.Add(m23); lista_txt.Add(r2);
                    lista_txt.Add(m31); lista_txt.Add(m32); lista_txt.Add(m33); lista_txt.Add(r3);
                    max = 3;

                    break;
                case 1: //4x4
                    lista_txt.Add(m11); lista_txt.Add(m12); lista_txt.Add(m13); lista_txt.Add(m14); lista_txt.Add(r1);
                    lista_txt.Add(m21); lista_txt.Add(m22); lista_txt.Add(m23); lista_txt.Add(m24); lista_txt.Add(r2);
                    lista_txt.Add(m31); lista_txt.Add(m32); lista_txt.Add(m33); lista_txt.Add(m34); lista_txt.Add(r3);
                    lista_txt.Add(m41); lista_txt.Add(m42); lista_txt.Add(m43); lista_txt.Add(m44); lista_txt.Add(r4);
                    max = 4;
                    break;
                case 2: //5x5
                    lista_txt.Add(m11); lista_txt.Add(m12); lista_txt.Add(m13); lista_txt.Add(m14); lista_txt.Add(m15); lista_txt.Add(r1);
                    lista_txt.Add(m21); lista_txt.Add(m22); lista_txt.Add(m23); lista_txt.Add(m24); lista_txt.Add(m25); lista_txt.Add(r2);
                    lista_txt.Add(m31); lista_txt.Add(m32); lista_txt.Add(m33); lista_txt.Add(m34); lista_txt.Add(m35); lista_txt.Add(r3);
                    lista_txt.Add(m41); lista_txt.Add(m42); lista_txt.Add(m43); lista_txt.Add(m44); lista_txt.Add(m45); lista_txt.Add(r4);
                    lista_txt.Add(m51); lista_txt.Add(m52); lista_txt.Add(m53); lista_txt.Add(m54); lista_txt.Add(m55); lista_txt.Add(r5);
                    max = 5;
                    break;
                default:
                    break;
            }

            int i = 0; int j = 0; int k = 0;
            foreach (var item in lista_txt)
            {
                M[i, j] = double.Parse(item.Text);
                j++;
                if (j > max)
                {
                    j = 0;
                    i++;
                }
            }

            double coeficiente = 0;
            if (comboBox1.SelectedIndex == 0) //GAUSS-JORDAN
            {
                for (i = 0; i < max; i++)
                {
                    coeficiente = M[i, i];
                    for (j = 0; j <= max; j++)
                    {
                        M[i, j] = M[i, j] / coeficiente;
                    }
                    for (j = 0; j < max; j++)
                    {
                        if (i != j)
                        {
                            coeficiente = M[j, i];
                            for (k = 0; k <= max; k++)
                            {
                                M[j, k] = M[j, k] - (coeficiente * M[i, k]);
                            }
                        }
                    }
                }
                for (i = 0; i < max; i++)
                {
                    Resultados.Add(M[i, max]);
                }
                switch (Resultados.Count)
                {
                    case 3:
                        r1.Text = Resultados[0].ToString();
                        r2.Text = Resultados[1].ToString();
                        r3.Text = Resultados[2].ToString();
                        break;
                    case 4:
                        r1.Text = Resultados[0].ToString();
                        r2.Text = Resultados[1].ToString();
                        r3.Text = Resultados[2].ToString();
                        r4.Text = Resultados[3].ToString();
                        break;
                    case 5:
                        r1.Text = Resultados[0].ToString();
                        r2.Text = Resultados[1].ToString();
                        r3.Text = Resultados[2].ToString();
                        r4.Text = Resultados[3].ToString();
                        r5.Text = Resultados[4].ToString();
                        break;
                }
            }
            else //GAUSS-SEIDEL
            {
                double[] resultadosi = new double[4];
                double[] resultadosn = new double[4];
                double resultadoparcial = 0;
                bool band = false;
                for (i = 0; i<= max; i++)
                {
                    resultadosi[i] = 0;
                }
                resultadosn = resultadosi;
                int iter = 0;
                while (iter < 100 & band == false)
                {
                    for (i = 0; i < max; i++)
                    {
                        for (j = 0; j <= max; j++)
                        {
                            if (j == 0)
                            {
                                resultadoparcial = M[i, max];
                            }
                            if (j == max)
                            {
                                resultadoparcial = resultadoparcial / M[i, i];
                            }
                            else
                            {
                                if (i != j)
                                {
                                    resultadoparcial = resultadoparcial - (M[i, j] * resultadosn[j]);
                                }
                            }
                            
                        }
                        resultadosn[i] = resultadoparcial;
                    }
                    if ((resultadosn[0]-resultadosi[0]) <= tole && (resultadosn[1] - resultadosi[1]) <= tole && (resultadosn[2] - resultadosi[2]) <= tole && (resultadosn[3] - resultadosi[3]) <= tole && (resultadosn[4] - resultadosi[4]) <= tole)
                    {
                        band = true;
                    }
                    iter++;
                    resultadosi = resultadosn;
                }
                
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(1) == true) //Si es 4x4
            {
                m41.Visible = true; m42.Visible = true; m43.Visible = true; m44.Visible = true;
                m14.Visible = true; m24.Visible = true; m34.Visible = true;

                m51.Visible = false; m52.Visible = false; m53.Visible = false; m54.Visible = false; m55.Visible = false;
                m15.Visible = false; m25.Visible = false; m35.Visible = false; m45.Visible = false; m55.Visible = false;

            }
            else
            {
                if (checkedListBox1.GetItemChecked(2) == true) //Si es 5x5
                {
                    m41.Visible = true; m42.Visible = true; m43.Visible = true; m44.Visible = true;
                    m14.Visible = true; m24.Visible = true; m34.Visible = true;

                    m51.Visible = true; m52.Visible = true; m53.Visible = true; m54.Visible = true; m55.Visible = true;
                    m15.Visible = true; m25.Visible = true; m35.Visible = true; m45.Visible = true; m55.Visible = true;
                }
                else //Si es 3x3
                {
                    m41.Visible = false; m42.Visible = false; m43.Visible = false; m44.Visible = false;
                    m14.Visible = false; m24.Visible = false; m34.Visible = false;

                    m51.Visible = false; m52.Visible = false; m53.Visible = false; m54.Visible = false; m55.Visible = false;
                    m15.Visible = false; m25.Visible = false; m35.Visible = false; m45.Visible = false; m55.Visible = false;
                }
            }
        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= CheckedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
            }
        }

        private void R3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
