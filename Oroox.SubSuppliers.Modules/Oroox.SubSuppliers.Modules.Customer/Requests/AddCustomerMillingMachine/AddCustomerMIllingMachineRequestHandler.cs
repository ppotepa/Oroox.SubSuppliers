using MediatR;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine
{
    public class AddCustomerMillingMachineRequestHandler : IRequestHandler<AddCustomerMillingMachineRequest, AddCustomerMillingMachineRequestResponse>
    {
        public async Task<AddCustomerMillingMachineRequestResponse> Handle(AddCustomerMillingMachineRequest request, CancellationToken cancellationToken)
        {
            if (request.Customer != null)
            {
                request.MillingMachines.ForEach(machine =>
                {
                    request.Customer.AddMachine(machine);
                });

                AddCustomerMillingMachineRequestResponse result = new AddCustomerMillingMachineRequestResponse
                {
                    MachineIds = null,
                };

                return await Task.FromResult(result);
            }
            else
            {
                throw new InvalidOperationException("Something went wrong.");
            }
        }
    }
}
