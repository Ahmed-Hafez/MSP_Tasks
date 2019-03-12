
namespace NumberingSystemConverter
{
    /// <summary>
    /// Represents the decimal numbers
    /// </summary>
    class Decimal
    {
        /// <summary>
        /// The specified decimal number
        /// </summary>
        private double @decimal;

        /// <summary>
        /// Intializes a new instance from Decimal class
        /// by the specified <paramref name="decimal"/> number
        /// </summary>
        /// <param name="decimal">The specified decimal number</param>
        public Decimal(double @decimal)
        {
            this.@decimal = @decimal;
        }

        /// <summary>
        /// Reset the value of the decimal number.
        /// </summary>
        /// <param name="binary">The new value of the decimal number</param>
        public void setDecimal(double @decimal)
        {
            this.@decimal = @decimal;
        }

        /// <summary>
        /// Returns the octal representation of the decimal number.
        /// </summary>
        public Octal GetOctal()
        {
            int decimalCopy = (int)@decimal;
            string octal = "";
            while (decimalCopy != 0)
            {
                octal = (decimalCopy % 8).ToString() + octal;
                decimalCopy /= 8;
            }
            return new Octal(octal);
        }

        /// <summary>
        /// Returns the binary representation of the decimal number.
        /// </summary>
        public Binary GetBinary()
        {
            int decimalCopy = (int)@decimal;
            string binary = "";
            while (decimalCopy != 0)
            {
                binary = (decimalCopy % 2).ToString() + binary;
                decimalCopy /= 2;
            }
            return new Binary(binary);
        }

        /// <summary>
        /// Returns the hexadecimal representation of the decimal number.
        /// </summary>
        public Hexadecimal GetHexadecimal()
        {
            int decimalCopy = (int)@decimal;
            string hexadecimal = "";
            while (decimalCopy != 0)
            {
                int hexadecimalChar = decimalCopy % 16;
                if (decimalCopy % 16 > 9)
                    hexadecimal = (char)(hexadecimalChar + 55) + hexadecimal;
                else
                    hexadecimal = hexadecimalChar.ToString() + hexadecimal;
                decimalCopy /= 16;
            }
            return new Hexadecimal(hexadecimal);
        }

        public override string ToString()
        {
            return @decimal.ToString();
        }
    }
}