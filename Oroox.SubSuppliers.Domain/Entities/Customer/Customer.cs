using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer()
        {
        }

        public Customer(string companyName, CompanySizeType companySizeType, ICollection<Address> addresses, ICollection<MillingMachine> millingMachines, ICollection<TurningMachine> turningMachines, string vATNumber, string website, string registrationNumber, string emailAddress)
        {
            CompanyName = companyName;
            CompanySizeType = companySizeType;
            Addresses = addresses;
            MillingMachines = millingMachines;
            TurningMachines = turningMachines;            
            VATNumber = vATNumber;
            Website = website;
            RegistrationNumber = registrationNumber;
            EmailAddress = emailAddress;
        }

        public string CompanyName { get; set; }
        public virtual CompanySizeType CompanySizeType { get; set; }
        public virtual CustomerAdditionalInfo CustomerAdditionalInfo { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<MillingMachine> MillingMachines { get; set; }
        public virtual ICollection<TurningMachine> TurningMachines { get; set; }        
        public virtual ICollection<OtherTechnology> OtherTechnologies { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
        public string VATNumber { get; set; }
        public string Website { get; set; }
        public string RegistrationNumber { get; set; }
        public string EmailAddress { get; set; }

        #region FOREIGN_KEYS
        public Guid CompanySizeTypeId { get; internal set; }
        public Guid CustomerAdditionalInfoId { get; internal set; }
        #endregion
    }

    public class CustomerAdditionalInfo : Entity
    {
        public string SpecialTolerances { get; set; }
        public double? AverageMinimalSurfaceQualitiesTurning { get; set; }
        public double? AverageMinimalSurfaceQualitiesMilling { get; set; }
        public double? AverageAndFastestLeadTimeTurning { get; set; }
        public double? AverageAndFastestLeadTimeMilling { get; set; }
        public double? AverageWorkingHoursPerWeek { get; set; }
        public int? WorkingShiftsPerDay { get; set; }
        public bool? CanUseStepFiles { get; set; }
        public string SpecialCharacteristics { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; internal set; }
    }
}
