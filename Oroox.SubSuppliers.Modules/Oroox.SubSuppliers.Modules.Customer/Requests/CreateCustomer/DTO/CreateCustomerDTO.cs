using Oroox.SubSuppliers.Domain.Entities;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Modules.Customers.DTO
{
    public class CreateCustomerDTO 
    {
        #region UNUSED
        //public CompanySizeType CompanySizeType { get; set; }
        //public CustomerAdditionalInfo CustomerAdditionalInfo { get; set; }
        //public ICollection<Address> Addresses { get; set; }

        //public virtual ICollection<TurningMachine> TurningMachines { get; set; }
        //public virtual ICollection<OtherTechnology> OtherTechnologies { get; set; }
        //public virtual ICollection<Certification> Certifications { get; set; }
        //public string VATNumber { get; set; }
        //public string Website { get; set; }
        //public string RegistrationNumber { get; set; }
        //public string EmailAddress { get; set; }
        //public string PasswordHash { get; set; }
        #endregion UNUSED
        public ICollection<MillingMachine> MillingMachines { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string EmailAddress { get; set; }
    }
}
