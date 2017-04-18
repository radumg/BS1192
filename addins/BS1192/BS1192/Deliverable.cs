using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS1192.Fields;
using BS1192;

namespace BS1192
{
    public class Deliverable : Field
    {
        public Field ProjectCode { get; set; }
        public Field Originator { get; set; }
        public Field Volume { get; set; }
        public Field Level { get; set; }
        public FileType FileType { get; set; }
        public Role Role { get; set; }
        public Field Classification { get; set; }
        public Field Number { get; set; }
        public Suitability Suitability { get; set; }
        public Revision Revision { get; set; }

        public Deliverable()
        {
            this.ProjectCode = new Field() { Required = true, MinNumberOfChars = 3, MaxNumberOfChars = 6 };
            this.Originator = new Field() { Required = true, MinNumberOfChars = 3, MaxNumberOfChars = 6 } ;
            this.Volume = new Field() { Required = true, MinNumberOfChars = 3, MaxNumberOfChars=6 } ;
            this.Level = new Field() { Required = true, NumberOfChars = 2};
            this.FileType = new FileType();
            this.Role = new Role();
            this.Classification = new Field() { Required = false, NumberOfChars = 3 };
            this.Number = new Field() { Required = true, NumberOfChars = 4 };
            this.Suitability = new Suitability();
            this.Revision = new Revision();
        }

        /// <summary>
        /// Get the BS1192-formatted name of the deliverable
        /// </summary>
        /// <returns>BS1192-formatted name of the deliverable, as string.</returns>
        public string GetBS1192Name()
        {
            string name = "";

            var fields = new List<object>();
            fields.Add(this.Originator);
            fields.Add(this.Volume);
            fields.Add(this.Level);
            fields.Add(this.FileType);
            fields.Add(this.Role);
            fields.Add(this.Number);
            fields.Add(this.Suitability);
            fields.Add(this.Revision);

            foreach (object field in fields)
            {
                var f = field as Field;
                if (f.Required) name += f + Separator.Dash;
            }
            name.Remove(name.Length-1,1);
            return name;
        }

        /// <summary>
        /// Get the formatted name of the deliverable, taking into account the required fields.
        /// </summary>
        /// <returns>Formatted name of the deliverable, as string.</returns>
        public string GetFormattedName()
        {
            string name = "";
            var props = Utils.DictionaryFromType(this);

            // cycle through all public properties of the class and add all fields that are marked required.
            // uses .NET reflection so it is slower than directly getting all properties.
            foreach (KeyValuePair<string, object> p in props)
            {
                var f = p.Value as Field;
                if (f.Required) name += Utils.GetPropertyValues(this, new List<string>() { p.Key }) + "-";
            }
            name.TrimEnd('-');
            return name;
        }
        
        /// <summary>
                 /// Get the values of all the public properties
                 /// </summary>
                 /// <returns>The list of values for all the object's properties.</returns>
        public List<object> GetAllFieldValues()
        {
            var props = Utils.DictionaryFromType(this).Keys.ToList();
            var vals = Utils.GetPropertyValues(this, props);
            return new List<object>
            {
                props, vals
            };
        }
    }
}
