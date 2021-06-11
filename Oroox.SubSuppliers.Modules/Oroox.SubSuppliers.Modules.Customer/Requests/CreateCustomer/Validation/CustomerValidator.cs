using FluentValidation;
using FluentValidation.Results;
using Serilog;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer
{
    /// <summary>
    /// Customer Validator.
    /// </summary>
    public class CustomerValidator : AbstractValidator<CreateCustomerRequest>
    {
        private readonly ILogger logger;        
        private static readonly Regex SafePasswordRegex 
            = new Regex(@"^(?=.*[A - Z].*[A - Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}");

        private string SafePasswordMessage => string.Join
        (
            separator: Environment.NewLine,
            value: new string[]
            {
                "Ensure your Password has two uppercase letters 😉.",
                "Ensure your Password has one special case letter 😎",
                "Ensure your Password has two digits 😍.",
                "Ensure your Password has three lowercase letters 😅.",
                "Ensure your Password has three lowercase letters 😅.",
                "Ensure your Password is of length 8 😇.",
            }
        );

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
                RuleFor(request => request.Customer.Password).Must(BeSafe).WithMessage(SafePasswordMessage);
                RuleFor(request => request.Customer.PasswordConfirmation).NotNull().NotEmpty().WithMessage("Password Confirmation cannot be null");
                RuleFor(request => request.Customer.PasswordConfirmation).Equal(x => x.Customer.Password).WithMessage("Passwords must match.");
                RuleFor(request => request.Customer.Website).Must(ExistIfStringIsNotNull).WithMessage("Invalid website url or website does not exist.");
            });
        }

        private bool BeSafe(string passwordString) => SafePasswordRegex.IsMatch(passwordString);

        private bool ExistIfStringIsNotNull(string websiteUrl)
        {
            if (string.IsNullOrEmpty(websiteUrl)) 
            {
                return true;
            }

            if (IsValidUrl(websiteUrl))
            {
                return new HttpClient().GetAsync(websiteUrl).GetAwaiter().GetResult().IsSuccessStatusCode;
            }   
            
            return false;
        }

        private static bool IsValidUrl(string websiteUrl) =>
            Uri.IsWellFormedUriString(websiteUrl, UriKind.RelativeOrAbsolute);

        public override ValidationResult Validate(ValidationContext<CreateCustomerRequest> context)
        {
            logger.Information($"Started validation for : {this.GetType().Name}");
            return base.Validate(context);
        }
    }
}
