using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Response;
using Serilog;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines
{
    public class AddCustomerTurningMachineRequestHandler : IRequestHandler<AddCustomerTurningMachinesRequest, AddCustomerTurningMachineRequestResponse>
    {
        private readonly ILogger logger;
        private readonly IApplicationContext context;

        public AddCustomerTurningMachineRequestHandler(ILogger logger, IApplicationContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public async Task<AddCustomerTurningMachineRequestResponse> Handle(AddCustomerTurningMachinesRequest request, CancellationToken cancellationToken)
        {
            AddCustomerTurningMachineRequestResponse result = default;

            if (request.Customer != null)
            {
                request.TurningMachines.ForEach(machine => 
                {
                    request.Customer.AddMachine(machine);
                });

                result = new AddCustomerTurningMachineRequestResponse
                {
                    ResponseText = $"Succesfully added {request.TurningMachines.Count()} TurningMachines"
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
