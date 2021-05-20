using FluentValidation;
using Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer;
using Serilog;

namespace Oroox.SubSuppliers.Modules.User.Validation
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerValidator : AbstractValidator<CreateCustomer>
    {
        public CustomerValidator(ILogger logger) 
        {
            logger.Information($"Started validation for : {this.GetType().Name}");

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
    }
}
