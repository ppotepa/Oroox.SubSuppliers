using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Modules.User.Requests;
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
        private readonly IApplicationContext context;

        public UsersController(IMediator mediator, ILogger logger, IApplicationContext context)
        {
            this.logger = logger;
            this.mediator = mediator;
            this.context = context;
        }       
        
        [HttpPost]        
        public async Task<IActionResult> Create(CreateCustomerRequest request)
        {
            CreateCustomerRequestResponse response = await mediator.Send(request);
            return new ObjectResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await context.Customers.AsQueryable().ToListAsync());
        }

    }
}
