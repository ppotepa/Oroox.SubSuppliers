using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest.Validation
{
    public class ValidateTurningMachine : AbstractValidator<AddCustomerTurningMachineRequest>
    {
        private readonly IApplicationContext context;
        public ValidateTurningMachine(IApplicationContext context)
        {
            this.context = context;
            this.CascadeMode = CascadeMode.Stop;

            RuleFor(x => x.CustomerId)
                .NotNull()
                .NotEmpty()
                .Must(Exist)
                .WithMessage(x => $"Customer with id {x.CustomerId} does not exist");

            RuleFor(x => x.TurningMachines.Select(x => x.MachineNumber)).NotNull().NotEmpty();
           
            RuleForEach(x => x.TurningMachines)
                .NotNull()
                .NotEmpty()
                .Must(HaveNonNegativeDimensions)
                .Must(HaveNameSpecified)
                .WithMessage((request, machine) =>
                {
                    return 
                        $"Invalid dimensions for machine with name : " +
                        $"[{ machine.Name }],\\n Wrong Dimensions : " +
                        $"{ string.Join(", ", machine.Dimensions.Where(x => x.value < 0).Select(x => x.propertyName)) }";
                });
        }

        private bool HaveNameSpecified(TurningMachine machine) 
            => string.IsNullOrEmpty(machine.Name);

        private bool HaveNonNegativeDimensions(TurningMachine machine)
        {
            return new[]
            {
                machine.XMax,
                machine.XMin,
                machine.YMin,
                machine.YMax,
            }
            .All(number => number > 0);
        }

        private bool Exist(Guid customerId)
            => this.context.Customers.AsQueryable().Any(x => x.Id == customerId);
    }
}
