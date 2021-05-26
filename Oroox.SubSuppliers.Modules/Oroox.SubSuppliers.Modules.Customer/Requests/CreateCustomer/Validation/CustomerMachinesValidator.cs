﻿using FluentValidation;
using FluentValidation.Results;
using Oroox.SubSuppliers.Modules.Customers.Requests;
using Serilog;
using System.Linq;
using System.Text.RegularExpressions;

namespace Oroox.SubSuppliers.Modules.Customers.Validation
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerMachinesValidator : AbstractValidator<CreateCustomerRequest>
    {
        private readonly Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private readonly ILogger logger;
        public CustomerMachinesValidator(ILogger logger)
        {
            this.logger = logger;

            this.CascadeMode = CascadeMode.Stop;

            RuleFor(request => request).NotNull();
            RuleFor(request => request.Customer).NotNull();            

            When(x => x != null && x.Customer != null, () => 
            {

                RuleFor(request => request.Customer.TurningMachines.Count + request.Customer.MillingMachines.Count)
                .Must(x => x > 0)
                .WithMessage("Please specify at least one machine.");

                When(request => request.Customer.TurningMachines != null && request.Customer.TurningMachines.Count > 0, () =>
                {
                    //RuleFor(request => request.Customer.TurningMachines).NotNull()
                    //                .NotEmpty()
                    //                .Must(x => x.Count > 0)
                    //                .WithMessage("Please specify at least Milling Machine.");

                });

                When(request => request.Customer.MillingMachines != null && request.Customer.MillingMachines.Count > 0, () =>
                {
                    //RuleFor(request => request.Customer.MillingMachines).NotNull()
                    //               .NotEmpty()
                    //               .Must(x => x.Count > 0)
                    //               .WithMessage("Please specify at least Milling Machine.");
                });
            });
        }

        public override ValidationResult Validate(ValidationContext<CreateCustomerRequest> context)
        {
            logger.Information($"Started validation for : {this.GetType().Name}");
            return base.Validate(context);
        }
    }
}