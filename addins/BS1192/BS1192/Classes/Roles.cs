using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
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

    public static class Role
    {
        public static Roles CurrentRole { get; set; }

        /// <summary>
        /// Sets the current role to the specified one.
        /// </summary>
        /// <param name="role">The role to set current one to.</param>
        /// <returns>The updated current role.</returns>
        public static Roles SetRole(Roles role)
        {
            if (role == null) throw new ArgumentNullException("Specified role cannot be empty or null");
            if (role.GetType() != new Roles().GetType()) throw new InvalidCastException("Supplied argumet is not a valid BS1192 role");

            Role.CurrentRole = role;
            return Role.CurrentRole;
        }
    }
}

