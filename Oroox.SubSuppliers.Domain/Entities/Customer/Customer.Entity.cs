using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public partial class Customer : Entity
    {
        public Customer() { }
        public Customer
        (
             string companyName,
             CompanySizeType companySizeType,
             ICollection<Address> addresses,
             ICollection<Machine> machines,             
             string vatNumber,
             string website,
             string registrationNumber,
             string emailAddress
        )
        {
            CompanyName = companyName;
            CompanySizeType = companySizeType;
            Addresses = addresses;
            Machines = machines;            
            VATNumber = vatNumber;
            Website = website;
            RegistrationNumber = registrationNumber;
            EmailAddress = emailAddress;
        }

        public string CompanyName { get; set; }
        public virtual CompanySizeType CompanySizeType { get; set; }
        public virtual CustomerAdditionalInfo CustomerAdditionalInfo { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }        
        public virtual ICollection<OtherTechnology> OtherTechnologies { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
        public virtual Registration Registration { get; set; }
        public string VATNumber { get; set; }
        public string Website { get; set; }        
        public string RegistrationNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }

        [NotMapped]
        public string PasswordConfirmation { get; set; }

        [NotMapped]
        public string Password { get; set; }

        #region FOREIGN_KEYS
        public Guid CompanySizeTypeId { get; set; }
        #endregion
    }
}
