using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Model;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Model;
using Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment;
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

        /// <summary>
        /// Creates a shared job based on job
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]                                  
        public async Task<IActionResult> CreateSharedJob(CreateNewSharedJobModel request)
            => await Handle(request: this.mapper.Map<CreateNewSharedJobModel, CreateNewSharedJobRequest>(request));

        /// <summary>
        /// Adds a comment to shared job
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> AddSharedJobComment(AddSharedJobCommentModel request)
            => await Handle(request: this.mapper.Map<AddSharedJobCommentModel, AddSharedJobCommentRequest>(request));

        [HttpPatch]
        public async Task<IActionResult> UpdateSharedJobComment(UpdateSharedJobCommentModel request)
            => await Handle(request: this.mapper.Map<UpdateSharedJobCommentModel, UpdateSharedJobCommentRequest>(request));

        [HttpDelete]
        public async Task<IActionResult> DeleteSharedJobComment(UpdateSharedJobCommentModel request)
            => await Handle(request: this.mapper.Map<UpdateSharedJobCommentModel, UpdateSharedJobCommentRequest>(request));
    }
}
