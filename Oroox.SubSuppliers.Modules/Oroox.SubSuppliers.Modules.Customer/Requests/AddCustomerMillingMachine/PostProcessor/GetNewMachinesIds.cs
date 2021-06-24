using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.DTO;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Response;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.PreProcessor
{
    public class GetNewMachinesIds : IRequestPostProcessor<AddCustomerMillingMachineRequest, AddCustomerMillingMachineRequestResponse>
    {
        private readonly IApplicationContext context;

        public GetNewMachinesIds(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(AddCustomerMillingMachineRequest request, AddCustomerMillingMachineRequestResponse response, CancellationToken cancellationToken)
        {   

            response.Result = new NewMillingMachineResponseModel
            {
                MillingMachines = this.context
                                    .NewEntries()
                                    .Select(x => x.Entity)
                                    .OfType<MillingMachine>()
                                    .Select(machine => MillingMachineResponseDTO.FromMachine(machine))
                                    .ToArray()
            };

            return Unit.Task;
        }
    }
}
