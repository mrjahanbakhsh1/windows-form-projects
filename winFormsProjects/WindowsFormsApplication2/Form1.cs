using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(text1.Text);
            double y1 = Convert.ToDouble(text2.Text);
            double x2 = Convert.ToDouble(text3.Text);
            double y2 = Convert.ToDouble(text4.Text);

            double power2 = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            double length = Math.Sqrt(power2);

            textresult.Text = length.ToString();
        }
    }
}
