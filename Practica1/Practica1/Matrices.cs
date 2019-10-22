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

            //List<double> lista_txt = new List<double>();

            double tole = 0.0001; //0.0001
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
                    //TEST EJ.5 GAUSS-JORDAN
                    //lista_txt.Add(1); lista_txt.Add(1); lista_txt.Add(5); lista_txt.Add(0); lista_txt.Add(0); lista_txt.Add(0); //2
                    //lista_txt.Add(2); lista_txt.Add(-0.5); lista_txt.Add(0); lista_txt.Add(-1); lista_txt.Add(0); lista_txt.Add(20); //3
                    //lista_txt.Add(0); lista_txt.Add(-1); lista_txt.Add(0.25); lista_txt.Add(-0.2); lista_txt.Add(-0.2); lista_txt.Add(17); //4
                    //lista_txt.Add(0.5); lista_txt.Add(0); lista_txt.Add(0.25); lista_txt.Add(-1); lista_txt.Add(0); lista_txt.Add(0); //5
                    //lista_txt.Add(0); lista_txt.Add(1); lista_txt.Add(-1); lista_txt.Add(0); lista_txt.Add(4); lista_txt.Add(0); //1


                    //TEST EJ.5 GAUSS-SEIDEL
                    //lista_txt.Add(2); lista_txt.Add(-0.5); lista_txt.Add(0); lista_txt.Add(-1); lista_txt.Add(0); lista_txt.Add(20); //3
                    //lista_txt.Add(0); lista_txt.Add(-1); lista_txt.Add(0.25); lista_txt.Add(-0.2); lista_txt.Add(-0.2); lista_txt.Add(17); //4
                    //lista_txt.Add(1); lista_txt.Add(1); lista_txt.Add(5); lista_txt.Add(0); lista_txt.Add(0); lista_txt.Add(0); //2
                    //lista_txt.Add(0.5); lista_txt.Add(0); lista_txt.Add(0.25); lista_txt.Add(-1); lista_txt.Add(0); lista_txt.Add(0); //5
                    //lista_txt.Add(0); lista_txt.Add(1); lista_txt.Add(-1); lista_txt.Add(0); lista_txt.Add(4); lista_txt.Add(0); //1

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
                //double.Parse(item.Text);
                M[i, j] = double.Parse(item.Text);
                //M[i, j] = item;
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

                        rf1.Text = Resultados[0].ToString();
                        rf2.Text = Resultados[1].ToString();
                        rf3.Text = Resultados[2].ToString();
                        break;
                    case 4:
                        rf1.Text = Resultados[0].ToString();
                        rf2.Text = Resultados[1].ToString();
                        rf3.Text = Resultados[2].ToString();
                        rf4.Text = Resultados[3].ToString();
                        break;
                    case 5:
                        rf1.Text = Resultados[0].ToString();
                        rf2.Text = Resultados[1].ToString();
                        rf3.Text = Resultados[2].ToString();
                        rf4.Text = Resultados[3].ToString();
                        rf5.Text = Resultados[4].ToString();
                        break;
                }
            }
            else //GAUSS-SEIDEL
            {
                //tole = 0.01; MODIFICACION PARA EJ.5

                double[] resultadosi = new double[5];
                double[] resultadosn = new double[5];
                double resultadoparcial = 0;
                bool band = false;
                for (i = 0; i < max; i++)
                {
                    resultadosi[i] = 0;
                    resultadosn[i] = 0;
                }
                int iter = 0;

                while (iter < 100 & band == false) // while (iter < 2 & band == false) // MODIFICACION PARA EJ.5
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
                    if ((Math.Abs(resultadosn[0])-Math.Abs(resultadosi[0])) <= tole && (Math.Abs(resultadosn[1]) - Math.Abs(resultadosi[1])) <= tole && (Math.Abs(resultadosn[2]) - Math.Abs(resultadosi[2])) <= tole && (Math.Abs(resultadosn[3]) - Math.Abs(resultadosi[3])) <= tole && (Math.Abs(resultadosn[4]) - Math.Abs(resultadosi[4])) <= tole)
                    {
                        band = true;
                    }
                    iter++;
                    resultadosi[0] = resultadosn[0];
                    resultadosi[1] = resultadosn[1];
                    resultadosi[2] = resultadosn[2];
                    resultadosi[3] = resultadosn[3];
                    resultadosi[4] = resultadosn[4];


                }
                for (i = 0; i < max; i++)
                {
                    Resultados.Add(resultadosn[i]);
                }
                switch (Resultados.Count)
                {
                    case 3:
                        rf1.Text = Resultados[0].ToString();
                        rf2.Text = Resultados[1].ToString();
                        rf3.Text = Resultados[2].ToString();
                        break;
                    case 4:
                        rf1.Text = Resultados[0].ToString();
                        rf2.Text = Resultados[1].ToString();
                        rf3.Text = Resultados[2].ToString();
                        rf4.Text = Resultados[3].ToString();
                        break;
                    case 5:
                        rf1.Text = Resultados[0].ToString();
                        rf2.Text = Resultados[1].ToString();
                        rf3.Text = Resultados[2].ToString();
                        rf4.Text = Resultados[3].ToString();
                        rf5.Text = Resultados[4].ToString();
                        break;
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

                r4.Visible = true; r5.Visible = false;
                rf4.Visible = true; rf5.Visible = false;


            }
            else
            {
                if (checkedListBox1.GetItemChecked(2) == true) //Si es 5x5
                {
                    m41.Visible = true; m42.Visible = true; m43.Visible = true; m44.Visible = true;
                    m14.Visible = true; m24.Visible = true; m34.Visible = true;

                    m51.Visible = true; m52.Visible = true; m53.Visible = true; m54.Visible = true; m55.Visible = true;
                    m15.Visible = true; m25.Visible = true; m35.Visible = true; m45.Visible = true; m55.Visible = true;

                    r4.Visible = true; r5.Visible = true;
                    rf4.Visible = true; rf5.Visible = true;
                }
                else //Si es 3x3
                {
                    m41.Visible = false; m42.Visible = false; m43.Visible = false; m44.Visible = false;
                    m14.Visible = false; m24.Visible = false; m34.Visible = false;

                    m51.Visible = false; m52.Visible = false; m53.Visible = false; m54.Visible = false; m55.Visible = false;
                    m15.Visible = false; m25.Visible = false; m35.Visible = false; m45.Visible = false; m55.Visible = false;

                    r4.Visible = false; r5.Visible = false;
                    rf4.Visible = false; rf5.Visible = false;
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

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Matrices_Load(object sender, EventArgs e)
        {

        }
    }
}
