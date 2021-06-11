using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachine.Validation
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
                        $"{ string.Join(", ", machine.Dimensions.Where(dimendions => dimendions.Value < 0).Select(dimensions => dimensions.PropertyName)) }";
                });
        }

        private bool HaveNameSpecified(TurningMachine machine) 
            => string.IsNullOrEmpty(machine.Name);

        private bool HaveNonNegativeDimensions(TurningMachine machine) 
            => machine.Dimensions.All(machineDimensions => machineDimensions.Value > 0);


        private bool Exist(Guid customerId)
            => this.context.Customers.AsQueryable().Any(x => x.Id == customerId);
    }
}
