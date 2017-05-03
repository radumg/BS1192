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
        public static bool IsValidRole(object o)
        {
            if (o.GetType() == typeof(Standard.Role)) return true;
            else if (o.GetType() == typeof(String)) return true;
            return false;
        }

        public static bool IsValidSuitabilityCode(object o)
        {
            if (o.GetType() != typeof(Standard.SuitabilityCode)) return false;
            else if (o.GetType() != typeof(String)) return false;
            return true;
        }

    }
}
