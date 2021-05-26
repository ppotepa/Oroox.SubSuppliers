using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.Validator
{
    public class ValidateCustomerNotNull : AbstractValidator<UpdateCustomerAdditionalInfoRequest>
    {
        public ValidateCustomerNotNull()
        {
            RuleFor(x => x.CustomerAdditionalInfo.Customer).NotNull().WithMessage("Error. Customer not found.");
        }
    }
}
