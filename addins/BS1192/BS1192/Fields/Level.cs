using System;
using BS1192.Standard;
using System.Linq;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the Volume as per BS1192.
    /// </summary>
    public class Level : Field
    {
        public Level(string s)
        {
            this.Required = true;
            this.NumberOfChars = 2;
            this.FixedNumberOfChars = true;

            if (CheckFormatAndLength(s)) throw new Exception();

            // if Level contains only digits
            if (IsNumeric(s))
            {
                if(int.TryParse(s, out int value)) throw new Exception("Could not parse string into an int value for Level.");
                else this.Value = value.ToString();
            }
            else if (!Enum.TryParse(s, out Standard.Levels level)) throw new Exception("Could not parse string into Level.");

            // we set this at the end as the Value set accessor does validation taking into account properties above
            this.Value = s;
        }
    }
}

