using System;
using BS1192.Standard;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the Volume as per BS1192.
    /// </summary>
    public class Volume : Field
    {
        public string Value { get { return base.Value; } }

        public Volume(string s)
        {
            this.Required = true;
            this.NumberOfChars = 2;
            this.FixedNumberOfChars = true;

            // we set this at the end as the Value set accessor does validation taking into account properties above
            base.Value = s;
        }
    }
}

