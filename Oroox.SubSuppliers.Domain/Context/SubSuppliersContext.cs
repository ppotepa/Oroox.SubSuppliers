using Faithlife.Utility;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Domain.Utilities;
using Oroox.SubSuppliers.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain.Context
{
    public class SubSuppliersContext : DbContext, IApplicationContext
    {            
        private readonly Type[] currentAssemblyTypes;
        private readonly Guid EnumerationNamespace = Guid.Parse("8570b57c-2ffd-4ff3-8bd8-6411fc052822");
        private readonly OxSuppliersEnvironmentVariables environmentVariables;
        private readonly bool LoggingEnabled;
        private readonly string outputFileName;
        private readonly IServiceProvider serviceProvider;
        private Type[] _currentEntities = default;
        private SubSuppliersContextEnumerations _enumerations;

        public SubSuppliersContext() : base()
        {
            outputFileName = $"ef.migrations-{FormattedDateTime}.output.log";
            this.LoggingEnabled = true;

            IConfigurationRoot configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(configuration)
                .AddSingleton(this)
                .BuildServiceProvider();

            environmentVariables = configuration.GetEnvironmentVariables();
            currentAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes();            
        }

        public SubSuppliersContext(bool enableLogging = false) : base()
        {
            this.LoggingEnabled = enableLogging;

            IConfigurationRoot configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(configuration)
                .AddSingleton(this)
                .BuildServiceProvider();

            environmentVariables = configuration.GetEnvironmentVariables();
            outputFileName = $"ef.migrations-{FormattedDateTime}.output.log";
            currentAssemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            Database.EnsureCreated();
        }
        public DbSet<CustomerAdditionalInfo> CustomerAdditionalInfos { get; set; }

        public SubSuppliersContextEnumerations Enumerations
        {
            get
            {
                if (_enumerations is null)
                {
                    _enumerations = new SubSuppliersContextEnumerations
                    (
                        this.CompanySizeTypes.ToDictionary(type => type.Value, instance => instance),
                        this.CountryCodeTypes.ToDictionary(type => type.Value, instance => instance),
                        this.AddressTypes.ToDictionary(type => type.Value, instance => instance),
                        this.OtherTechnologies.ToDictionary(type => type.Value, instance => instance),
                        this.CNCMachineAxesTypes.ToDictionary(type => type.Value, instance => instance),
                        this.Certifications.ToDictionary(type => type.Value, instance => instance)
                    );
                }
                return _enumerations;
            }
            set => _enumerations = value;
        }

        public DbSet<TurningMachine> Machines { get; set; }

        private static string FormattedDateTime => DateTime.Now.ToString("yyyy-dd-MM-HH-mm-ss");

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
        }
        #region DB_SETS
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CNCMachineAxesType> CNCMachineAxesTypes { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<TurningMachine> TurningMachines { get; set; }
        public DbSet<MillingMachine> MillingMachines { get; set; }
        public IEnumerable<object> Entries => ((IEnumerable<object>)this.ChangeTracker.Entries<Entity>()).Concat(this.ChangeTracker.Entries<IEnumerationEntity>());

        #endregion DB_SETS
        public void AttachEntity<TEntity>(TEntity entity) where TEntity : class
            => this.Attach(entity);

        public IEnumerable<EntityEntry<TEntity>> NewEntries<TEntity>() where TEntity : class
            => this.ChangeTracker.Entries<TEntity>().Where(entry => entry.State is EntityState.Added);

        public IEnumerable<EntityEntry> NewEntries() =>
           this.ChangeTracker.Entries<Entity>().Where(entry => entry.State is EntityState.Added);

        EnumerationEntity<TEnumType> IApplicationContext.ResolveEnum<TEnumType>(int value) 
            => this.Find(typeof(EnumerationEntity<TEnumType>), new object[] { value }) as EnumerationEntity<TEnumType>;

        public async override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            DateTime currentDateTime = DateTime.Now;
            IEnumerable<EntityEntry<Entity>> entities = ChangeTracker.Entries<Entity>();
            
            entities.ForEach(entry =>
            {
                var dynamicEntry = entry as dynamic;

                if (dynamicEntry.State is EntityState.Added)
                {
                    dynamicEntry.Entity.CreatedOn = currentDateTime;
                }

                if (dynamicEntry.State is EntityState.Modified)
                {
                    dynamicEntry.Entity.ModifiedOn = currentDateTime;
                }

                if (entry.State is EntityState.Deleted)
                {
                    dynamicEntry.Entity.MarkAsDeleted();
                    dynamicEntry.Entity.DeletedOn = currentDateTime;
                    entry.State = EntityState.Modified;
                }
            });

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            optionsBuilder.EnableSensitiveDataLogging();

            if (LoggingEnabled)
            {
                optionsBuilder.LogTo(text => File.AppendAllText(outputFileName, text));
            }

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(environmentVariables.OX_SS_DB_CONNECTIONSTRING_DEV);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            GenerateCustomersTable(modelBuilder);
            AddGenericEntityFilter(modelBuilder);
            GenerateAddressTable(modelBuilder);
            GenerateEnumerationTables(modelBuilder);
            GenerateMachineTable(modelBuilder);            
        }

        private static string GetEnumUniqueName(object value, Type currentEnum)
            => Enum.GetName(currentEnum, value) + "_" + value.ToString();

        private void AddGenericEntityFilter(ModelBuilder modelBuilder)
        {
            
            CurrentEntities.Where(e => e.BaseType == typeof(Entity)).ForEach(entity =>
            {
                dynamic expression = ExpressionMethod(entity).Invoke(this, null);
                modelBuilder.Entity(entity).HasQueryFilter(expression);
            });
        }

        private MethodInfo ExpressionMethod(Type entity) => this.GetType()
                          .GetMethod(nameof(GetGlobalFilterExpression), BindingFlags.Instance | BindingFlags.NonPublic)
                          .MakeGenericMethod(entity);

        private void GenerateAddressTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasOne(x => x.AddressType);
            modelBuilder.Entity<Address>().HasOne(x => x.Customer);
            modelBuilder.Entity<Address>().HasOne(x => x.CountryCodeType);
        }

        private void GenerateMachineTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CNCMachineAxesType>()
                .HasMany(x => x.MillingMachines)
                .WithOne(x => x.CNCMachineAxesType)
                .HasForeignKey(x => x.CNCMachineAxesTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CNCMachineAxesType>()
                .HasMany(x => x.TurningMachines)
                .WithOne(x => x.CNCMachineAxesType)
                .HasForeignKey(x => x.CNCMachineAxesTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TurningMachine>().HasDiscriminator(x => x.MachineTypeName);            
            modelBuilder.Entity<MillingMachine>().HasDiscriminator(x => x.MachineTypeName);
        }

        private void GenerateCustomersTable(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasKey(x => new string [] { nameof(x.Id), nameof(x.EmailAddress) });
            builder.Entity<Customer>().HasOne(x => x.CompanySizeType);
            builder.Entity<Customer>().HasMany(x => x.Addresses).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Customer>().HasMany(x => x.Machines).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);            
            builder.Entity<Customer>().HasOne(x => x.CustomerAdditionalInfo).WithOne(x => x.Customer).HasForeignKey<CustomerAdditionalInfo>(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Customer>().HasMany(x => x.Certifications).WithMany(x => x.Customers);
            builder.Entity<Customer>().HasMany(x => x.OtherTechnologies).WithMany(x => x.Customers);
         
            builder.Entity<Customer>().HasOne(x => x.Registration).WithOne(x => x.Customer).HasForeignKey<Registration>(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            
            //builder.Entity<Customer>().HasMany(x => x.Machines).WithOne(x => x.Customer).HasForeignKey<Machine>(x => x.CustomerId).ond            
            builder.Entity<CustomerAdditionalInfo>().HasOne(x => x.Customer).WithOne(x => x.CustomerAdditionalInfo).HasForeignKey<CustomerAdditionalInfo>(x => x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<CustomerAdditionalInfo>().Property(x => x.Id).ValueGeneratedOnAdd();
        }

        private void GenerateEnumerationTables(ModelBuilder builder)
        {
            Type[] enumerationEntities = EnumerationUtility.GetCurrentAssemblyEnumerations();
            Type[] currentAssemblyEnums = EnumerationUtility.GetCurrentAssemblyEnumerationTypes();

            enumerationEntities.ForEach((entity, index) =>
            {
                Type currentEnum = currentAssemblyEnums[index];

                var currentEnumDataSeed = Enum.GetValues(currentEnum).Cast<object>()
                .Select(value =>
                {
                    return new
                    {
                        Id = GuidUtility.Create(this.EnumerationNamespace, GetEnumUniqueName(value, currentEnum)), 
                        Value = Convert.ChangeType(value, currentEnum),
                        Name = Enum.GetName(currentEnum, value)
                    };
                })
                .ToArray();

                builder.Entity(entity).HasKey(new[] { "Id" });
                builder.Entity(entity).HasData(currentEnumDataSeed);
            });
        }

        private Expression<Func<TEntity, bool>> GetGlobalFilterExpression<TEntity>() where TEntity : Entity
            => (entity) => EF.Property<bool>(entity, "Deleted").Equals(false);

        void IApplicationContext.Update<TEntity>(TEntity entity) 
            => this.Update(entity);

        public void Detach<TEntity>(TEntity entity) where TEntity : Entity
        {
            this.Entry(entity).State = EntityState.Detached;
        }

        public void BeginTransaction() =>
            this.Database.BeginTransaction();

        public void CommitTransaction() =>
            this.Database.CommitTransaction();

        public void RollBack() 
            => this.Database.RollbackTransaction();
        
    }
}
