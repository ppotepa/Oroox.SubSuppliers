using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest
{
    public class AddCustomerTurningMachineRequest : IRequest<AddCustomerTurningMachineRequestResponse>
    {
        public TurningMachine[] TurningMachines { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
