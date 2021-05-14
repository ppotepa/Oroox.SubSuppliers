using Oroox.SubSuppliers.Core.Abstractions;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Address : Entity
    {
        public AddressType AddressType { get; set; }
        public CountryCode CountryCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Website { get; set; }
    }
}
