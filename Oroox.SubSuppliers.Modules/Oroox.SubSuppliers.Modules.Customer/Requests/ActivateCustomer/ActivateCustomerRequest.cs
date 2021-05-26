using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.Responses;

namespace Oroox.SubSuppliers.Modules.Customers.Requests
{
    public class ActivateCustomerRequest : IRequest<ActivateCustomerRequestResponse>
    { 
        public ActivateCustomerRequest() { }
        public Registration Registration { get; set; }
    }
}
