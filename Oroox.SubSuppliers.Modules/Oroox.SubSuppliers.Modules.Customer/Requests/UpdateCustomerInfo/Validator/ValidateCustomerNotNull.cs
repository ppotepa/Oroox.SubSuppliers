using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.Validator
{
    public class ValidateCustomerNotNull : AbstractValidator<UpdateCustomerAdditionalInfoRequest>
    {
        private readonly IApplicationContext context;
        public ValidateCustomerNotNull(IApplicationContext context)
        {
            RuleFor(x => x.CustomerAdditionalInfo.Customer).NotNull().WithMessage("Error. Customer not found.");
        }
    }
}
