using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Jobs.RequestsCreateNewJob.Model;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Utilities.Abstractions;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs
{
    /// <summary>
    /// Users Domain Controller
    /// </summary>
    public class JobsController : ModuleController
    {
        public JobsController(IMediator mediator, IMapper mapper, IApplicationContext context)
            : base(mediator, mapper, context) { }

        /// <summary>
        /// Creates a new Job
        /// </summary>
        /// <param name="request">UserDTO</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewJobModel request)
            => await Handle(request: this.mapper.Map<CreateNewJobModel, CreateNewJobRequest>(request));
    }
}
