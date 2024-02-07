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
    public partial class QuadraticEquation : Form
    {
        int coefficientA
        {
            get { return int.Parse(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }

        int coefficientB
        {
            get { return int.Parse(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }


        int coefficientC
        {
            get { return int.Parse(textBox3.Text); }
            set { textBox3.Text = value.ToString(); }
        }

        string Answer
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TheRootOfTheQuadraticEquation theRootOfTheQuadraticEquation = new TheRootOfTheQuadraticEquation();

            var result = theRootOfTheQuadraticEquation.CalculateRootsOfTheQuadraticEquation(
                 coefficientA, coefficientB, coefficientC
                 );
            if (result.flag == -1)
            {
                Answer = $"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} нет ";
            }
            else if (result.flag == 0)
            {
                Answer = $"Корень уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
                      $"один : x1 = x2 = {result.firstRoot}";

            }
            else if (result.flag == 1)
            {
                Answer = $"Корни уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
                       $"равны : x1 = {result.firstRoot} x2 = {result.secondRoot}";
            }


        }
    }
}
