using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public interface IApplicationContext
    {
       
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MillingMachineDimensionsType> MillingMachineDimensionsTypes { get; set; }
        public DbSet<MillingMachineType> MillingMachineTypes { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }

    public class SubSuppliersContext : DbContext, IApplicationContext
    {
        private const string EnumerationClassName = "EnumerationEntity`1";
        private readonly IConfiguration configuration;
        private readonly Type[] currentAssemblyTypes;
        private Type[] _currentEntities = default;
        private Type[] CurrentEntities
        {
            get 
            {
                if (_currentEntities is null)
                {
                    _currentEntities = currentAssemblyTypes.Where(t => t.IsSubclassOf(typeof(Entity))).ToArray();
                }
                return _currentEntities;
            }
            set => _currentEntities = value;
        }

        private readonly OxSuppliersEnvironmentVariables environmentVariables;
        private readonly bool LoggingEnabled;
        private readonly string outputFileName;
        private readonly IServiceProvider serviceProvider;
        private SubSuppliersContextEnumerations _enumerations;
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

        #region DB_SETS
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<MillingMachineDimensionsType> MillingMachineDimensionsTypes { get; set; }
        public DbSet<MillingMachineType> MillingMachineTypes { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }

        #endregion DB_SETS
        public SubSuppliersContextEnumerations Enumerations
        {
            get
            {
                if (this._enumerations is null)
                {
                    _enumerations = new SubSuppliersContextEnumerations
                    (
                        this.CompanySizeTypes.ToDictionary(type => type.Value, instance => instance),
                        this.CountryCodeTypes.ToDictionary(type => type.Value, instance => instance),
                        this.AddressTypes.ToDictionary(type => type.Value, instance => instance),
                        this.OtherTechnologies.ToDictionary(type => type.Value, instance => instance),
                        this.MillingMachineTypes.ToDictionary(type => type.Value, instance => instance),
                        this.MillingMachineDimensionsTypes.ToDictionary(type => type.Value, instance => instance),
                        this.Certifications.ToDictionary(type => type.Value, instance => instance)
                    );
                }
                return _enumerations;
            }

            set => _enumerations = value;
        }
        private static string FormattedDateTime => DateTime.Now.ToString("yyyy-dd-MM-HH-mm-ss");
        private MethodInfo ExpressionMethod(Type entity) 
            => this.GetType()
                    .GetMethod(nameof(GetGlobalFilterExpression), BindingFlags.NonPublic | BindingFlags.Instance)
                    .MakeGenericMethod(entity);
        
        public override int SaveChanges()
        {
            DateTime currentDateTime = DateTime.Now;
            List<EntityEntry<Entity>> entities = ChangeTracker.Entries<Entity>().ToList();

            entities.ForEach(entry =>
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedOn = currentDateTime;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.ModifiedOn = currentDateTime;    
                }

                if (entry.State == EntityState.Deleted)
                {
                    entry.Entity.Deleted = true;
                    entry.Entity.DeletedOn = currentDateTime;
                    entry.State = EntityState.Modified;
                }
            });

            return base.SaveChanges();
        }

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
            AddGenericEntityFilter(builder);
            GenerateAddressTable(builder);
            GenerateEnumerationTables(builder);
        }

        private void AddGenericEntityFilter(ModelBuilder builder)
        {
            CurrentEntities.ForEach(entity =>
            {
                dynamic expression = ExpressionMethod(entity).Invoke(this, null);
                builder.Entity(entity).HasQueryFilter(expression);
            });
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

        private Expression<Func<TEntity, bool>> GetGlobalFilterExpression<TEntity>() where TEntity : Entity => entity => EF.Property<bool>(entity, "Deleted").Equals(false);
    }
}
