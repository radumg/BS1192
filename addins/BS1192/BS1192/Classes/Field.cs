using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    public class Field
    {
        public bool Required { get; set; }
        public bool FixedNumberOfChars { get; set; }
        public int NumberOfChars { get; set; }
        public int MinNumberOfChars { get; set; }
        public int MaxNumberOfChars { get; set; }

        public Field()
        {
            this.Required = false;
            this.NumberOfChars = 1;
        }


        /// <summary>
        /// Perform basic data validation : checks the field is not empty and that the number of characters is satisfied.
        /// </summary>
        /// <returns>True if valid, false otherwise.</returns>
        private bool Validate(string s)
        {
            if (String.IsNullOrEmpty(s)) throw new ArgumentException("Field value cannot be empty or null");
            if (s.All(char.IsLetterOrDigit)) throw new ArgumentException("Field can only contain alphanumeric characters.");
            if (s.Count() != this.NumberOfChars) return false;
            return true;
        }

        /// <summary>
        /// Skeleton implementation of data verification designed to be overriden.
        /// Example verifies that the field only contains alphanumeric characters.
        /// </summary>
        /// <returns>True if conditions are satisfied, false otherwise.</returns>
        public virtual bool Verify(string s)
        {
            return s.All(char.IsLetterOrDigit);
        }
    }
}
