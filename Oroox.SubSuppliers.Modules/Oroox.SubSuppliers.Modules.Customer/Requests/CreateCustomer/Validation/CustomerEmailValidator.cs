using FluentValidation;
using FluentValidation.Results;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Serilog;
using System.Linq;
using System.Text.RegularExpressions;

namespace Oroox.SubSuppliers.Modules.User.Validation
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerEmailValidator : AbstractValidator<CreateCustomer>
    {
        private readonly Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private readonly ILogger logger;
        private readonly IApplicationContext context;

        public CustomerEmailValidator(ILogger logger, IApplicationContext context)
        {
            this.logger = logger;
            this.context = context;

            RuleFor(request => request).NotNull();
            RuleFor(request => request.Customer).NotNull();

            When(x => x != null && x.Customer != null, () =>
            {
                RuleFor(request => request.Customer.EmailAddress)
                                     .NotNull()
                                     .NotEmpty()
                                     .Must(BeValidEmail)
                                     .WithMessage("Invalid Email address.");

                RuleFor(x => x.Customer.EmailAddress).Must(NotBeTaken).WithMessage("Email already taken.");

            });
        }
        private bool BeValidEmail(string emailString) 
            => emailRegex.Match(emailString ?? string.Empty).Success is true;
        
        private bool NotBeTaken(string emailString) 
            => this.context.Customers.Any(x => x.EmailAddress == emailString) is false;

        public override ValidationResult Validate(ValidationContext<CreateCustomer> context)
        {
            logger.Information($"Started validation for : {this.GetType().Name}");
            return base.Validate(context);
        }
    }
}
