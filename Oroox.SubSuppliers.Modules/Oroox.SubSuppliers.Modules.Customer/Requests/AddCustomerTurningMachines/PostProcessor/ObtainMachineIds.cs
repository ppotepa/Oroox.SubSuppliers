using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Response;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.PostProcessor
{
    public class ObtainMachineIds : IRequestPostProcessor<AddCustomerTurningMachinesRequest, AddCustomerTurningMachineRequestResponse>
    {
        private readonly IApplicationContext context;

        public ObtainMachineIds(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(AddCustomerTurningMachinesRequest request, AddCustomerTurningMachineRequestResponse response, CancellationToken cancellationToken)
        {
            TurningMachineResponseDTO[] newEntries = this.context.NewEntries()
                                                            .Select(x => x.Entity)
                                                            .OfType<TurningMachine>()
                                                            .Select(machine => TurningMachineResponseDTO.FromMachine(machine))
                                                            .ToArray();

            response.Result = new AddCustomerTurningMachineResponseModel { TurningMachines = newEntries };
            return Unit.Task;
        }
    }
}
