using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALKULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            var calc = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double resultValue = calc.Calculate(first, second);
      
            textBox3.Text = resultValue.ToString();
        }

       
    }
}


