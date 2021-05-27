using Faithlife.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Oroox.SubSuppliers.Domain.Context
{
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
        private readonly Guid EnumerationNamespace = Guid.Parse("8570b57c-2ffd-4ff3-8bd8-6411fc052822");
        private SubSuppliersContextEnumerations _enumerations;

        public SubSuppliersContext() : base()
        {
            configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(configuration)
                .AddSingleton(this)
                .BuildServiceProvider();

            environmentVariables = this.configuration.GetEnvironmentVariables();
            outputFileName = $"ef.migrations-{FormattedDateTime}.output.log";
            currentAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
        }
        public SubSuppliersContext(bool enableLogging = false) : base() 
        {
            this.LoggingEnabled = enableLogging;

            configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(configuration)
                .AddSingleton(this)
                .BuildServiceProvider();

            environmentVariables = this.configuration.GetEnvironmentVariables();
            outputFileName = $"ef.migrations-{FormattedDateTime}.output.log";
            currentAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
        }

        #region DB_SETS
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<MillingMachineDimensionsType> MillingMachineDimensionsTypes { get; set; }
        public DbSet<MillingMachineType> MillingMachineTypes { get; set; }
        public DbSet<TurningMachineType> TurningMachineTypes { get; set; }
        public DbSet<TurningMachine> TurningMachines { get; set; }
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
                        this.TurningMachineTypes.ToDictionary(type => type.Value, instance => instance),
                        this.Certifications.ToDictionary(type => type.Value, instance => instance)
                    );
                }
                return _enumerations;
            }

            set => _enumerations = value;
        }
        private static string FormattedDateTime => DateTime.Now.ToString("yyyy-dd-MM-HH-mm-ss");

        public DbSet<CustomerAdditionalInfo> CustomerAdditionalInfos { get; set; }

        private MethodInfo ExpressionMethod(Type entity)
        {
            return this.GetType()
                          .GetMethod(nameof(GetGlobalFilterExpression), BindingFlags.NonPublic | BindingFlags.Instance)
                          .MakeGenericMethod(entity);
        }
        

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
            builder.Entity<Customer>().HasMany(x => x.Addresses).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.ClientCascade);
            builder.Entity<Customer>().HasMany(x => x.MillingMachines).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.ClientCascade);
            builder.Entity<Customer>().HasMany(x => x.TurningMachines).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.ClientCascade);
            builder.Entity<Customer>().HasOne(x => x.CustomerAdditionalInfo).WithOne(x => x.Customer).HasForeignKey<CustomerAdditionalInfo>(x => x.CustomerId).OnDelete(DeleteBehavior.ClientCascade);
            builder.Entity<Customer>().HasMany(x => x.Certifications).WithMany(x => x.Customers);
            builder.Entity<Customer>().HasMany(x => x.OtherTechnologies).WithMany(x => x.Customers);
            builder.Entity<Customer>().HasOne(x => x.Registration).WithOne(x => x.Customer).HasForeignKey<Registration>(x => x.CustomerId).OnDelete(DeleteBehavior.ClientCascade);
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
                    Id = GuidUtility.Create(this.EnumerationNamespace, GetEnumUniqueName(value, currentEnum)),
                    Value = Convert.ChangeType(value, currentEnum),
                    Name = Enum.GetName(currentEnum, value),
                }).ToArray();

                builder.Entity(entity).HasAlternateKey("Value");
                builder.Entity(entity).HasData(currentEnumDataSeed);
            });
        }

        private static string GetEnumUniqueName(object value, Type currentEnum) 
            => Enum.GetName(currentEnum, value) + "_" + value.ToString();
      
        private Expression<Func<TEntity, bool>> GetGlobalFilterExpression<TEntity>() where TEntity : Entity 
            => entity => EF.Property<bool>(entity, "Deleted").Equals(false);

        EnumerationEntity<TEnumType> IApplicationContext.ResolveEnum<TEnumType>(int value)
        {
            return this.Find(typeof(EnumerationEntity<TEnumType>), new object[] { value }) as EnumerationEntity<TEnumType>;
        }

        public void AttachEntity<TEntity>(TEntity entity) where TEntity : class
            => this.Attach(entity);
        
    }
}
