using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Enumerations
{
    public class SubSuppliersContextEnumerations
    {
        public Dictionary<CompanySizeTypeEnum, CompanySizeType> CompanyTypes;
        public Dictionary<CountryCodeTypeEnum, CountryCodeType> CountryCodes;
        public Dictionary<AddressTypeEnum, AddressType> AddressTypes;
        public Dictionary<OtherTechnologyTypeEnum, OtherTechnology> OtherTechnologies;
        public Dictionary<MillingMachineTypeEnum, MillingMachineType> MillingMachineTypes;
        public Dictionary<MillingMachineDimensionsTypeEnum, MillingMachineDimensionsType> MillingMachineDimensionsTypes;
        public Dictionary<TurningMachineTypeEnum, TurningMachineType> TurningMachineTypes;
        public Dictionary<CertificationTypeEnum, Certification> Certifications;

        public SubSuppliersContextEnumerations(Dictionary<CompanySizeTypeEnum, CompanySizeType> companyTypes, Dictionary<CountryCodeTypeEnum, CountryCodeType> countryCodes, Dictionary<AddressTypeEnum, AddressType> addressTypes, Dictionary<OtherTechnologyTypeEnum, OtherTechnology> otherTechnologies, Dictionary<MillingMachineTypeEnum, MillingMachineType> millingMachineTypes, Dictionary<MillingMachineDimensionsTypeEnum, MillingMachineDimensionsType> millingMachineDimensionsTypes, Dictionary<TurningMachineTypeEnum, TurningMachineType> turningMachineTypes, Dictionary<CertificationTypeEnum, Certification> certifications)
        {
            this.CompanyTypes = companyTypes ?? throw new ArgumentNullException(nameof(companyTypes));
            this.CountryCodes = countryCodes ?? throw new ArgumentNullException(nameof(countryCodes));
            this.AddressTypes = addressTypes ?? throw new ArgumentNullException(nameof(addressTypes));
            this.OtherTechnologies = otherTechnologies ?? throw new ArgumentNullException(nameof(otherTechnologies));
            this.MillingMachineTypes = millingMachineTypes ?? throw new ArgumentNullException(nameof(millingMachineTypes));
            this.MillingMachineDimensionsTypes = millingMachineDimensionsTypes ?? throw new ArgumentNullException(nameof(millingMachineDimensionsTypes));
            this.TurningMachineTypes = turningMachineTypes ?? throw new ArgumentNullException(nameof(turningMachineTypes));
            this.Certifications = certifications ?? throw new ArgumentNullException(nameof(certifications));
        }
    }
}
