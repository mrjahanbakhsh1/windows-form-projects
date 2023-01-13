using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(text1.Text != "" && text2.Text != "")
            {
                int hours = Convert.ToInt32(text1.Text);
                int minutes = Convert.ToInt32(text2.Text);

                if (hours <= 24 && minutes <= 59 && hours > 0 && minutes > 0)
                {

                    if (hours >= 1 && hours <= 12)
                    {
                        result.Text = ("Time is " + hours + ":" + minutes + " AM");
                    }
                    else if (hours > 12 && hours <= 24)
                    {
                        hours = hours - 12;
                        result.Text = ("Time is " + hours + ":" + minutes + " PM");
                    }

                }
                else
                {
                    result.Text = ("Time is not correct!");
                }
            }else
            {
                result.Text = ("Fill all inputs please");

            }
        }
    }
}
