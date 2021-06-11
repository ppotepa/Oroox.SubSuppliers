using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.Responses;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer
{
    public class CreateCustomerRequest : IRequest<CreateCustomerRequestResponse>
    { 
    
        public CreateCustomerRequest() { }
        public Customer Customer { get; set; }
    }
}
