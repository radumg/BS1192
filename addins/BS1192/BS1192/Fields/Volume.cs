using System;
using BS1192.Standard;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the role of an organisation as per BS1192.
    /// </summary>
    public class Volume : Field
    {

        public Volume(string s)
        {
            this.Value = s;
            this.Required = true;
            this.NumberOfChars = 1;
            this.FixedNumberOfChars = true;
        }

    }
}

