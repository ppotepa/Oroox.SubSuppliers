using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer()
        {
        }

        public Customer(string companyName, CompanySizeType companySize, Address address, ICollection<MillingMachine> millingMachines, ICollection<TurningMachine> turningMachines, string vATNumber, string website, string registrationNumber, string emailAddress)
        {
            CompanyName = companyName;
            CompanySize = companySize;
            Address = address;
            MillingMachines = millingMachines;
            TurningMachines = turningMachines;            
            VATNumber = vATNumber;
            Website = website;
            RegistrationNumber = registrationNumber;
            EmailAddress = emailAddress;
        }

        public string CompanyName { get; set; }
        public CompanySizeType CompanySize { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<MillingMachine> MillingMachines { get; set; }
        public virtual ICollection<TurningMachine> TurningMachines { get; set; }        
        public virtual ICollection<OtherTechnology> OtherTechnologies { get; set; }
        public string VATNumber { get; set; }
        public string Website { get; set; }
        public string RegistrationNumber { get; set; }
        public string EmailAddress { get; set; }
    }

    public class CustomerAdditionalInfo : Entity
    {
        public string? SpecialTolerances { get; set; }
        public double? AverageMinimalSurfaceQualitiesTurning { get; set; }
        public double? AverageMinimalSurfaceQualitiesMilling { get; set; }
        public double? AverageAndFastestLeadTimeTurning { get; set; }
        public double? AverageAndFastestLeadTimeMilling { get; set; }
        public double? AverageWorkingHoursPerWeek { get; set; }
        public int? WorkingShiftsPerDay { get; set; }
        public bool? CanUseStepFiles { get; set; }
        public string SpecialCharacteristics { get; set; }
    }
}
