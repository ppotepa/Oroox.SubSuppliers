using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine.Response;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine
{
    public class AddTurningMachineRequestHandler : IRequestHandler<AddTurningMachineRequest, AddTurningMachineRequestResponse>
    {
        private readonly ILogger logger;
        private readonly IApplicationContext context;

        public AddTurningMachineRequestHandler(ILogger logger, IApplicationContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public async Task<AddTurningMachineRequestResponse> Handle(AddTurningMachineRequest request, CancellationToken cancellationToken)
        {   
            if (request.Customer != null)
            {
                request.Customer.TurningMachines.Add(request.TurningMachine);
                IEnumerable<EntityEntry<TurningMachine>> entries = this.context.NewEntries<TurningMachine>();
                AddTurningMachineRequestResponse result = new AddTurningMachineRequestResponse
                {
                    TurningMachineId = entries.FirstOrDefault().Entity.Id
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
