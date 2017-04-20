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

            if (CheckStringFormat(s)) throw new Exception();

            if (s.All(char.IsDigit))
            {
                while (s.StartsWith("0")) { s.Remove(0, 1); }
                int.TryParse(s, out int value);
            }
            else if (s.All(char.IsDigit)) { int.TryParse(s, out int value);
 }
            else if (!Enum.TryParse(s, out Standard.Levels level)) throw new Exception("Could not parse string into Level.");

            // we set this at the end as the Value set accessor does validation taking into account properties above
            this.Value = s;
        }
    }
}

