using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192.Fields
{
    /// <summary>
    /// Represents the file types that BS1192 can describe, such as M3 (3D models), CR (Clash rendition), etc
    /// </summary>
    public class FileType : Field
    {
        private Standard.FileTypes _filetype { get; set; }

        public Standard.FileTypes CurrentFileType
        {
            get { return _filetype; }
            set
            {
                if (value.GetType() != new Standard.FileTypes().GetType()) throw new InvalidCastException("Cannot set FileType because supplied argument is not a valid BS1192 file type");
                _filetype = value;
            }
        }


        /// <summary>
        /// Build a BS1192 file type
        /// </summary>
        /// <param name="fileType">The file type to use. If nothing is supplied, AF is used.</param>
        public FileType(Standard.FileTypes fileType)
        {
            this.CurrentFileType = fileType;
            this.Required = true;
            this.NumberOfChars = 2;
            this.FixedNumberOfChars = true;
        }

        public FileType(string s)
        {
            if (CheckStringFormat(s)) throw new Exception("Cannot build FileType because supplied string is invalid");
            if (!Enum.TryParse(s, out Standard.FileTypes filetype)) throw new Exception("Could not parse string into FileType.");

            // we set the public value so it goes through the set accessor, doing an additional layer of verification
            this.CurrentFileType = filetype;
            this.Required = true;
            this.NumberOfChars = 2;
            this.FixedNumberOfChars = true;
        }

    }
}
