using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator2
{
    public partial class Form1 : Form
    {
        string Operator;
        string num1 = "";
        string num2 = "";

        public Form1()
        {
            InitializeComponent();

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = "+";
            button12.Text = "-";
            button13.Text = "+";
            button14.Text = "/";
            button15.Text = "=";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "1";
            num1 = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "2";
            num1 = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "3";
            num1 = num1 + textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "4";
            num1 = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "5";
            num1 = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "6";
            num1 = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "7";
            num1 = textBox1.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "8";
            num1 = textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "9";
            num1 = textBox1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = num1 + "0";
            num1 = textBox1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = "";
            textBox2.Text = "+";
            Operator = textBox1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = "";
            textBox2.Text = "-";
            Operator = textBox1.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = "";
            textBox2.Text = "*"; //*
            Operator = textBox1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = "";
            textBox2.Text = "/";
            Operator = textBox1.Text;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);
            int ergebnis;

            if (Operator == "+")
            {
                ergebnis = 1;
            }
            else if (Operator == "-")
            {
                ergebnis = -1;
            }
            else if(Operator == "*")
            {
                ergebnis = -2;
            }
            else if (Operator== "/")
            {
                ergebnis = 3;
            }
            textBox1.Text = $"{ergebnis}";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
