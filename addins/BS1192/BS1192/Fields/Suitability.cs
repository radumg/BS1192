using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192.Fields
{
    public enum SuitabilityCode
    {
        S0,
        S1,
        S2,
        S3,
        S4,
        S6,
        S7,
        D1,
        D2,
        D3,
        D4,
        A1,
        A2,
        B1,
        B2
    }
    public enum DataTypes
    {
        NotDefined,
        Graphical,
        NonGraphical,
        Document
    }
    public class Suitability : Field
    {
        public SuitabilityCode Status { get; set; }
        public string Description { get; set; }
        public int Revision { get; set; }
        public List<DataTypes> Applicability { get; set; }

        /// <summary>
        /// Build a BS1192 Suitability.
        /// </summary>
        public Suitability()
        {
            this.Status = SuitabilityCode.S0;
            this.Revision = 0;
            this.Applicability.Add(DataTypes.NotDefined);
        }      
    }
}
