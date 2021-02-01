using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reboot_method
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();


        class Calculator
        {
            public void Sum(int a, int b,Label lb)
            {
                int result = a + b;
                lb.Text = $"Сумма двух чисел {result}";
            }
            public void Sum(int a, int b, int c, Label lb)
            {
                int result = a + b + c;
                lb.Text = $"Сумма трёх чисел {result}";
            }
            public void Sum(int a, int b, int c, int d, Label lb)
            {
                int result = a + b + c + d;
                lb.Text = $"Сумма четырёх чисел {result}";
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            calc.Sum(a, b, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            calc.Sum(a, b, c, label1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);

            calc.Sum(a, b, c, d, label1);

        }

    }
}
