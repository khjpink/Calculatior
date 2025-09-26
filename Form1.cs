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
        Boolean operatorChangeFlag  = false;
        public decimal firstOperand = 0;
        public decimal secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // =  결과 
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Decimal.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if(secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        } 
        
        // 연산자 클릭 
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Decimal.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Decimal.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Decimal.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Decimal.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        // 숫자 클릭
        private void ButtonNone_Click(object sender, EventArgs e)
        {
                display.Text = "";
                firstOperand = 0;
                secondOperand = 0;
                currentOperator = Operators.None;
                operatorChangeFlag = false;
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if(!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        } 

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            if(display.Text == "0")
            {
                return;
            }
            display.Text += "0";
        }
        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
                display.Text += "1";
        }
        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "5";
        }
        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "6";
        }
        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "8";
        }
        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += "9";
        }// end



    }
}
