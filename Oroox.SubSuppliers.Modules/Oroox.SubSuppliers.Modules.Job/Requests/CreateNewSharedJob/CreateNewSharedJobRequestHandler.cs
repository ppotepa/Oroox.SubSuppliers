using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.DTO;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Model;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Response;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob
{
    public class CreateNewSharedJobRequestHandler : IRequestHandler<CreateNewSharedJobRequest, CreateNewSharedJobRequestResponse>
    {
        private readonly SubSuppliersContext context;
        private readonly ILogger logger;

        public CreateNewSharedJobRequestHandler(IApplicationContext context, ILogger logger)
        {
            this.context = context as SubSuppliersContext;
            this.logger = logger;
        }

        public async Task<CreateNewSharedJobRequestResponse> Handle(CreateNewSharedJobRequest request, CancellationToken cancellationToken)
        {            
            EntityEntry<SharedJob> newSharedJobEntry = await this.context.AddAsync
            (
                new SharedJob
                {
                    JobId = request.Job.Id,
                    SharedJobStatusType = context.Enumerations.SharedJobStatusTypes[SharedJobStatusTypeEnum.NoAction],
                    CustomerId = request.Customer.Id,
                }
            );

            request.SharedJob = newSharedJobEntry.Entity;

            return new CreateNewSharedJobRequestResponse
            {
                ResponseText = $"Succesfully created new Shared Job with : {request.SharedJob.Id}",
                Result = new CreateNewSharedJobRequestResponseModel
                {
                    SharedJob = new SharedJobResponseDTO 
                    {
                        Id = newSharedJobEntry.Entity.Id
                    }
                }
            };
        }
    }
}
