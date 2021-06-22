using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Extensions;
using System.Linq;

namespace Oroox.SubSuppliers.Domain.Context
{
    public partial class SubSuppliersContext : DbContext, IApplicationContext
    {
        private SubSuppliersContextEnumerations _enumerations;
        
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CNCMachineAxesType> CNCMachineAxesTypes { get; set; }
        public DbSet<CountryCodeType> CountryCodeTypes { get; set; }
        public DbSet<CompanySizeType> CompanySizeTypes { get; set; }
        public DbSet<SharedJobStatusType> SharedJobStatusTypes { get; set; }
        public DbSet<OtherTechnology> OtherTechnologies { get; set; }
        public DbSet<SharedJobRejectionReasonType> SharedJobRejectionReasonTypes { get; set; }
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
                        this.Certifications.ToDictionary(type => type.Value, instance => instance),
                        this.SharedJobStatusTypes.ToDictionary(type => type.Value, instance => instance),
                        this.SharedJobRejectionReasonTypes.ToDictionary(type => type.Value, instance => instance)
                    );
                }
                return _enumerations;
            }
            set => _enumerations = value;
        }
    }
}
