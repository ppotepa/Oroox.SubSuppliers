using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines
{
    public class AddCustomerTurningMachinesRequest : IRequest<AddCustomerTurningMachineRequestResponse>
    {
        public TurningMachine[] TurningMachines { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
