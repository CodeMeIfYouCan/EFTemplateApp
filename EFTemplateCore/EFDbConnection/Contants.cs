using System;
using System.Collections.Generic;
using System.Text;

namespace EFTemplateCore.EFDbConnection
{
    /// <summary>
    /// Entity framework db connection constants for providers.
    /// </summary>
    public static class Constants
    {
        public static readonly string DbConnectionProvider = "DbConnectionProvider";
        public static readonly string ConnectionStringsKey = "ConnectionStrings";
        /// <summary>
        /// Used to take other connection properties rather than the connection string.
        /// Custom built because .Net Core default connection string doesn't have this feature
        /// </summary>
        public static readonly string ConnectionStringDetailsTag = "_Details";
        public static readonly string DefaultConnectionName = "DefaultConnectionName";
    }
}
