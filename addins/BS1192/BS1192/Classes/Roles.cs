using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS1192
{
    /// <summary>
    /// Represents the role of an organisation as per BS1192.
    /// </summary>
    public class Role : Field
    {
        /// <summary>
        /// The currently assigned role. 
        /// </summary>
        public BS1192_Role CurrentRole { get; set; }

        /// <summary>
        /// A list of the supported BS1192 Role codes
        /// </summary>
        public enum BS1192_Role
        {
            /// <summary>
            /// Architect
            /// </summary>
            A,
            B,
            /// <summary>
            /// Civil Engineer
            /// </summary>
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
            /// <summary>
            /// General (non-disciplinary)
            /// </summary>
            Z
        }

        /// <summary>
        /// Sets the current role to the specified one.
        /// </summary>
        /// <param name="role">The role to set current one to.</param>
        /// <returns>The updated current role.</returns>
        public BS1192_Role SetRole(BS1192_Role role)
        {
            if (role.GetType() != new BS1192_Role().GetType()) throw new InvalidCastException("Supplied argumet is not a valid BS1192 role");

            this.CurrentRole = role;
            return this.CurrentRole;
        }

        /// <summary>
        /// Build a BS1192 Role.
        /// </summary>
        public Role()
        {
            this.Required = true;
            this.NumberOfChars = 1;
        }
    }
}

