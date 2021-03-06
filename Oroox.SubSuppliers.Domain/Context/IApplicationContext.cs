using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain.Context
{
    public interface IApplicationContext 
    {
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public ChangeTracker ChangeTracker { get; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<CustomerAdditionalInfo> CustomerAdditionalInfos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<CNCMachineAxesType> CNCMachineAxesTypes { get; set; }
        public DbSet<TurningMachine> Machines { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }
        public SubSuppliersContextEnumerations Enumerations { get; set; }
        void Update<TEntity>(TEntity entity) where TEntity : Entity;
        void Detach<TEntity>(TEntity entity) where TEntity : Entity;
        public DbSet<Registration> Registrations { get; set; }
        public EntityEntry<TEntity> AttachEntity<TEntity>(TEntity entity) where TEntity : class;
        public EntityEntry AttachEntity(object entity);
        public EnumerationEntity<TEnumType> ResolveEnum<TEnumType>(int value) where TEnumType : Enum;
        public int SaveChanges();
        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        public IEnumerable<EntityEntry<TEntity>> NewEntries<TEntity>() where TEntity : class;
        public IEnumerable<EntityEntry> NewEntries();
        public IEnumerable<object> Entries { get; }
        public DatabaseFacade DataBase { get; }
        public DbSet<SharedJob> SharedJobs { get; set; }

        public void BeginTransaction();
        public void CommitTransaction();
        void RollBack();
    }
}

