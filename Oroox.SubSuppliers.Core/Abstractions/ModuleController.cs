﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Response;
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

        protected ModuleController(IMediator mediator, IMapper mapper, IApplicationContext context)
        {
            this.mediator = mediator;   
            this.mapper = mapper;
            this.context = context;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Handle(IBaseRequest request)
        {
            ResponseBase response = await this.mediator.Send(request) as ResponseBase;

            if (response.RedirectUrl != string.Empty)
                return new ObjectResult(response);
            else 
                return Redirect(response.RedirectUrl);

        }
    } 
}
