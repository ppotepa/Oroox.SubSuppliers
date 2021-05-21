using FluentValidation;
using FluentValidation.Results;
using Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer;
using Serilog;
using System.Text.RegularExpressions;

namespace Oroox.SubSuppliers.Modules.User.Validation
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerMachinesValidator : AbstractValidator<CreateCustomer>
    {
        private readonly Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private readonly ILogger logger;
        public CustomerMachinesValidator(ILogger logger)
        {
            this.logger = logger;

            RuleFor(request => request).NotNull();
            RuleFor(request => request.Customer).NotNull();

            When(x => x != null && x.Customer != null, () => 
            {
                RuleFor(request => request.Customer.TurningMachines)
                                    .NotNull()
                                    .NotEmpty()
                                    .Must(x => x.Count > 0)
                                    .WithMessage("Please specify at least Turning Machine.");

                RuleFor(request => request.Customer.MillingMachines)
                                    .NotNull()
                                    .NotEmpty()
                                    .Must(x => x.Count > 0)
                                    .WithMessage("Please specify at least Turning Machine.");

            });
        }

        public override ValidationResult Validate(ValidationContext<CreateCustomer> context)
        {
            logger.Information($"Started validation for : {this.GetType().Name}");
            return base.Validate(context);
        }
    }
}
