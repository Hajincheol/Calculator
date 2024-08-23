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
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        double firstOperand = 0.0d;
        double secondOperand = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(display.Text);

            if(currentOperator == Operators.Add)
            {
                display.Text = (firstOperand + secondOperand).ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                display.Text = (firstOperand - secondOperand).ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                display.Text = (firstOperand * secondOperand).ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    display.Text = (firstOperand / secondOperand).ToString();
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ChangeSecondOperand(Operators.Add);
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            ChangeSecondOperand(Operators.Subtract);
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            ChangeSecondOperand(Operators.Multiply);
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            ChangeSecondOperand(Operators.Divide);
        }

        private void ChangeSecondOperand(Operators o)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = o;
            operatorChangeFlag = true;
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            operatorChangeFlag = false;
            display.Text = "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            DisplayNumber(".");
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            DisplayNumber("0");
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            DisplayNumber("1");
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            DisplayNumber("2");
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            DisplayNumber("3");
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            DisplayNumber("4");
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            DisplayNumber("5");
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            DisplayNumber("6");
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            DisplayNumber("7");
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            DisplayNumber("8");
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            DisplayNumber("9");
        }

        private void DisplayNumber(String number)
        {
            if (operatorChangeFlag == true)
            {
                if (number == ".")
                    display.Text = "0";
                else
                    display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber;
            if (number != "." && display.Text.Contains("."))
            {
                strNumber = display.Text + number;
                display.Text = double.Parse(strNumber).ToString();
            }
            else if (number != ".")
            {
                strNumber = display.Text + number;
                display.Text = Int32.Parse(strNumber).ToString();
            }
            else
            {
                display.Text = display.Text + number;
            }
        }
    }
}