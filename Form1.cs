using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Scientific scientific;
        double Answer
        {
            get { return Double.Parse(textBox3.Text); }
            set { textBox3.Text = value.ToString(); }
        }
        public Form1()
        {
            InitializeComponent();
            scientific = new Scientific();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Number не может содержать символы и/или буквы");
            }
        }


      

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scientific.Show();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 1);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 2);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonMultiplay_Click(object sender, EventArgs e)
        {
            Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 3);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 4);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != " ")
            {
                Answer = CalcEngine.Calculate(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), 5);
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
