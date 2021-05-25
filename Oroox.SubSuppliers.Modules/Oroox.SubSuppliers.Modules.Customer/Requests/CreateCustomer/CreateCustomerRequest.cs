using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Responses;

namespace Oroox.SubSuppliers.Modules.Customers.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerRequestResponse>
    { 
    
        public CreateCustomerRequest() { }
        public Customer Customer { get; set; }
    }
}
