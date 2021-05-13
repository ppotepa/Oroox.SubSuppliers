using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Core.Abstractions;
using Oroox.SubSuppliers.Modules.User.Commands;
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
        
        [HttpPost]        
        public async Task<IActionResult> Create(CreateUserCommand request)
        {
            CreateUserCommandResponse response = await mediator.Send(request);
            return new ObjectResult(response);
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            TestRequestCommandResponse resp = await mediator.Send(new TestRequest());
            return new ObjectResult(resp);
        }
    }
}
