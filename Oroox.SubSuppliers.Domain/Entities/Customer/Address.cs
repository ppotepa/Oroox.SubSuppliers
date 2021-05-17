using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Address : Entity
    {
        public virtual Customer Customer { get; set; }
        public virtual Guid CustomerId { get; set; }
        public AddressType AddressType { get; set; }
        public Guid AddressTypeId { get; set; }
        public CountryCodeType CountryCodeType { get; set; }
        public Guid CountryCodeTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public bool Active { get; set; }
        
    }
}
