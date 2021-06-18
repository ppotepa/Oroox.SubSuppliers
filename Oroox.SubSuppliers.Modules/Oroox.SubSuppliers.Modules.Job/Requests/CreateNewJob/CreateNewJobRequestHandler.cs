using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities.Job;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Response;
using Oroox.SubSuppliers.Services.Jobs;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Response
{
    public class CreateNewJobRequestHandler : IRequestHandler<CreateNewJobRequest, CreateNewJobRequestResponse>
    {
        private readonly IJobsService jobsService;
        private readonly IApplicationContext context;

        public CreateNewJobRequestHandler(IJobsService jobsService, IApplicationContext context)
        {
            this.jobsService = jobsService;
            this.context = context;
        }

        public async Task<CreateNewJobRequestResponse> Handle(CreateNewJobRequest request, CancellationToken cancellationToken)
        {
            Job job = await jobsService.RetrieveJobFromOxQuoteApp(default, cancellationToken);
            EntityEntry<Job> entry = await this.context.Jobs.AddAsync(job);

            return new CreateNewJobRequestResponse
            {
                Result = entry.Entity.Id,
                ResponseText = $"Created new Entity with id {entry.Entity.Id}."
            };
        }
    }
}
