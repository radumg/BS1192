using System;
using System.Collections.Generic;
using BS1192.Standard;

namespace BS1192.Fields
{
    public class Suitability : Field
    {
        public SuitabilityCode Status { get; set; }
        public string Description { get; set; }
        public List<DataType> Applicability { get; set; }

        /// <summary>
        /// Build a BS1192 Suitability.
        /// </summary>
        public Suitability(Standard.SuitabilityCode s)
        {
            this.Status = s;
            this.Applicability = new List<DataType>();
            this.Applicability.Add(DataType.NotDefined);
        }      

        public Suitability(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) throw new Exception("Cannot build Role because supplied string is null or empty.");
            Standard.SuitabilityCode code;
            if (!Enum.TryParse(s, out code)) throw new Exception("Could not parse string into Suitability Code.");

            this.Status = code;
            this.Applicability = new List<DataType>();
            this.Applicability.Add(DataType.NotDefined);

        }
    }
}
