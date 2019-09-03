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
            double[,] M = new double[6,5];
            List<TextBox> lista_txt = new List<TextBox>();
            switch (checkedListBox1.SelectedIndex)
            {
                case 0: //3x3
                    lista_txt.Add(m11); lista_txt.Add(m12); lista_txt.Add(m13); lista_txt.Add(r1);
                    lista_txt.Add(m21); lista_txt.Add(m22); lista_txt.Add(m23); lista_txt.Add(r2);
                    lista_txt.Add(m31); lista_txt.Add(m32); lista_txt.Add(m33); lista_txt.Add(r3);
                    max = 4;

                    break;
                case 1: //4x4
                    max = 5;
                    break;
                case 2: //5x5
                    max = 6;
                    break;
                default:
                    break;
            }

            int i = 0; int j = 0;
            foreach (var item in lista_txt)
            {
                M[i, j] = double.Parse(item.Text);
                i++;

            }



            if (comboBox1.SelectedIndex == 0) //GAUSS-JORDAN
            {



            }
            else //GAUSS-SEIDEL
            {

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
