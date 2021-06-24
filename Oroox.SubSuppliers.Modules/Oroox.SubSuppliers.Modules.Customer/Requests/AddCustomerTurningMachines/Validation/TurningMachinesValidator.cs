using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Validation
{
    public class TurningMachinesValidator : AbstractValidator<AddCustomerTurningMachinesRequest>
    {
        private readonly IApplicationContext context;
        public TurningMachinesValidator(IApplicationContext context)
        {
            this.context = context;
            this.CascadeMode = CascadeMode.Stop;

            RuleFor(x => x.CustomerId)
                .NotNull()
                .NotEmpty()
                .Must(Exist)
                .WithMessage(x => $"Customer with id {x.CustomerId} does not exist");

            RuleFor(x => x.TurningMachines.Select(x => x.MachineNumber)).NotNull().NotEmpty();

            RuleForEach(x => x.TurningMachines).NotNull().WithMessage("Turning machine was null.");
            RuleForEach(x => x.TurningMachines).NotEmpty().WithMessage("Turning machine was empty.");
            RuleForEach(x => x.TurningMachines).Must(HaveNonNegativeDimensions).WithMessage("Turning machine was empty.").WithMessage((request, machine) =>
            {
                var message = $"Invalid dimensions for machine with name : " +
                    $"[{ machine.Name }],\\n Wrong Dimensions : " +
                    $"{ string.Join(", ", machine.Dimensions.Where(dimensions => dimensions.Value < 0).Select(dimensions => dimensions.PropertyName)) }";

                return message;
            });

            RuleForEach(x => x.TurningMachines).Must(HaveNameSpecified).WithMessage("Turning machine name was empty.");
        }

        private bool HaveNameSpecified(TurningMachine machine) 
            => string.IsNullOrEmpty(machine.Name) is false;

        private bool HaveNonNegativeDimensions(TurningMachine machine) 
            => machine.Dimensions.All(machineDimensions => machineDimensions.Value > 0);


        private bool Exist(Guid customerId)
            => this.context.Customers.AsQueryable().Any(x => x.Id == customerId);
    }
}
