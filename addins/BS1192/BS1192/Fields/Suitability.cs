using System;
using System.Collections.Generic;
using BS1192.Standard;

namespace BS1192.Fields
{
    public class Suitability : Field
    {
        public SuitabilityCode Status { get; set; }
        public string Description { get; set; }
        public int Revision { get; set; }
        public List<DataType> Applicability { get; set; }

        /// <summary>
        /// Build a BS1192 Suitability.
        /// </summary>
        public Suitability(SuitabilityCode s)
        {
            if (s == null) throw new ArgumentNullException("Provided suitability code cannot be null or empty.");

            this.Status = s;
            this.Revision = 0;
            this.Applicability.Add(DataType.NotDefined);
        }      
    }
}
