using BS1192.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    public static class Validation
    {
        public static bool IsValidRole(object o)
        {
            if (o.GetType() != typeof(Standard.Role)) return false;
            else if (o.GetType() != typeof(String)) return false;
            return true;
        }

        public static Role? ParseRole(object o)
        {
            if (IsValidRole(o)) throw new Exception();
            var parsed = Enum.TryParse(o.ToString(), out BS1192.Standard.Role temp);
            if (o.GetType() != typeof(Standard.Role)) return null;
            else if (o.GetType() != typeof(String) && !parsed) return null;
            if (temp == Standard.Role.None) return null;

            return temp;
        }

        public static bool IsValidSuitabilityCode(object o)
        {
            if (o.GetType() != typeof(Standard.SuitabilityCode)) return false;
            else if (o.GetType() != typeof(String)) return false;
            return true;
        }

        public static SuitabilityCode? ParseSuitabilityCode(object o)
        {
            if (IsValidRole(o)) throw new Exception();
            var parsed = Enum.TryParse(o.ToString(), out BS1192.Standard.SuitabilityCode temp);
            if (o.GetType() != typeof(Standard.SuitabilityCode)) return null;
            else if (o.GetType() != typeof(String) && !parsed) return null;
            if (temp == Standard.SuitabilityCode.None) return null;

            return temp;
        }

    }
}
