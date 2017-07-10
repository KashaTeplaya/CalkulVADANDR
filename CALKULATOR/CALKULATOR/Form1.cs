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

        private void button1_Click(object sender, EventArgs e)
        {
            double fisrtNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result = fisrtNumber + secondNumber;
            textBox3.Text = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Global_Click(object sender, EventArgs e)
        {
            double fisrtNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "button1":
                    //выполнение операции
                    result = fisrtNumber + secondNumber;
                    break;
                case "button2":
                   result = fisrtNumber - secondNumber;
                    //выполнение операции
                    break;
                case "button3":
                    result = fisrtNumber / secondNumber;
                    break;
                case "button4" :
                   result = fisrtNumber * secondNumber;
                    break;
                default:
                    throw new Exception("unknown operation");
                   
            }
            textBox3.Text = result.ToString();


        }

    }
}
