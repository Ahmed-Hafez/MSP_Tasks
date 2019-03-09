using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// First operand
        /// </summary>
        private double? firstNumber = null;

        /// <summary>
        /// Second Operand
        /// </summary>
        private double? secondNumber = null;

        /// <summary>
        /// Result of the arithmetic operation which applied 
        /// to <see cref="firstNumber"/> and <see cref="secondNumber"/>
        /// </summary>
        private double? result = null;

        /// <summary>
        /// The arithmetic operation to be applied
        /// </summary>
        private char operation;

        /// <summary>
        /// Indicates if the user pressed any button
        /// from the operation Buttons (plusBtn, minusBtn, multipluBtn, divideBtn)
        /// </summary>
        private bool isOperationPerformed = false;

        /// <summary>
        /// indicates if it is the first digit from the operand or not.
        /// </summary>
        private bool isFirstTimeInput = true;

        /// <summary>
        /// This variable is just to handle when operation buttons 
        /// clicked more than one time without specifying the second
        /// operand.
        /// 
        /// <!--Example ====> 5+-*5 = 25 -->
        /// </summary>
        private bool operationBtnClicked = false;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The interactions with the buttons of the numbers
        /// </summary>
        private void NumberBtns_Click(object sender, EventArgs e)
        {
            // To indicate if it is the first digit in 
            // the operand or the textBox has only the digit 0.
            if (isFirstTimeInput || resultTxt.Text.Equals("0"))
            {
                resultTxt.Clear();
                isFirstTimeInput = false;
            }

            Button btn = (Button)sender;
            resultTxt.Text += btn.Text;
            operationBtnClicked = false;
        }

        /// <summary>
        /// The interactions with the buttons of the operations
        /// </summary>
        private void OperationBtns_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (operationBtnClicked)
            {
                operation = btn.Text[0];
                return;
            }

            // to make the following click on any button for number
            // indicate that it is the first digit of the number.
            isFirstTimeInput = true;


            if (isOperationPerformed)
            {
                // second number will have value if the user 
                // make more than one operation in this the same equation.
                if (secondNumber != null)
                {
                    // putting the result of the previous operation
                    // in the firstNumber to re-make an operation with 
                    // with the new operand 
                    firstNumber = result;
                }

                // Setting the new operand in the secondNumber
                // and making the operation
                secondNumber = double.Parse(resultTxt.Text);
                performOperation();

                // setting the following operation sign 
                operation = btn.Text[0];

                resultTxt.Text = result.ToString();
            }
            else
            {
                isOperationPerformed = true;
                firstNumber = double.Parse(resultTxt.Text);
                operation = btn.Text[0];
            }

            operationBtnClicked = true;
        }

        /// <summary>
        /// performs the current operation 
        /// </summary>
        private void performOperation()
        {
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    try
                    {
                        // Divide by zero exception
                        if (secondNumber == 0) throw new Exception();

                        result = firstNumber / secondNumber;
                    }
                    catch
                    {
                        MessageBox.Show("You can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        /// <summary>
        /// The interactions with the equal button.
        /// </summary>
        private void equalBtn_Click(object sender, EventArgs e)
        {
            // True when more than one operation performed.
            // False if it is one operation.
            if (secondNumber != null)
            {
                firstNumber = result;
            }

            secondNumber = double.Parse(resultTxt.Text);
            performOperation();

            // Result will be null if one of the operands is null.
            if (result != null)
                resultTxt.Text = result.ToString();

            // Re-intialization.
            isOperationPerformed = false;
            isFirstTimeInput = true;
            operationBtnClicked = false;
            firstNumber = null;
            secondNumber = null;
            result = null;
            operation = '\0';
        }

        /// <summary>
        /// The interaction with the clear button.
        /// It only Re-intializes the date with the default values.
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "0";
            isOperationPerformed = false;
            isFirstTimeInput = true;
            operationBtnClicked = false;
            firstNumber = null;
            secondNumber = null;
            result = null;
            operation = '\0';
        }

        /// <summary>
        /// The interaction with the decimal point.
        /// </summary>
        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (isFirstTimeInput)
            {
                isFirstTimeInput = false;
                resultTxt.Text = "0.";
                return;
            }
            if (resultTxt.Text.Contains(".")) return;

            isFirstTimeInput = false;
            Button btn = (Button)sender;
            resultTxt.Text += btn.Text;
        }
    }
}
