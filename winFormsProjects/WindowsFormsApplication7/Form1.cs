using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            textBox1.Text = id ;

            string name = textBox2.Text;
            textBox2.Text = name;

            string date = textBox3.Text;
            textBox3.Text = date;


            double money = Convert.ToDouble(textBox4.Text);

            double bime = money * 7 / 100;
            textBox6.Text = bime.ToString();

            double maliat;
            if (money >= 6500000)
            {
                maliat = money * 10 / 100;
            }else
            {
                maliat = 0;
            }

            textBox5.Text = maliat.ToString();

            double realMoney = money - (maliat + bime);
            textBox7.Text = realMoney.ToString();

        }
    }
}
