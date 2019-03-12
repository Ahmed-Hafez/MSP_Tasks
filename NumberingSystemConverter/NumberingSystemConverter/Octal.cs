using System;
using NSConvert = NumberingSystemConverter;

namespace NumberingSystemConverter
{
    /// <summary>
    /// Represents the octal numbers
    /// <para>Exceptions : InvalidOctalFormat</para>
    /// </summary>
    class Octal
    {
        /// <summary>
        /// The specified octal number.
        /// </summary>
        private string octal;

        /// <summary>
        /// Intializes a new instance from Octal class
        /// by the specified <paramref name="octal"/> number
        /// </summary>
        /// <param name="octal">The specified octal number</param>
        public Octal(string octal)
        {
            setOctal(octal);
        }

        /// <summary>
        /// Reset the value of the octal number.
        /// </summary>
        /// <param name="octal">The new value of the octal number</param>
        public void setOctal(string octal)
        {
            for (int i = 0; i < octal.Length; i++)
            {
                if (octal[i] >= '0' && octal[i] <= '7') continue;
                else throw new Exception("Invalid Octal Format");
            }
            this.octal = octal;
        }

        /// <summary>
        /// Returns the decimal representation of the octal number.
        /// </summary>
        public NSConvert.Decimal GetDecimal()
        {
            double @decimal = 0;
            for (int i = octal.Length - 1, j = 0; i >= 0; i--, j++)
            {
                @decimal += (octal[i] - '0') * Math.Pow(8, j);
            }
            return new Decimal(@decimal);
        }

        /// <summary>
        /// Returns the binary representation of the octal number.
        /// </summary>
        public Binary GetBinary()
        {
            string binary = "";
            for (int i = 0; i < octal.Length; i++)
            {
                NSConvert.Decimal @decimal = new Decimal(octal[i] - '0');
                binary += @decimal.GetBinary();
            }
            return new Binary(binary);
        }

        /// <summary>
        /// Returns the hexadecimal representation of the octal number.
        /// </summary>
        public Hexadecimal GetHexadecimal()
        {
            NSConvert.Decimal @decimal = GetDecimal();
            return new Hexadecimal(@decimal.GetHexadecimal().ToString());
        }

        /// <summary>
        /// Returns the octal number.
        /// </summary>
        public override string ToString()
        {
            return octal;
        }
    }
}