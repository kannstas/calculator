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

namespace Calculator
{
    public partial class Scientific : Form
    {
        Form1 form1;
        double Answer
        {
            get { return Double.Parse(textBox4.Text); }
            set { textBox4.Text = value.ToString(); }
        }

        public Scientific()
        {
            InitializeComponent();
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), 7);
            }
            textBox1.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), 6);
            }
            textBox1.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), 8);
            }
            textBox1.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), 9);
            }
            textBox1.Clear();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), 10);
            }
            textBox1.Clear();
        }

     

        private void button7_Click(object sender, EventArgs e)
        {
            QuadraticEquation equation = new QuadraticEquation();

            
            if (equation.ShowDialog() == DialogResult.OK)
            {
                equation.ShowDialog();
            }
            



        }
    }
}
