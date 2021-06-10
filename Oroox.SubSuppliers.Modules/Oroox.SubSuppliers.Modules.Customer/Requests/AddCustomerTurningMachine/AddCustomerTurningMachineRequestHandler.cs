﻿using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest.Response;
using Serilog;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest
{
    public class AddCustomerTurningMachineRequestHandler : IRequestHandler<AddCustomerTurningMachineRequest, AddCustomerTurningMachineRequestResponse>
    {
        private readonly ILogger logger;
        private readonly IApplicationContext context;

        public AddCustomerTurningMachineRequestHandler(ILogger logger, IApplicationContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public async Task<AddCustomerTurningMachineRequestResponse> Handle(AddCustomerTurningMachineRequest request, CancellationToken cancellationToken)
        {   
            if (request.Customer != null)
            {
                request.TurningMachines.ForEach(machine => 
                {
                    request.Customer.AddMachine(machine);
                });
                
                AddCustomerTurningMachineRequestResponse result = new AddCustomerTurningMachineRequestResponse
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