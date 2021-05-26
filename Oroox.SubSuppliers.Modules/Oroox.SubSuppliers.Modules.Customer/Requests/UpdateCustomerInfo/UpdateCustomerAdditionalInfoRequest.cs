using MediatR;
using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo
{
    public class UpdateCustomerAdditionalInfoRequest : IRequest<UpdateCustomerAdditionalInfoRequestResponse>
    {
        public CustomerAdditionalInfo CustomerAdditionalInfo { get; set; }
    }
}
