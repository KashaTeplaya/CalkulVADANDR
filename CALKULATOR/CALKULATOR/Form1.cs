﻿using System;
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
            double fisrtNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result = fisrtNumber - secondNumber;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fisrtNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result = fisrtNumber / secondNumber;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double fisrtNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result = fisrtNumber * secondNumber;
            textBox3.Text = result.ToString();
        }
    }
}
