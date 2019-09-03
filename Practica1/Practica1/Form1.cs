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

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(2) == true) //Si es 4x4
            {
                m41.Visible = true;
                m42.Visible = true;
                m43.Visible = true;
                m44.Visible = true;
                m14.Visible = true;
                m24.Visible = true;
                m34.Visible = true;
            }
            else
            {
                if (checkedListBox1.GetItemChecked(3) == true) //Si es 5x5
                {
                    m41.Visible = true;
                    m42.Visible = true;
                    m43.Visible = true;
                    m44.Visible = true;
                    m14.Visible = true;
                    m24.Visible = true;
                    m34.Visible = true;

                    m51.Visible = true;
                    m52.Visible = true;
                    m53.Visible = true;
                    m54.Visible = true;
                    m55.Visible = true;
                    m15.Visible = true;
                    m25.Visible = true;
                    m35.Visible = true;
                    m45.Visible = true;
                    m55.Visible = true;
                }
            }
        }
    }
}
