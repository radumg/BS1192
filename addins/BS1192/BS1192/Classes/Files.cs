using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    /// <summary>
    /// Represents the file types that BS1192 can describe, such as M3 (3D models), CR (Clash rendition), etc
    /// </summary>
    public class FileType : Field
    {
        /// <summary>
        /// Represents file types for drawings and models	
        /// </summary>
        public enum BS1192_ModelFile
        {
            AF,
            CM,
            CR,
            DR,
            M2,
            M3,
            MR,
            VS
        }

        /// <summary>
        /// Represents file types for documents	
        /// </summary>
        public enum BS1192_Document
        {
            BQ,
            CA,
            CO,
            CP,
            DB,
            FN,
            HS,
            IE,
            MI,
            MR,
            MS,
            PP,
            PR,
            RD,
            RI,
            RP,
            SA,
            SC,
            SH,
            SN,
            SP,
            SU,
            VS
        }

        /// <summary>
        /// Build a BS1192 file type
        /// </summary>
        public FileType()
        {
            this.Required = true;
            this.NumberOfChars = 1;
        }
    }
}
