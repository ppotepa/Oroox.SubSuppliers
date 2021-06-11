using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachine.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachine
{
    public class AddCustomerMillingMachineRequest : IRequest<AddCustomerTurningMachineRequestResponse>
    {
        public TurningMachine[] TurningMachines { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
