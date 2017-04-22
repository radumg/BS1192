using System;
using System.Linq;
using BS1192.Standard;

namespace BS1192.Fields
{
    public partial class Field
    {
        public bool Required { get; set; }
        public bool FixedNumberOfChars { get; set; }
        public int NumberOfChars { get; set; }
        public int MinNumberOfChars { get; set; }
        public int MaxNumberOfChars { get; set; }
        public bool IsValid { get { return Validate(); } }

        // backing store for each Field's value
        internal string _value { get; set; }

        /// <summary>
        /// client-visible property designed to be overriden
        /// </summary>
        public virtual string Value
        {
            get { return _value; }
            set { if (CheckFormatAndLength(value)) _value = value; }
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
                if (CheckFormatAndLength(s)) this._value = s;
            }
            catch (Exception)
            {
                this._value = "";
            }
        }

        /// <summary>
        /// Skeleton implementation of data verification designed to be overriden.
        /// Example verifies that the field only contains alphanumeric characters.
        /// </summary>
        /// <returns>True if conditions are satisfied, false otherwise.</returns>
        public virtual bool Validate()
        {
            return this.CheckFormatAndLength(this.Value);
        }

    }
}
