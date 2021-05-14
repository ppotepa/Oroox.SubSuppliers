using Microsoft.Extensions.Configuration;
using System;

namespace Oroox.SubSuppliers.Utilities.Extensions
{
    public static class ConfigurationExtensions
    {
        public static OxSuppliersEnvironmentVariables GetEnvironmentVariables(this IConfiguration @this)
        {
            return new OxSuppliersEnvironmentVariables
            {
                OX_SS_DB_CONNECTIONSTRING_DEV = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.OX_SS_DB_CONNECTIONSTRING_DEV) ?? throw new EnvironmentVariableMissingException("OX_SS_DB_CONNECTIONSTRING_DEV"),
                //OX_SS_DB_CONNECTIONSTRING_TEST = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.OX_SS_DB_CONNECTIONSTRING_TEST) ?? throw new EnvironmentVariableMissingException("OX_SS_DB_CONNECTIONSTRING_TEST"),
                //OX_SS_DB_CONNECTIONSTRING_STAGING = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.OX_SS_DB_CONNECTIONSTRING_STAGING) ?? throw new EnvironmentVariableMissingException("OX_SS_DB_CONNECTIONSTRING_STAGING"),
                //OX_SS_DB_CONNECTIONSTRING_PROD = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.OX_SS_DB_CONNECTIONSTRING_PROD) ?? throw new EnvironmentVariableMissingException("OX_SS_DB_CONNECTIONSTRING_PROD"),
                ASPNETCORE_ENVIRONMENT = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.ASPNETCORE_ENVIRONMENT) ?? throw new EnvironmentVariableMissingException("ASPNETCORE_ENVIRONMENT")
            };
        }
    }
}
