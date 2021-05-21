using FluentValidation;
using FluentValidation.Results;
using Oroox.SubSuppliers.Modules.User.Requests;
using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Serilog;

namespace Oroox.SubSuppliers.Modules.User.Validation
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerValidator : AbstractValidator<CreateCustomer>
    {
        private readonly ILogger logger;

        public CustomerValidator(ILogger logger) 
        {
            
            this.logger = logger;
            this.CascadeMode = CascadeMode.Stop;

            RuleFor(request => request).NotNull();
            RuleFor(request => request.Customer).NotNull();

            When(x => x != null && x.Customer != null, () =>
            {
                RuleFor(request => request.Customer.CompanyName).NotNull().NotEmpty();
                RuleFor(request => request.Customer.Password).NotNull().NotEmpty().WithMessage("Password cannot be null");
                RuleFor(request => request.Customer.PasswordConfirmation).NotNull().NotEmpty().WithMessage("Password Confirmation cannot be null");
                RuleFor(request => request.Customer.PasswordConfirmation).Equal(x => x.Customer.Password).WithMessage("Passwords must match.");
            });
        }

        public override ValidationResult Validate(ValidationContext<CreateCustomer> context)
        {
            logger.Information($"Started validation for : {this.GetType().Name}");
            return base.Validate(context);
        }
    }
}
