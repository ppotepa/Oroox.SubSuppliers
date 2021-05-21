﻿using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Modules.Customers.Responses;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerRequestResponse>
    {
        private readonly SubSuppliersContextEnumerations enumerations;
        public CreateCustomerRequest() { }
        public CreateCustomerRequest(IApplicationContext context) 
        {
            this.enumerations = context.Enumerations;
        }
        public Customer Customer { get; set; }
        public CreateCustomerRequest Mock() => new CreateCustomerRequest
        {
            Customer = new Domain.Entities.Customer
            {
                CompanyName = "Some nice company name",
                EmailAddress = $"potepa.pawel{new Random().Next(1, 10000)}@gmail.com",
                RegistrationNumber = "01/01/01",
                Password = "password132",
                PasswordConfirmation = "password132",
                CompanySizeType = enumerations.CompanyTypes[CompanySizeTypeEnum.LessThan10],
                MillingMachines = new MillingMachine[]
                {
                    new MillingMachine
                    {
                        MillingMachineDimensionsType = enumerations.MillingMachineDimensionsTypes[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        MillingMachineType = enumerations.MillingMachineTypes[MillingMachineTypeEnum.TYPE_3],
                    },
                },
                TurningMachines = new TurningMachine[]
                {
                    new TurningMachine
                    {
                        TurningMachineType = enumerations.TurningMachineTypes[Domain.TurningMachineTypeEnum.TURNING_MACHINE_TYPE_4],
                    }
                }
            }
        };
    }
}
