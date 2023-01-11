using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistenceTraveled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void output()
        {
            int hoursint = 0;
            int mphint = 0;
            if (int.TryParse(hoursTB.Text, out hoursint) && int.TryParse(mphTB.Text, out mphint))
            {
                outputLB.Text = $"After {hoursint} hours at {mphint}mph you will have traveled \n{mphint * hoursint} mile(s)";
            }
            else if (hoursTB.Text == "")
            {
                outputLB.Text = "Please input an amount of hours";
            }
            else if (mphTB.Text == "")
            {
                outputLB.Text = "Please input your mph";
            }
            else
            {
                outputLB.Text = "Please input numbers only";
            }
        }

        private void hoursTB_TextChanged(object sender, EventArgs e)
        {
            output();
        }

        private void mphTB_TextChanged(object sender, EventArgs e)
        {
            output();
        }
    }
}
