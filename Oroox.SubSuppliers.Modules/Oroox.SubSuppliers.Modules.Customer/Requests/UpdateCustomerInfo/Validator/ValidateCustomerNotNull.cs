using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.Validator
{
    public class ValidateCustomerNotNull : AbstractValidator<UpdateCustomerAdditionalInfoRequest>
    {
        public ValidateCustomerNotNull()
        {
            RuleFor(x => x.CustomerAdditionalInfo).NotNull().WithMessage("Invalid request.");
            RuleFor(x => x.Customer).NotNull().WithMessage("Error. Customer not found.");
        }
    }
}
