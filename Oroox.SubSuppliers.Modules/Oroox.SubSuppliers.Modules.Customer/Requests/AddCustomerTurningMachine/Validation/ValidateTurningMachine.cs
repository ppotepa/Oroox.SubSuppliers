using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
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

            RuleFor(x => x.CustomerId).NotNull().NotEmpty().Must(Exist).WithMessage(x => $"Customer with id {x.CustomerId} does not exist");
            RuleFor(x => x.TurningMachines.Select(x => x.MachineNumber)).NotNull().NotEmpty();            
        }

        private bool Exist(Guid customerId)
            => this.context.Customers.AsQueryable().Any(x => x.Id == customerId);
    }
}
