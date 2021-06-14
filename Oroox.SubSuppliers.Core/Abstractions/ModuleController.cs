using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Response;
using System;
using System.Collections.Generic;
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

        private Dictionary<ShouldRedirect, Func<BaseRespone, IActionResult>> Actions => new Dictionary<ShouldRedirect, Func<BaseRespone, IActionResult>>()
        {
            [ShouldRedirect.ShouldNotRedirect]  = (response) => new ObjectResult(response),
            [ShouldRedirect.ShoulRedirect]      = (response) => Redirect(response.RedirectUrl),
        };

        protected ModuleController(IMediator mediator, IMapper mapper, IApplicationContext context)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.context = context;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Handle(IBaseRequest request)
        {
            BaseRespone response = await this.mediator.Send(request) as BaseRespone;
            ShouldRedirect shouldRedirect = string.IsNullOrEmpty(response.RedirectUrl) is false 
                ? ShouldRedirect.ShoulRedirect 
                : ShouldRedirect.ShouldNotRedirect;

            return Actions[shouldRedirect](response);
        }
    }

    internal enum ShouldRedirect 
    {
        ShouldNotRedirect, 
        ShoulRedirect 
    };
}
