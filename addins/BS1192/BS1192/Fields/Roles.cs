using System;
using BS1192.Standard;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the role of an organisation as per BS1192.
    /// </summary>
    public class Role : Field
    {
        
        /// <summary>
        /// The currently assigned role. 
        /// </summary>
        private Standard.Role _role;
        
        public Standard.Role CurrentRole
        {
            get { return _role; }
            set
            {
                if (value.GetType() != new Standard.Role().GetType()) throw new InvalidCastException("Cannot set role because supplied argument is not a valid BS1192 role");
                _role = value;
            }
        }

        
        /// <summary>
        /// Build a BS1192 role field from a standard BS1192 Role. If no role is supplied, it defaults to A.
        /// </summary>
        public Role(Standard.Role role)
        {
            // throw exception if argument is invalid.
            // we do this instead of defaulting to A as user would expect supplied value to be used.
            if (role.GetType() != new Standard.Role().GetType()) throw new InvalidCastException("Cannot build role field because supplied argument is not a valid BS1192 role");

            this._role = role;

            this.Required = true;
            this.NumberOfChars = 1;
            this.FixedNumberOfChars = true;
            this.CurrentRole = role;
        }

        public Role(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) throw new Exception("Cannot build Role because supplied string is null or empty.");
            Standard.Role role;
            if (Enum.TryParse(s, out role)) throw new Exception("Could not parse string into Role.");

            this._role = role;

            this.Required = true;
            this.NumberOfChars = 1;
            this.FixedNumberOfChars = true;
            this.CurrentRole = role;
        }

    }
}

