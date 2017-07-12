using System;
using System.Windows.Forms;
using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.OneArgumentsOperations;

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
        private void OneButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            var calc = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double resultValue = calc.Calculate(first);

            textBox3.Text = resultValue.ToString();
        }
    }
}


