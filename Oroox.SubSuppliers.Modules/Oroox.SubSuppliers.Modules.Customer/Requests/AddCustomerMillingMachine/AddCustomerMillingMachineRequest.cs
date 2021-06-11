using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine
{
    public class AddCustomerMillingMachineRequest : IRequest<AddCustomerMillingMachineRequestResponse>
    {
        public Customer Customer { get; internal set; }
        public MillingMachine[] MillingMachines { get; internal set; }
        public Guid CustomerId { get; internal set; }
    }
}
