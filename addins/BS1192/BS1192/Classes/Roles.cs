using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKBIMStandards
{
    public enum Roles
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        K,
        L,
        M,
        P,
        Q,
        S,
        T,
        W,
        X,
        Y,
        Z
    }

    public static partial class BS1192
    {
        public static Roles CurrentRole { get; set; }

        /// <summary>
        /// Retrieves the currently set role
        /// </summary>
        /// <returns>The current role as a BS1192.Roles object</returns>
        public static Roles GetCurrentRole()
        {
            return CurrentRole;
        }

        /// <summary>
        /// Sets the current role to the specified one.
        /// </summary>
        /// <param name="role">The role to set current one to.</param>
        /// <returns>The updated current role.</returns>
        public static Roles SetRole(Roles role)
        {
            if (role == null) throw new Exception("Specified role cannot be empty or null");
            if (role.GetType() != new Roles().GetType()) throw new Exception("Supplied role is not a valid BS1192 role");

            BS1192.CurrentRole = role;
            return BS1192.CurrentRole;
        }
    }
}

