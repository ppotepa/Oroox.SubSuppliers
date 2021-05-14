using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Utilities;
using Oroox.SubSuppliers.Utilities.Extensions;
using System;
using System.IO;

namespace Oroox.SubSuppliers.Domain
{
    public class SubSuppliersContext : DbContext
    {
        private readonly IConfiguration configuration;
        private readonly ServiceProvider serviceProvider;

        private readonly OxSuppliersEnvironmentVariables environmentVariables;
        private readonly string outputFileName;

        public DbSet<Customer> Customers { get; set; }

        private static string FormattedDateTime => DateTime.Now.ToString("yyyy-dd-MM-HH-mm-ss");

        public SubSuppliersContext() : base()
        {
            configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(configuration)
                .AddSingleton(this)
                .BuildServiceProvider();

            environmentVariables = configuration.GetEnvironmentVariables();
            outputFileName = $"ef.migrations-{FormattedDateTime}.output.log";
        }
     
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.LogTo(text => File.AppendAllText(outputFileName, text));            
            builder.UseSqlServer(environmentVariables.OX_SS_DB_CONNECTIONSTRING_DEV);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
    }
}
