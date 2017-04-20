using System;
using System.Linq;
using BS1192.Standard;

namespace BS1192.Fields
{
    public class Field
    {
        public bool Required { get; set; }
        public bool FixedNumberOfChars { get; set; }
        public int NumberOfChars { get; set; }
        public int MinNumberOfChars { get; set; }
        public int MaxNumberOfChars { get; set; }

        // backing store for each Field's value
        internal string _value { get; set; }

        /// <summary>
        /// client-visible property designed to be overriden
        /// </summary>
        public virtual string Value
        {
            get { return _value; }
            set { if (CheckStringFormat(value)) _value = value; }
        }

        /// <summary>
        /// Class constructor with default values of 2-5 character field.
        /// </summary>
        public Field(string s = null)
        {
            this.Required = false;
            this.FixedNumberOfChars = false;
            this.NumberOfChars = 2;
            this.MaxNumberOfChars = 5;
            this.MinNumberOfChars = 2;
            try
            {
                if (CheckStringFormat(s)) this._value = s;
            }
            catch (Exception)
            {
                this._value = "";
            }
        }

        /// <summary>
        /// Perform basic data validation : checks the field is not empty and that the number of characters is satisfied.
        /// </summary>
        /// <returns>True if valid, false otherwise.</returns>
        internal bool CheckStringFormat(string s)
        {
            if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s)) throw new ArgumentException("Field value cannot be empty or null");
            if (s.All(char.IsLetterOrDigit)) throw new ArgumentException("Field can only contain alphanumeric characters.");
            if (this.FixedNumberOfChars == true)
            {
                if (s.Count() != this.NumberOfChars)
                    throw new ArgumentException("Field must be precisely the number of required characters. (" + this.NumberOfChars + ")");
            }
            else
            {
                if (s.Count() > this.MaxNumberOfChars || s.Count() < this.MinNumberOfChars)
                    throw new ArgumentException("Field must have the number of characters within the required ranged : " + this.MinNumberOfChars + " to " + this.MaxNumberOfChars);
            }

            return true;
        }

        /// <summary>
        /// Skeleton implementation of data verification designed to be overriden.
        /// Example verifies that the field only contains alphanumeric characters.
        /// </summary>
        /// <returns>True if conditions are satisfied, false otherwise.</returns>
        public virtual bool Validate()
        {
            return this.CheckStringFormat(this.Value);
        }

    }
}
