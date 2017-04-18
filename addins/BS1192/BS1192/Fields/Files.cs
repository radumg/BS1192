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
        public new FileTypes Value;

        /// <summary>
        /// Build a BS1192 file type
        /// </summary>
        public FileType()
        {
            this.Required = true;
            this.NumberOfChars = 2;
            this.FixedNumberOfChars = true;
        }

        public override bool Validate()
        {
            if (!this.Value.GetType().GetEnumNames().Contains(this.Value.ToString())) return false;
            return true;
        }
    }

    /// <summary>
    /// Represents all file types valid in BS1192
    /// </summary>
    public enum FileTypes
    {
        // model files
        AF,
        CM,
        CR,
        DR,
        M2,
        M3,
        MR,
        VS
        // documents
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

    public static class Separator
    {
        public static string Underscore { get { return "_"; } }
        public static string Dash { get { return "-"; } }
    }
}
