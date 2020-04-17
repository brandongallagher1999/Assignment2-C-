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


        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_clear.Text
        }
    }


    public class Calculator
    {
        decimal output;
        public Calculator()
        {
            output = 0;
        }
    }

}
