using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192.Fields
{
    partial class Field
    {
        /// <summary>
        /// Perform basic data validation : checks the field is not empty and that the number of characters is satisfied.
        /// </summary>
        /// <returns>True if valid, false otherwise.</returns>
        internal bool CheckFormatAndLength(string s)
        {
            if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s)) throw new ArgumentException("Field value cannot be empty or null");
            if (!IsAlphanumeric(s)) throw new ArgumentException("Field can only contain alphanumeric characters.");
            if (this.FixedNumberOfChars == true && s.Count() != this.NumberOfChars)
                throw new ArgumentException("Field must be precisely the number of required characters. (" + this.NumberOfChars + ")");
            else
                if (s.Count() > this.MaxNumberOfChars || s.Count() < this.MinNumberOfChars)
                throw new ArgumentException("Field must have the number of characters within the required ranged : " + this.MinNumberOfChars + " to " + this.MaxNumberOfChars);

            return true;
        }

        /// <summary>
        /// Checks if the supplied string only contains alphanumeric characters.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>True if it does, False otherwise</returns>
        public bool IsAlphanumeric(string s)
        {
            return s.All(char.IsLetterOrDigit);
        }

        /// <summary>
        /// Checks if the supplied string only contains numeric characters.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>True if it does, False otherwise</returns>
        public bool IsNumeric(string s)
        {
            return s.All(char.IsDigit);
        }
    }
}
