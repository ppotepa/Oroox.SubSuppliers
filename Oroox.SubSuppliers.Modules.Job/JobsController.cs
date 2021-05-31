using AutoMapper;
using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Utilities.Abstractions;

namespace Oroox.SubSuppliers.Modules.Jobs
{
    /// <summary>
    /// Users Domain Controller
    /// </summary>
    public class JobsController : ModuleController
    {
        public JobsController(IMediator mediator, IMapper mapper, IApplicationContext context)
            : base(mediator, mapper, context) { }        
    }
}
