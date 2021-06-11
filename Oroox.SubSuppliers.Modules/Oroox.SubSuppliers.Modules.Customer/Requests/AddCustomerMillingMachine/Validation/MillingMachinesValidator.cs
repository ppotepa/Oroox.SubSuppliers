using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Validation
{

    public class ValidateTurningMachine : AbstractValidator<AddCustomerMillingMachineRequest>
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

            RuleFor(x => x.MillingMachines.Select(x => x.MachineNumber)).NotNull().NotEmpty();

            RuleForEach(x => x.MillingMachines)
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

        private bool HaveNameSpecified(MillingMachine machine) => string.IsNullOrEmpty(machine.Name);

        private bool HaveNonNegativeDimensions(MillingMachine machine) 
            => machine.Dimensions.All(x => x.value > 0);

        private bool Exist(Guid customerId)
                => this.context.Customers.AsQueryable().Any(x => x.Id == customerId);
    }

}
