using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Enumerations
{
    public class SubSuppliersContextEnumerations
    {
        public Dictionary<CompanySizeTypeEnum, CompanySizeType> CompanyTypes;
        public Dictionary<CountryCodeTypeEnum, CountryCodeType> CountryCodes;
        public Dictionary<AddressTypeEnum, AddressType> AddressTypes;
        public Dictionary<OtherTechnologyTypeEnum, OtherTechnology> OtherTechnologies;
        public Dictionary<MillingMachineTypeEnum, MillingMachineType> MillingMachines;
        public Dictionary<MillingMachineDimensionsTypeEnum, MillingMachineDimensionsType> MillingMachineDimensionsTypes;
        public Dictionary<CertificationTypeEnum, Certification> Certifications;

        public SubSuppliersContextEnumerations(Dictionary<CompanySizeTypeEnum, CompanySizeType> companyTypes, Dictionary<CountryCodeTypeEnum, CountryCodeType> countryCodes, Dictionary<AddressTypeEnum, AddressType> addressTypes, Dictionary<OtherTechnologyTypeEnum, OtherTechnology> otherTechnologies, Dictionary<MillingMachineTypeEnum, MillingMachineType> millingMachines, Dictionary<MillingMachineDimensionsTypeEnum, MillingMachineDimensionsType> millingMachineDimensionsTypes, Dictionary<CertificationTypeEnum, Certification> certifications)
        {
            this.CompanyTypes = companyTypes;
            this.CountryCodes = countryCodes;
            this.AddressTypes = addressTypes;
            this.OtherTechnologies = otherTechnologies;
            this.MillingMachines = millingMachines;
            this.MillingMachineDimensionsTypes = millingMachineDimensionsTypes;
            this.Certifications = certifications;
        }
    }
}
