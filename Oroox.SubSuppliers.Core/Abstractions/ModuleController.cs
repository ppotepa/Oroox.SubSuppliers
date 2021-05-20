using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Utilities.Abstractions
{
    /// <summary>
    /// Abstract controller.
    /// Devires from ControllerBase.
    /// Is being used in each of entities Modules.
    /// </summary>

    public abstract class ModuleController : ControllerBase 
    {
        protected readonly IMediator mediator;
        protected readonly IMapper mapper;

        public ModuleController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Handle(IBaseRequest request) 
            => new ObjectResult(await this.mediator.Send(request));
    } 
}
