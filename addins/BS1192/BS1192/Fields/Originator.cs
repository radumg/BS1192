using System;
using BS1192.Standard;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the Volume as per BS1192.
    /// </summary>
    public class Originator : Field
    {
        public Originator(string s)
        {
            this.Required = true;
            this.NumberOfChars = 3;
            this.FixedNumberOfChars = true;

            // we set this at the end as the Value set accessor does validation taking into account properties above
            this.Value = s;
        }
    }
}

