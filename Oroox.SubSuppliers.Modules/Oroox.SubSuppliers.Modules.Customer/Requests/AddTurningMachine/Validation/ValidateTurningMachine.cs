using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine.Validation
{
    public class ValidateTurningMachine : AbstractValidator<TurningMachine>
    {
        private readonly IApplicationContext context;
        public ValidateTurningMachine(IApplicationContext context)
        {
            this.context = context;
            this.CascadeMode = CascadeMode.Stop;

            RuleFor(x => x.CustomerId).NotNull().NotEmpty().Must(Exist);
            RuleFor(x => x.MachineNumber).NotNull().NotEmpty();
            RuleFor(x => x.TurningMachineType).NotNull().NotEmpty();
        }

        private bool Exist(Guid customerId)
            => this.context.Customers.AsQueryable().Any(x => x.Id == customerId);
    }
}
