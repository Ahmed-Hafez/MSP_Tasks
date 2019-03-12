using System;
using System.Windows.Forms;
using NSConvert = NumberingSystemConverter;

namespace NumberingSystemConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            binaryTxt.Text = "";
            octalTxt.Text = "";
            decimalTxt.Text = "";
            hexadecimalTxt.Text = "";
        }

        private void binaryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(binaryTxt.Text) || string.IsNullOrWhiteSpace(binaryTxt.Text))
                    throw new Exception("Enter binary number to convert.");
                Binary binary = new Binary(binaryTxt.Text);
                octalTxt.Text = binary.GetOctal().ToString();
                decimalTxt.Text = binary.GetDecimal().ToString();
                hexadecimalTxt.Text = binary.GetHexadecimal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }

        private void octalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(octalTxt.Text) || string.IsNullOrWhiteSpace(octalTxt.Text))
                    throw new Exception("Enter octal number to convert.");
                Octal octal = new Octal(octalTxt.Text);
                binaryTxt.Text = octal.GetBinary().ToString();
                decimalTxt.Text = octal.GetDecimal().ToString();
                hexadecimalTxt.Text = octal.GetHexadecimal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
            
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(decimalTxt.Text) || string.IsNullOrWhiteSpace(decimalTxt.Text))
                {
                    MessageBox.Show("Enter decimal number to convert.", "Format Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reset();
                    return;
                }
                NSConvert.Decimal @decimal = new Decimal(double.Parse(decimalTxt.Text));
                binaryTxt.Text = @decimal.GetBinary().ToString();
                octalTxt.Text = @decimal.GetOctal().ToString();
                hexadecimalTxt.Text = @decimal.GetHexadecimal().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid decimal format", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
            
        }

        private void hexadecimalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(hexadecimalTxt.Text) || string.IsNullOrWhiteSpace(hexadecimalTxt.Text))
                    throw new Exception("Enter hexadecimal number to convert.");
                Hexadecimal hexadecimal = new Hexadecimal(hexadecimalTxt.Text);
                binaryTxt.Text = hexadecimal.GetBinary().ToString();
                octalTxt.Text = hexadecimal.GetOctal().ToString();
                decimalTxt.Text = hexadecimal.GetDecimal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }
    }
}