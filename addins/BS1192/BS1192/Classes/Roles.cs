using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    public class Role
    {
        private Role.BS1192Roles CurrentRole { get; set; }

        public enum BS1192Roles
        {
            Architect,
            Structural,
            MEP,
            Construction
        }

        public BS1192Roles GetCurrentRole()
        {
            return CurrentRole;
        }

        public Role SetRole(BS1192Roles role)
        {
            if (role == null) throw new Exception("Specified role cannot be empty or null");
            if (role.GetType() != new BS1192Roles().GetType()) throw new Exception("Supplied role is not a valid BS1192 role");

            this.CurrentRole = role;
            return this;
        }
    }
}
