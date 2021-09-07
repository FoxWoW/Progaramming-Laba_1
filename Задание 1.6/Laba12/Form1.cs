using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, L, V1, o, p1, p, r, l;
            double l1 = 0;
            double V2 = 0;
            a = Convert.ToDouble(textBox4.Text);
            b = Convert.ToDouble(textBox5.Text);
            L = Convert.ToDouble(textBox6.Text);
            l = Convert.ToDouble(textBox7.Text);
            r = Convert.ToDouble(textBox8.Text);
            V1 = a * b * L;
            textBox1.Text = Convert.ToString(V1);
            if (l <= L)
            {
                l1 = l;
            }
            else
            {
                textBox2.Text = "N";
            }
            if (r <= a / 2)
            {
                if (r <= b / 2)
                {
                    V2 = r * l1;
                    textBox2.Text = Convert.ToString(V2);
                }
                else
                {
                    textBox2.Text = "N";
                }
            }
            else
            {
                textBox2.Text = "N";
            }
            o = V1 - V2;
            p1 = (o * 100) / V1;
            p = 100 - p1;
            textBox3.Text = Convert.ToString(p);
        }

    }
}
