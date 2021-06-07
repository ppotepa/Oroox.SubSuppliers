using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine.Response;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine
{
    public class AddTurningMachineRequest : IRequest<AddTurningMachineRequestResponse>
    {
        public TurningMachine TurningMachine { get; set; }
        public Customer Customer { get; set; }
    }
}
