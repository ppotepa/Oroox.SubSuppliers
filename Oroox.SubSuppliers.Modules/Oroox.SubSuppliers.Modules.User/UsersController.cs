﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Modules.User.Commands;
using Oroox.SubSuppliers.Utilities.Abstractions;
using Serilog;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User
{
    [Route("api/[controller]/[action]")]
    public class UsersController : ModuleController
    {
        private readonly ILogger logger;
        private readonly IMediator mediator;

        public UsersController(IMediator mediator, ILogger logger)
        {
            this.logger = logger;
            this.mediator = mediator;
        }       
        
        [HttpPut]        
        public async Task<IActionResult> Create(CreateCustomerCommand request)
        {
            CreateCustomerResponse response = await mediator.Send(request);
            return new ObjectResult(response);
        }
    }
}
