using AutoMapper;
using AutoMapper.Configuration.Annotations;
using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.User.Responses;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer
{
    [AutoMap(typeof(CreateCustomer))]
    public class CreateCustomerModel
    {
        [SourceMember(nameof(CreateCustomer.Customer))]
        public CreateCustomerDTO Customer { get; set; }
    }

    public class CreateCustomer : IRequest<CreateCustomerRequestResponse>
    {
        public Customer Customer { get; set; }

        public static CreateCustomer NewCreateCustomerRequest => new CreateCustomer
        {
            Customer = new Customer
            {
                CompanyName = "Some nice company name",
                EmailAddress = "potepa.pawel@gmail.com",
                RegistrationNumber = "01/01/01",
                Password = "password132",
                PasswordConfirmation = "password132",
                CompanySizeTypeId = Guid.Parse("F211E9F6-026B-452F-8E63-E25D487B5082"),
                MillingMachines = new MillingMachine[]
                {
                    new MillingMachine
                    {
                        MillingMachineDimensionsTypeId = Guid.Parse("7D328025-3D87-4CE0-BA3A-89665420FBD1"),
                        MillingMachineTypeId = Guid.Parse("4AFFE675-3615-44BF-A270-6855239AB386"),
                    },
                },
                TurningMachines = new TurningMachine[]
                {
                    new TurningMachine
                    {
                        TurningMachineTypeId = Guid.Parse("7C93A05F-4F8C-47D0-952E-7CFF6061F728"),
                    }
                }
            }
        };
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
