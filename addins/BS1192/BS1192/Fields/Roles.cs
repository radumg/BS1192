using System;
using BS1192.Standard;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the role of an organisation as per BS1192.
    /// </summary>
    public class Role : Field
    {
        
        private Standard.Role _role;

        /// <summary>
        /// The currently assigned role. 
        /// </summary>
        public Standard.Role CurrentRole
        {
            get { return _role; }
            set
            {
                if (value.GetType() != new Standard.Role().GetType()) throw new InvalidCastException("Cannot set role because supplied argument is not a valid BS1192 role");
                _role = value;
                if (!Enum.IsDefined(new Standard.Role().GetType(), value)) throw new ArgumentOutOfRangeException("The supplied role could not be found in the list of BS1192 roles.");
            }
        }


        /// <summary>
        /// Build a BS1192 role field from a standard BS1192 Role.
        /// </summary>
        /// <param name="role">The standard BS1192 role as a Role.</param>
        public Role(Standard.Role role)
        {
            // throws exception if argument is invalid.
            // we do this instead of defaulting to A as user would expect the exact supplied value to be used.
            this.CurrentRole = role;

            this.Required = true;
            this.NumberOfChars = 1;
            this.FixedNumberOfChars = true;
        }

        /// <summary>
        /// Build a BS1192 role field from a standard BS1192 Role.
        /// </summary>
        /// <param name="s">The standard BS1192 role as a string.</param>
        public Role(string s)
        {
            Standard.Role role;

            if (CheckFormatAndLength(s)) throw new Exception("Cannot build Role because supplied string is invalid");
            if (!Enum.TryParse(s, out role)) throw new Exception("Could not parse string into Role.");

            this.CurrentRole = role;
            this.Required = true;
            this.NumberOfChars = 1;
            this.FixedNumberOfChars = true;
        }

    }
}

