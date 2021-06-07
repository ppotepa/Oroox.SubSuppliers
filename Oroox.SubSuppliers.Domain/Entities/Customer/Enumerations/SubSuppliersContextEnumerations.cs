using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Enumerations
{
    public class SubSuppliersContextEnumerations
    {
        public readonly Dictionary<CompanySizeTypeEnum, CompanySizeType> CompanyTypes;
        public readonly Dictionary<CountryCodeTypeEnum, CountryCodeType> CountryCodes;
        public readonly Dictionary<AddressTypeEnum, AddressType> AddressTypes;
        public readonly Dictionary<OtherTechnologyTypeEnum, OtherTechnology> OtherTechnologies;        
        public readonly Dictionary<CNCMachineAxesTypeEnum, CNCMachineAxesType> CNCAxesTypes;        
        public readonly Dictionary<CertificationTypeEnum, Certification> Certifications;

        public SubSuppliersContextEnumerations(Dictionary<CompanySizeTypeEnum, CompanySizeType> companyTypes, Dictionary<CountryCodeTypeEnum, CountryCodeType> countryCodes, Dictionary<AddressTypeEnum, AddressType> addressTypes, Dictionary<OtherTechnologyTypeEnum, OtherTechnology> otherTechnologies, Dictionary<CNCMachineAxesTypeEnum, CNCMachineAxesType> cNCAxesTypes, Dictionary<CertificationTypeEnum, Certification> certifications)
        {
            this.CompanyTypes = companyTypes;
            this.CountryCodes = countryCodes;
            this.AddressTypes = addressTypes;
            this.OtherTechnologies = otherTechnologies;
            this.CNCAxesTypes = cNCAxesTypes;
            this.Certifications = certifications;
        }
    }
}
