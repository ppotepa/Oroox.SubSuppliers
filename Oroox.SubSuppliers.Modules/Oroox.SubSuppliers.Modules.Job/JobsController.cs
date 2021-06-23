using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Model;
using Oroox.SubSuppliers.Modules.Jobs.RequestsCreateNewJob.Model;
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
        /// <param name="request">CreateNewJobModel</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Create(CreateNewJobModel request) 
            => await Handle(request: this.mapper.Map<CreateNewJobModel, CreateNewJobRequest>(request));

        [HttpPost]
        public async Task<IActionResult> CreateSharedJob(CreateNewSharedJobModel request)
            => await Handle(request: this.mapper.Map<CreateNewSharedJobModel, CreateNewSharedJobRequest>(request));

    }
}
