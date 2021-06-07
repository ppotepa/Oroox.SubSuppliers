using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest.Response;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest
{
    public class AddCustomerMachineRequest : IRequest<AddCustomerMachineRequestResponse>
    {
        public Machine Machine { get; set; }
        public Customer Customer { get; set; }
    }
}
