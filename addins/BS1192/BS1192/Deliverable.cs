using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS1192;

namespace BS1192.Classes
{
    public class Deliverable
    {
        /*
         * project code
         * originator
         * volume/location
         * level
         * type
         * role
         * classification
         * number
         * suitability
         * revision
         */
        public Field ProjectCode { get; set; }
        public Field Originator { get; set; }
        public Field Volume { get; set; }
        public Field Level { get; set; }
        public FileType FileType { get; set; }
        public Role Role { get; set; }
        public Field Classification { get; set; }
        public Suitability Suitability { get; set; }
        public Revision Revision { get; set; }

        public Deliverable()
        {
            this.ProjectCode = new Field() { Required = true, NumberOfChars = 6 } ;
            this.Originator = new Field() { Required = true, NumberOfChars=6 ;
            this.Volume = new Field();
            this.Level = new Field();
            this.FileType = new BS1192.FileType();
            this.Role = new Role();
            this.Suitability = new Suitability();
            this.Revision = new Revision();
        }
    }
}
