using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._1
{
    public partial class Form1 : Form
    {
        Calculator calc;
        string output;

        public Form1()
        {
            InitializeComponent();
            calc = new MemCalculator();
            output = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // empty for now
        }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.calculate();
            }
            else
            {
                Console.WriteLine("not the enter key");
            }
        }

        private void changeOutput(string character)
        {
            txt_output.Text += character;
        }

        private void clearOutput()
        {
            txt_output.Clear();
        }
        private void btn_number1_Click(object sender, EventArgs e)
        {
            changeOutput("1");
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            changeOutput("2");
        }

        private void btn_number3_Click(object sender, EventArgs e)
        {
            changeOutput("3");
        }

        private void btn_number4_Click(object sender, EventArgs e)
        {
            changeOutput("4");
        }

        private void btn_number5_Click(object sender, EventArgs e)
        {
            changeOutput("5");
        }

        private void btn_number6_Click(object sender, EventArgs e)
        {
            changeOutput("6");
        }

        private void btn_number7_Click(object sender, EventArgs e)
        {
            changeOutput("7");
        }

        private void btn_number8_Click(object sender, EventArgs e)
        {
            changeOutput("8");
        }

        private void btn_number9_Click(object sender, EventArgs e)
        {
            changeOutput("9");
        }

        private void btn_number0_Click(object sender, EventArgs e)
        {
            changeOutput("0");
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            changeOutput("+");
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            changeOutput("-");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            changeOutput("*");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            changeOutput("/");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.clearOutput();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            this.calculate();
        }

        private void calculate()
        {
            Console.WriteLine("calc called");
            this.clearOutput();
            string temp = txt_output.Text;
            
            txt_output.Text = temp;
        }

        private void btn_leftBracket_Click(object sender, EventArgs e)
        {
            changeOutput("(");
        }

        private void btn_bracketRight_Click(object sender, EventArgs e)
        {
            changeOutput(")");
        }
    }


    public abstract class Calculator
    {
        public Calculator()
        { }

        public abstract string calculate(string equation);

        public bool isValid(string equation)
        {
            return !equation.Contains("/0"); //If anything's being divided by 0
        }
        public string clear()
        {
            return "";
        }


    }

    public class MemCalculator : Calculator
    {
        DataTable dt;
        public MemCalculator()
        {
            this.dt = new DataTable();
        }

        public string trimEquation(string equation)
        {
            return equation.Replace(" ", "");
        }

        public override string calculate(string equation)
        {
            if (this.isValid(this.trimEquation(equation)) == true)
            {
                var val = dt.Compute(equation, "");
                return val.ToString();
            }
            else
            {
                return "Cannot Divide by Zero";
            }
        }
    }

}
