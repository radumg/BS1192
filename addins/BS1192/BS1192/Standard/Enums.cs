using System;

namespace BS1192.Standard
{
    /// <summary>
    /// The standard and accepted suitability codes as found in BS1192.
    /// </summary>
    [Flags]
    public enum SuitabilityCode
    {
        None = 0,
        S0,
        S1,
        S2,
        S3,
        S4,
        S6,
        S7,
        D1,
        D2,
        D3,
        D4,
        A1,
        A2,
        B1,
        B2
    }

    /// <summary>
    /// The standard and accepted data types as referenced in BS1192.
    /// </summary>
    [Flags]
    public enum DataType
    {
        NotDefined =0,
        Graphical,
        NonGraphical,
        Document
    }

    /// <summary>
    /// The standard and accepted roles as found in BS1192.
    /// </summary>
    [Flags]
    public enum Role
    {
        None = 0,
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
    /// Represents all file types valid in BS1192
    /// </summary>
    [Flags]
    public enum FileTypes
    {
        None = 0,
        // model files
        AF,
        CM,
        CR,
        DR,
        M2,
        M3,
        MR,
        VS,
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
    }

    /// <summary>
    /// Represents valid BS1192 separators. Dash used between fields and underscore within a field.
    /// </summary>
    public struct Separator
    {
        public static string Underscore { get { return "_"; } }
        public static string Dash { get { return "-"; } }
    }

}
