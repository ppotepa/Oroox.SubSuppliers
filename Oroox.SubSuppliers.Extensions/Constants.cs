namespace Oroox.SubSuppliers.Extensions
{
    /// <summary>
    /// Constants strings.
    /// </summary>
    public readonly struct Constants 
    {
        public readonly struct EnvironmentVariables 
        {
            public const string OX_SS_DB_CONNECTIONSTRING_DEV       = nameof(OX_SS_DB_CONNECTIONSTRING_DEV);
            public const string OX_SS_DB_CONNECTIONSTRING_TEST      = nameof(OX_SS_DB_CONNECTIONSTRING_TEST);
            public const string OX_SS_DB_CONNECTIONSTRING_STAGING   = nameof(OX_SS_DB_CONNECTIONSTRING_STAGING);
            public const string OX_SS_DB_CONNECTIONSTRING_PROD      = nameof(OX_SS_DB_CONNECTIONSTRING_PROD);
            public const string ASPNETCORE_ENVIRONMENT              = nameof(ASPNETCORE_ENVIRONMENT);
        }
    }
}
