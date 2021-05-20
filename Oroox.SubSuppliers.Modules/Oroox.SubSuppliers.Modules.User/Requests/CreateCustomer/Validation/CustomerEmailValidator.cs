using FluentValidation;
using Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer;
using Serilog;
using System.Text.RegularExpressions;

namespace Oroox.SubSuppliers.Modules.User.Validation
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerEmailValidator : AbstractValidator<CreateCustomer>
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public CustomerEmailValidator(ILogger logger)
        {
            logger.Information($"Started validation for : {this.GetType().Name}");

            RuleFor(request => request).NotNull();
            RuleFor(request => request.Customer).NotNull();

            When(x => x != null && x.Customer != null, () => 
            {
                RuleFor(request => request.Customer.EmailAddress).NotNull()
                    .NotEmpty()
                    .Must(BeValidEmail)
                    .WithMessage("Invalid Email address.");

            });
        }
        private bool BeValidEmail(string emailString) => emailRegex.Match(emailString ?? string.Empty).Success is true;
    }
}
