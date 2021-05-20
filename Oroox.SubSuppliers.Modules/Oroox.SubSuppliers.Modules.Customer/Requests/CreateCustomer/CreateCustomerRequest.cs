using AutoMapper;
using AutoMapper.Configuration.Annotations;
using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.User.Responses;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer
{
    [AutoMap(typeof(CreateCustomer))]
    public class CreateCustomerModel
    {
        
        public CreateCustomerDTO Customer { get; set; }
    }
    
    public class CreateCustomer : IRequest<CreateCustomerRequestResponse>
    {
        [SourceMember(nameof(CreateCustomerModel.Customer))]
        public Customer Customer { get; set; }
    }

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
