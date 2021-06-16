using MediatR;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Response;
using Oroox.SubSuppliers.Services.Jobs;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Response
{
    public class CreateNewJobRequestHandler : IRequestHandler<CreateNewJobRequest, CreateNewJobRequestResponse>
    {
        private readonly IJobsService jobsService;
        public CreateNewJobRequestHandler(IJobsService jobsService)
        {
            this.jobsService = jobsService;
        }

        public async Task<CreateNewJobRequestResponse> Handle(CreateNewJobRequest request, CancellationToken cancellationToken)
        => await Task.FromResult
        (
            new CreateNewJobRequestResponse
            {
                Result = this.jobsService.GetJobById(default)
            }
        );
    }
}
