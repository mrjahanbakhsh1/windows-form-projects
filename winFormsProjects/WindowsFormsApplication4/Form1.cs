using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox7.Text);
            int b = Convert.ToInt32(textBox6.Text);

            int c = Convert.ToInt32(textBox8.Text);
            int d = Convert.ToInt32(textBox9.Text);


            double sum = (a / b) + (c / d);
            textBox1.Text = sum.ToString();

            double subtraction = (a / b) - (c / d);
            textBox2.Text = subtraction.ToString();

            double multiplication = (a / b) * (c / d);
            textBox3.Text = multiplication.ToString();

            double division = (a / b) / (c / d);
            textBox4.Text = division.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
