using BS1192.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    public static partial class Validation
    {
        public static Role? ParseRole(object o)
        {
           // if (IsValidRole(o)) throw new Exception("The supplied object is not a valid Role");
            var parsed = Enum.TryParse(o.ToString(), out BS1192.Standard.Role temp);

            if (parsed != false && temp != Standard.Role.None) return temp;
            else return null;
        }

        public static SuitabilityCode? ParseSuitabilityCode(object o)
        {
            //if (IsValidRole(o)) throw new Exception();
            var parsed = Enum.TryParse(o.ToString(), out BS1192.Standard.SuitabilityCode temp);

            if (parsed != false && temp != Standard.SuitabilityCode.None) return temp;
            else return null;
        }

    }
}
