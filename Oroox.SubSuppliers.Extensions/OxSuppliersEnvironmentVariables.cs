using Microsoft.Extensions.Configuration;
using System;

namespace Oroox.SubSuppliers.Extensions
{
    /// <summary>
    /// POCO Class responsible for holding information of Environment Variables.
    /// <br> Used by IConfiguration.GetEnvironmentVariables (<b>extension method</b>) </br>
    /// </summary>2
    public class OxSuppliersEnvironmentVariables
    {
        private const string Development = "Development";
        public string OX_SS_DB_CONNECTIONSTRING_DEV { get; set; }
        public string OX_SS_DB_CONNECTIONSTRING_TEST { get; set; }
        public string OX_SS_DB_CONNECTIONSTRING_STAGING { get; set; }
        public string OX_SS_DB_CONNECTIONSTRING_PROD { get; set; }
        public string ASPNETCORE_ENVIRONMENT { get; set; }
        public bool IsDevelopment 
            => ASPNETCORE_ENVIRONMENT.Equals(Development, StringComparison.CurrentCultureIgnoreCase);
    };

    public class OxSubSuppliersApplicationSettings
    {
        public Development Development { get; set; }
        public Production Production { get; set; }
    }

    public class Development
    {
        public Mailingservice MailingService { get; set; }
        public Serviceurls ServiceUrls { get; set; }
    }

    public class Mailingservice
    {
        public string Smtp { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
    }

    public class Serviceurls
    {
        public string JobServiceUrl { get; set; }
    }

    public class Production
    {
        public Mailingservice MailingService { get; set; }
        public Serviceurls ServiceUrls { get; set; }
    }
}
