using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
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
}
