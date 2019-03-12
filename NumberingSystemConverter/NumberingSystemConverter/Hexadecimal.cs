using System;
using NSConvert = NumberingSystemConverter;

namespace NumberingSystemConverter
{
    /// <summary>
    /// Represents the hexadecimal numbers
    /// <para>Exceptions : InvalidHexadecimalFormat</para>
    /// </summary>
    class Hexadecimal
    {
        /// <summary>
        /// The specified hexadecimal number.
        /// </summary>
        private string hexadecimal;

        /// <summary>
        /// Intializes a new instance from Hexadecimal class
        /// by the specified <paramref name="hexadecimal"/> number
        /// </summary>
        /// <param name="hexadecimal">The specified hexadecimal number</param>
        public Hexadecimal(string hexadecimal)
        {
            setHexadecimal(hexadecimal);
        }

        /// <summary>
        /// Reset the value of the hexadecimal number.
        /// </summary>
        /// <param name="hexadecimal">The new value of the hexadecimal number</param>
        private void setHexadecimal(string hexadecimal)
        {
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if ((hexadecimal[i] >= '0' && hexadecimal[i] <= '9') ||
                    (char.ToUpper(hexadecimal[i]) >= 'A' &&
                    char.ToUpper(hexadecimal[i]) <= 'F')) continue;
                else throw new Exception("Invalid Hexadecimal Format");
            }
            this.hexadecimal = hexadecimal.ToUpper();
        }

        /// <summary>
        /// Returns the decimal representation of the hexadecimal number.
        /// </summary>
        public NSConvert.Decimal GetDecimal()
        {
            double @decimal = 0;
            for (int i = hexadecimal.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (hexadecimal[i] - '0' >= 0 && hexadecimal[i] - '0' <= 9)
                    @decimal += (hexadecimal[i] - '0') * Math.Pow(16, j);
                else
                    @decimal += (hexadecimal[i] - 55) * Math.Pow(16, j);
            }
            return new Decimal(@decimal);
        }

        /// <summary>
        /// Returns the binary representation of the hexadecimal number.
        /// </summary>
        public Binary GetBinary()
        {
            string binary = "";
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if (hexadecimal[i] - '0' >= 0 && hexadecimal[i] - '0' <= 9)
                    binary += new Decimal(hexadecimal[i] - '0').GetBinary();
                else 
                    binary += new Decimal(hexadecimal[i] - 55).GetBinary();
            }
            return new Binary(binary);
        }

        /// <summary>
        /// Returns the octal representation of the hexadecimal number.
        /// </summary>
        public Octal GetOctal()
        {
            return new Octal(GetDecimal().GetOctal().ToString());
        }

        /// <summary>
        /// Returns the hexadecimal number.
        /// </summary>
        public override string ToString()
        {
            return hexadecimal;
        }
    }
}