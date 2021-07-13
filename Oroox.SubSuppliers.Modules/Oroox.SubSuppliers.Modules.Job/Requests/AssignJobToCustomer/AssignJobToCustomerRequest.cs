using MediatR;
using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AssignJobToCustomer
{
    public class AssignJobToCustomerRequest : IRequest<AssignJobToCustomerRequestResponse>        
    {
        public Customer Customer { get; set; }
        public SharedJob SharedJob { get; set; }
    }
}
