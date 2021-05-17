using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Utilities;
using Oroox.SubSuppliers.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public interface IApplicationContext
    {
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MillingMachineType> MillingMachineDimensionsTypes { get; set; }
        public DbSet<MillingMachine> MillingMachineTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }

    public class SubSuppliersContext : DbContext, IApplicationContext
    {
        private const string EnumerationClassName = "EnumerationEntity`1";
        private readonly IConfiguration configuration;
        private readonly Type[] currentAssemblyTypes;
        private readonly OxSuppliersEnvironmentVariables environmentVariables;
        private readonly bool LoggingEnabled;
        private readonly string outputFileName;
        private readonly IServiceProvider serviceProvider;
        public SubSuppliersContext(bool enableLogging = false) : base()
        {
            this.LoggingEnabled = enableLogging;

            configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(configuration)
                .AddSingleton(this)
                .BuildServiceProvider();

            environmentVariables = configuration.GetEnvironmentVariables();
            outputFileName = $"ef.migrations-{FormattedDateTime}.output.log";
            currentAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
        }


        private static string FormattedDateTime => DateTime.Now.ToString("yyyy-dd-MM-HH-mm-ss");

        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MillingMachineType> MillingMachineDimensionsTypes { get; set; }
        public DbSet<MillingMachine> MillingMachineTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (LoggingEnabled)
            {
                builder.LogTo(text => File.AppendAllText(outputFileName, text));
            }

            builder.UseSqlServer(environmentVariables.OX_SS_DB_CONNECTIONSTRING_DEV);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            GenerateCustomersTable(builder);
            GenerateEnumerationTables(builder);
        }

        private void GenerateAddressTable(ModelBuilder builder)
        {
            builder.Entity<Address>().HasOne(x => x.AddressType);
            builder.Entity<Address>().HasOne(x => x.Customer);
            builder.Entity<Address>().HasOne(x => x.CountryCodeType);
        }
       
        private void GenerateCustomersTable(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasKey(x => x.Id);
            builder.Entity<Customer>().HasOne(x => x.CompanySizeType);
            builder.Entity<Customer>().HasMany(x => x.Addresses).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            builder.Entity<Customer>().HasMany(x => x.MillingMachines).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            builder.Entity<Customer>().HasMany(x => x.TurningMachines).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            builder.Entity<Customer>().HasOne(x => x.CustomerAdditionalInfo).WithOne(x => x.Customer).HasForeignKey<CustomerAdditionalInfo>(x => x.CustomerId);
            builder.Entity<Customer>().HasMany(x => x.Certifications).WithMany(x => x.Customers);
            builder.Entity<Customer>().HasMany(x => x.OtherTechnologies).WithMany(x => x.Customers);
        }

        private void GenerateEnumerationTables(ModelBuilder builder)
        {
            List<Type> enumerationEntities = currentAssemblyTypes
                 .Where(type => type.GetInterfaces().Contains(typeof(IEnumerationEntity)) && type.Name != EnumerationClassName)
                 .ToList();

            Type[] currentAssemblyEnums = currentAssemblyTypes.Where(type => type.IsEnum).ToArray();

            enumerationEntities.ForEach((entity, index) =>
            {
                Type currentEnum = currentAssemblyEnums[index];

                var currentEnumDataSeed = Enum.GetValues(currentEnum).Cast<object>().Select(value => new
                {
                    Id = Guid.NewGuid(),
                    Value = value,
                    Name = Enum.GetName(currentEnum, value),
                })
                .ToArray();

                builder.Entity(entity).HasAlternateKey("Value");                
                builder.Entity(entity).HasData(currentEnumDataSeed);
            });
        }
    }
}
