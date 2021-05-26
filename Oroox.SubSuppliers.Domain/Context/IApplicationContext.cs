using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain.Context
{
    public interface IApplicationContext
    {
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MillingMachineDimensionsType> MillingMachineDimensionsTypes { get; set; }
        public DbSet<CustomerAdditionalInfo> CustomerAdditionalInfos { get; set; }
        public DbSet<MillingMachineType> MillingMachineTypes { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }
        public SubSuppliersContextEnumerations Enumerations { get; set; }
        public int SaveChanges();
        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        public EnumerationEntity<TEnumType> ResolveEnum<TEnumType>(int value) where TEnumType : Enum;
       
    }
}
