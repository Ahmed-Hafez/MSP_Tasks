using System;
using NSConvert = NumberingSystemConverter;

namespace NumberingSystemConverter
{
    /// <summary>
    /// Represents the binary numbers
    /// <para>Exceptions : InvalidBinaryFormat</para>
    /// </summary>
    class Binary
    {
        /// <summary>
        /// The specified binary number.
        /// </summary>
        private string binary;

        /// <summary>
        /// Intializes a new instance from Binary class
        /// by the specified <paramref name="binary"/> number
        /// </summary>
        /// <param name="binary">The specified binary number</param>
        public Binary(string binary)
        {
            setBinary(binary);
        }

        /// <summary>
        /// Reset the value of the binary number.
        /// </summary>
        /// <param name="binary">The new value of the binary number</param>
        private void setBinary(string binary)
        {
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] != '0' && binary[i] != '1')
                    throw new Exception("Invalid Binary Format");
            }
            this.binary = binary;
        }

        /// <summary>
        /// Returns the decimal representation of the binary number.
        /// </summary>
        public NSConvert.Decimal GetDecimal()
        {
            double @decimal = 0;
            for (int i = binary.Length - 1, j = 0; i >= 0; i--, j++)
                @decimal += (binary[i] - '0') * Math.Pow(2, j);
            return new Decimal(@decimal);
        }

        /// <summary>
        /// Returns the octal representation of the binary number.
        /// </summary>
        public Octal GetOctal()
        {
            return new Octal(GetDecimal().GetOctal().ToString());
        }

        /// <summary>
        /// Returns the hexadecimal representation of the binary number.
        /// </summary>
        public Hexadecimal GetHexadecimal()
        {
            return new Hexadecimal(GetDecimal().GetHexadecimal().ToString());
        }

        /// <summary>
        /// Returns the binary number.
        /// </summary>
        public override string ToString()
        {
            return binary;
        }
    }
}