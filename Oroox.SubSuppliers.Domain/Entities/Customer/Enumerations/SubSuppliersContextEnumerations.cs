using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Enumerations
{
    public class SubSuppliersContextEnumerations
    {
        public SubSuppliersContextEnumerations
        (
            Dictionary<CompanySizeTypeEnum, CompanySizeType> companySizeTypes,
            Dictionary<CountryCodeTypeEnum, CountryCodeType> countryCodeTypes,
            Dictionary<AddressTypeEnum, AddressType> addressTypes,
            Dictionary<OtherTechnologyTypeEnum, OtherTechnology> otherTechnologys,
            Dictionary<CNCMachineAxesTypeEnum, CNCMachineAxesType> cncMachineAxesTypes,
            Dictionary<CertificationTypeEnum, Certification> certifications,
            Dictionary<SharedJobStatusTypeEnum, SharedJobStatusType> sharedJobStatusTypes,
            Dictionary<SharedJobRejectionReasonTypeEnum, SharedJobRejectionReasonType> sharedJobRejectionReasonTypes)
        {
            this.CompanySizeTypes = companySizeTypes;
            this.CountryCodeTypes = countryCodeTypes;
            this.AddressTypes = addressTypes;
            this.OtherTechnologyTypes = otherTechnologys;
            this.CNCMachineAxesTypes = cncMachineAxesTypes;
            this.Certifications = certifications;
            this.SharedJobStatusTypes = sharedJobStatusTypes;
            this.SharedJobRejectionReasonTypes = sharedJobRejectionReasonTypes;
        }

        public Dictionary<CompanySizeTypeEnum, CompanySizeType> CompanySizeTypes { get; }
        public Dictionary<CountryCodeTypeEnum, CountryCodeType> CountryCodeTypes { get; }
        public Dictionary<AddressTypeEnum, AddressType> AddressTypes { get; }
        public Dictionary<OtherTechnologyTypeEnum, OtherTechnology> OtherTechnologyTypes { get; }
        public Dictionary<CNCMachineAxesTypeEnum, CNCMachineAxesType> CNCMachineAxesTypes { get; }
        public Dictionary<CertificationTypeEnum, Certification> Certifications { get; }
        public Dictionary<SharedJobStatusTypeEnum, SharedJobStatusType> SharedJobStatusTypes { get; }
        public Dictionary<SharedJobRejectionReasonTypeEnum, SharedJobRejectionReasonType> SharedJobRejectionReasonTypes { get; }
    }
}
