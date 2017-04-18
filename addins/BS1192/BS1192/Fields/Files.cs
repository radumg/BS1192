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
        public Standard.FileTypes CurrentFileType { get; set; }

        /// <summary>
        /// Build a BS1192 file type
        /// </summary>
        /// <param name="fileType">The file type to use. If nothing is supplied, AF is used.</param>
        public FileType(Standard.FileTypes fileType)
        {
            this.Required = true;
            this.NumberOfChars = 2;
            this.FixedNumberOfChars = true;
            this.CurrentFileType = fileType;
        }
    }
}
