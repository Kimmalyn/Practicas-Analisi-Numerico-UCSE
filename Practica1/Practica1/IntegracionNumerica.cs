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
    public partial class IntegracionNumerica : Form
    {
        public IntegracionNumerica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double resultado = 0;

            double funcion (double x)
            {
                return (Math.Pow(Math.E, x)) * (1 - (0.5 * Math.Pow(x, 2)));
                //(1 / (x + 0.5)) + (0.25 * Math.Pow(x, 2));
                //Math.Log(1 + Math.Pow(x,2));
            }

            if (checkedListBox1.GetItemChecked(0) == true)//metodo del trapecio simple
            {
                resultado = ((funcion(a) + funcion(b)) * (b - a)) / 2;
                this.resultado.Text = resultado.ToString();
            }

            if(checkedListBox1.GetItemChecked(1) == true)//trapecio multiple
            {
                int n = int.Parse(textBox3.Text);

                double h = (b - a) / n;
                double x = 0;
                double exi = 0;
                for (int i = 1; i <= n-1; i++)
                {
                    x = a + (i * h);
                    exi += funcion(x);
                }

                resultado = (h / 2) * (funcion(a) + 2 * exi + funcion(b));

                this.resultado.Text = resultado.ToString();
            }

            if (checkedListBox1.GetItemChecked(2) == true)//Simpson 1/3 Simple
            {
                double h = (b - a) / 2;
                resultado = (h / 3) * (funcion(a) + (4 * funcion((a + b) / 2)) + funcion(b));
                this.resultado.Text = resultado.ToString();
            }

            if (checkedListBox1.GetItemChecked(3) == true)//Simpson 1/3 Multiple
            {
                int n = int.Parse(textBox3.Text);
                double h = (b - a) / n;
                double exi1 = 0;
                double exi2 = 0;
                double x = 0;
                if (Math.Pow(-1,n) > 0)
                {
                    
                    for (int i = 1; i <= n ; i += 2)
                    {
                        x = a + (i * h);
                        exi1 += funcion(x);
                    }

                    for (int i = 2; i < n - 1; i += 2)
                    {
                        x = a + (i * h);
                        exi2 += funcion(x);
                    }

                    resultado = (h / 3) * (funcion(a) + (4 * exi1) + (2 * exi2) + funcion(b));

                    this.resultado.Text = resultado.ToString();
                }
                else
                { 
                    for (int i = 1; i <= n -4; i += 2)
                    {
                        x = a + (i * h);
                        exi1 += funcion(x);
                    }
                    for (int i = 2; i <= n - 5; i += 2)
                    {
                        x = a + (i * h);
                        exi2 += funcion(x);
                    }
                    double resultado2 = (0.375 * h) * (funcion(b - (h * 3)) + 3 * funcion(b - (h * 2)) + 3 * funcion(b - h) + funcion(b));
                    resultado = ((h / 3) * (funcion(a) + (4 * exi1) + (2 * exi2) + funcion(b))) + resultado2;
                    this.resultado.Text = resultado.ToString();
                }
                
            }

            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
