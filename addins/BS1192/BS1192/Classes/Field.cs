using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    class Field
    {
        private bool Required = false;
        private int NumberOfChars = 1;
        private string Value { get
            {
                if (Validate() && Verify()) return this.Value;
                return null;
            }
            set
            {
                this.Value = value;
            }
        }

        public Field()
        {
            this.Required = false;
            this.NumberOfChars = 1;
            this.Value = "";
        }

        public string GetValue()
        {
            if (Validate() && Verify()) return this.Value;
            throw new InvalidOperationException("Field value did not pass validation & verification tests.");
        }

        /// <summary>
        /// Perform basic data validation : checks the field is not empty and that the number of characters is satisfied.
        /// </summary>
        /// <returns>True if valid, false otherwise.</returns>
        private bool Validate()
        {
            if (String.IsNullOrEmpty(this.Value)) throw new ArgumentException("Field value cannot be empty or null");
            if (this.Value.All(char.IsLetterOrDigit)) throw new ArgumentException("Field can only contain alphanumeric characters.");
            if (this.Value.Count() != this.NumberOfChars) return false;
            return true;
        }

        /// <summary>
        /// Skeleton implementation of data verification designed to be overriden.
        /// Example verifies that the field only contains alphanumeric characters.
        /// </summary>
        /// <returns>True if conditions are satisfied, false otherwise.</returns>
        public virtual bool Verify()
        {
            return this.Value.All(char.IsLetterOrDigit);
        }
    }
}
