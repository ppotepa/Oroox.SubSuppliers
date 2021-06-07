using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest.Response;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest
{
    public class AddTurningMachineRequestHandler : IRequestHandler<AddCustomerMachineRequest, AddCustomerMachineRequestResponse>
    {
        private readonly ILogger logger;
        private readonly IApplicationContext context;

        public AddTurningMachineRequestHandler(ILogger logger, IApplicationContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public async Task<AddCustomerMachineRequestResponse> Handle(AddCustomerMachineRequest request, CancellationToken cancellationToken)
        {   
            if (request.Customer != null)
            {
                request.Customer.Machines.Add(request.Machine);
                IEnumerable<EntityEntry<Machine>> entries = this.context.NewEntries<Machine>();
                AddCustomerMachineRequestResponse result = new AddCustomerMachineRequestResponse
                {
                    MachineId = entries.FirstOrDefault().Entity.Id
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
