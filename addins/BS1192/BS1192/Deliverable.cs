using System.Collections.Generic;
using System.Linq;
using BS1192.Fields;
using System;

namespace BS1192
{
    public class Deliverable : Field
    {
#region Properties
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
#endregion

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
        public Deliverable(
            Field projectCode,
            Field originator,
            Field volume,
            Field level,
            FileType fileType,
            Role role,
            Field number,
            Field classification = null,
            Suitability suitability = null,
            Revision revision = null)
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

            // inherited properties from Field class
            this.Required = true;
            this.FixedNumberOfChars = false;
            this.MinNumberOfChars = 14;
            this.MaxNumberOfChars = 30;
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
                if (f.Required) name += f + Standard.Separator.Dash;
            }
            name.Remove(name.Length - 1, 1);
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

#region GET fields as String
        public string GetProjectCodeAsString()
        {
            return this.Role.CurrentRole.ToString();
        }
        public string GetOriginatorAsString()
        {
            return this.Originator._value;
        }
        public string GetVolumeAsString()
        {
            return this.Volume._value;
        }
        public string GetLevelAsString()
        {
            return this.Level._value;
        }
        public string GetFileTypeAsString()
        {
            return this.FileType.CurrentFileType.ToString();
        }
        public string GetRoleAsString()
        {
            return this.Role.CurrentRole.ToString();
        }
        public string GetNumberAsString()
        {
            return this.Number._value;
        }
        public string GetClassificationAsString()
        {
            return this.Classification._value;
        }
        public string GetSuitabilityAsString()
        {
            return this.Suitability._value;
        }
        public string GetRevisionAsString()
        {
            return this.Revision.GetAsString();
        }
#endregion
    }
}
