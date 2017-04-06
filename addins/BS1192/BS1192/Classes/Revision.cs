using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    /// <summary>
    /// Represents a revision following the BS1192 standard.
    /// </summary>
    public class Revision
    {
        // these public strings are used to represent the revision as a string
        public string Major
        {
            get
            {
                if (this.major < 10) return "0" + this.major.ToString();
                else return this.major.ToString();
            }
        }
        public string Minor
        {
            get
            {
                if (this.minor < 10) return "0" + this.minor.ToString();
                else return this.minor.ToString();
            }
        }
        public string Prefix
        {
            get { return this.prefix; }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new InvalidOperationException("The prefix cannot be null or empty.");
                if (value.Count() > 1) throw new InvalidOperationException("The prefix cannot be longer than 1 character.");
                this.prefix = value;
            }
        }

        // these private integers hold the actual revision numbers
        private int major, minor;
        private string prefix;

        /// <summary>
        /// Create a BS1192-compatible revision
        /// </summary>
        /// <param name="major">The major part of a revision.
        /// XX in example : PXX.yy</param>
        /// <param name="minor">The minor part of a revision.
        /// yy in example : PXX.yy</param>
        /// <param name="prefix">The prefix of a revision.
        /// P in example L PXX.yy</param>
        public Revision(int major = 1, int minor = 0, string prefix = "P")
        {
            // validation
            if (major > 99 || minor > 99) throw new Exception("Revision would be 3 digits long which is not supported by BS1192.");
            if (major < 1 || minor < 0) throw new InvalidOperationException("Cannot set a major/minor part to a negative value");
            if (major == 0) major = 1;

            this.major = major;
            this.minor = minor;
            this.prefix = prefix;
        }

        /// <summary>
        /// Get the revision formatted as per BS1192.
        /// </summary>
        /// <returns>Returns a revision formatted as per BS1192. Example : P03.07 , where 03 is the major, 07 is the minor and P the prefix</returns>
        public string GetAsString()
        {
            return this.Prefix + this.Major + "." + this.Minor;
        }

        /// <summary>
        /// Increments the minor part of the revision (yy in this example : PXX.yy)
        /// </summary>
        public Revision IncrementMinor()
        {
            this.minor++;
            return this;
        }

        /// <summary>
        /// Increments the major part of the revision (XX in this example : PXX.yy). Please note, it also resets the minor to 0 as per BS1192.
        /// </summary>
        public Revision IncrementMajor()
        {
            this.major++;
            this.minor = 0;
            return this;
        }

        /// <summary>
        /// Sets the minor part of a revision to a specified integer value.
        /// </summary>
        /// <param name="minor">The integer to set minor to. Only accepts 0-99.</param>
        public Revision SetMinor(int minor)
        {
            if (minor < 0) throw new InvalidOperationException("Cannot set the minor of a revision to a negative value");
            if (minor > 99) throw new Exception("Revision would be 3 digits long which is not supported by BS1192.");
            this.minor = minor;
            return this;
        }

        /// <summary>
        /// Sets the major part of a revision to a specified integer value.
        /// </summary>
        /// <param name="major">The integer to set minor to. Only accepts 1-99.</param>
        public Revision SetMajor(int major)
        {
            if (major < 1) throw new InvalidOperationException("Cannot set the major of a revision to a negative value or zero.");
            if (major > 99) throw new Exception("Revision would be 3 digits long which is not supported by BS1192.");
            this.major = major;
            return this;
        }

        /// <summary>
        /// Resets the revision to default values.
        /// prefix is P, major is 1, minor is 0 : P01.00
        /// </summary>
        public Revision Reset()
        {
            this.major = 1;
            this.minor = 0;
            this.Prefix = "P";
            return this;
        }
    }
}