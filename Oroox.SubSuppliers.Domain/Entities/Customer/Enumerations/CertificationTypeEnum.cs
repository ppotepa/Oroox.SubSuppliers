using Oroox.SubSuppliers.Domain.Entities;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain
{
    public enum CertificationTypeEnum
    {
        ISO9001,
        ISO14001,
        ISO13485,
        ITAF16949,
        EN9100,
        Other
    }

    public class Certification : EnumerationEntity<CertificationTypeEnum>
    {
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
