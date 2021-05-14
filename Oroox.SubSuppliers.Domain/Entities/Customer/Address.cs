using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Address : Entity
    {
        public virtual Customer Customer { get; set; }
        public virtual Guid CustomerId { get; set; }
        public AddressType AddressType { get; set; }
        public CountryCodeType CountryCodeType { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        
    }
}
