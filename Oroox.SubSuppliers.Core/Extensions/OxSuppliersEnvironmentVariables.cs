using System;

namespace Oroox.SubSuppliers.Utilities
{
    /// <summary>
    /// POCO Class responsible for holding information of Environment Variables.
    /// Used by IConfiguration.GetEnvironmentVariables();
    /// </summary>
    public class OxSuppliersEnvironmentVariables
    {
        private const string Development = "Development";
        public string OX_SS_DB_CONNECTIONSTRING_DEV { get; set; }
        public string OX_SS_DB_CONNECTIONSTRING_TEST { get; set; }
        public string OX_SS_DB_CONNECTIONSTRING_STAGING { get; set; }
        public string OX_SS_DB_CONNECTIONSTRING_PROD { get; set; }
        public string ASPNETCORE_ENVIRONMENT { get; set; }
        public bool IsDevelopment => ASPNETCORE_ENVIRONMENT.Equals(Development, StringComparison.CurrentCultureIgnoreCase);
    }
}
