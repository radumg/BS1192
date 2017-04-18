using System.Collections.Generic;
using System.Linq;
using BS1192.Fields;
using BS1192.Standard;

namespace BS1192
{
    public class Deliverable : Field
    {
        public Field ProjectCode { get; set; }
        public Field Originator { get; set; }
        public Field Volume { get; set; }
        public Field Level { get; set; }
        public FileType FileType { get; set; }
        public Fields.Role Role { get; set; }
        public Field Classification { get; set; }
        public Field Number { get; set; }
        public Suitability Suitability { get; set; }
        public Revision Revision { get; set; }

        /// <summary>
        /// Construct a valid BS1192 deliverable with default values.
        /// </summary>
        public Deliverable()
        {
            this.ProjectCode = new Field() { Required = true, MinNumberOfChars = 3, MaxNumberOfChars = 6 };
            this.Originator = new Field() { Required = true, MinNumberOfChars = 3, MaxNumberOfChars = 6 };
            this.Volume = new Field() { Required = true, MinNumberOfChars = 3, MaxNumberOfChars = 6 };
            this.Level = new Field() { Required = true, NumberOfChars = 2 };
            this.FileType = new FileType();
            this.Role = new Fields.Role();
            this.Classification = new Field() { Required = false, NumberOfChars = 3 };
            this.Number = new Field() { Required = true, NumberOfChars = 4 };
            this.Suitability = new Suitability(Standard.SuitabilityCode.S0) { Required = false };
            this.Revision = new Revision();
            this.Revision.Required = false;
        }

        /// <summary>
        /// Construct a custom BS1192 deliverable. Requires valid BS1192 fields for each input field.
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="originator"></param>
        /// <param name="volume"></param>
        /// <param name="level"></param>
        /// <param name="fileType"></param>
        /// <param name="role"></param>
        /// <param name="number"></param>
        /// <param name="classification"></param>
        /// <param name="suitability"></param>
        /// <param name="revision"></param>
        public Deliverable(Field projectCode, Field originator, Field volume, Field level, FileType fileType, Fields.Role role, Field number, Field classification = null, Suitability suitability = null, Revision revision = null)
        {
            this.ProjectCode = projectCode;
            this.Originator = originator;
            this.Volume = volume;
            this.Level = level;
            this.FileType = fileType;
            this.Role = role;
            this.Classification = classification;
            this.Number = number;
            this.Suitability = suitability;
            this.Revision = revision;

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
