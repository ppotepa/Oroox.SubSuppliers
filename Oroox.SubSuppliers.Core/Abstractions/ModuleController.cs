using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Utilities.Abstractions
{
    /// <summary>
    /// Abstract controller.
    /// Devires from ControllerBase.
    /// Is being used in each of entities Modules.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class ModuleController : ControllerBase 
    {
        protected readonly IMediator mediator;
        protected readonly IMapper mapper;
        protected readonly IApplicationContext context;

        public ModuleController(IMediator mediator, IMapper mapper, IApplicationContext context)
        {
            this.mediator = mediator;   
            this.mapper = mapper;
            this.context = context;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Handle(IBaseRequest request) 
            => new ObjectResult(await this.mediator.Send(request));
    } 
}
