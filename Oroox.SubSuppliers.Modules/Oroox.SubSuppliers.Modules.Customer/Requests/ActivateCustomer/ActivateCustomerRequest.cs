using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomerRequest.Response;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer
{
    public class ActivateCustomerRequest : IRequest<ActivateCustomerRequestResponse>
    { 
        public ActivateCustomerRequest() { }
        public Registration Registration { get; set; }
    }
}
