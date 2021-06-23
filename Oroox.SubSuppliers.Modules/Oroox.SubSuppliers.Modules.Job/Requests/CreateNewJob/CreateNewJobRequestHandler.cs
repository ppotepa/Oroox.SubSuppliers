using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob.DTO;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Model;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Response;
using Oroox.SubSuppliers.Services.Jobs;
using Oroox.SubSuppliers.Services.Jobs.Response;
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
            GetQuoteCalculationDetailsResponse jobResponse = await jobsService.RetreiveJobByQuoteId(request.QuoteId, cancellationToken);

            if (jobResponse.Result is null) return new CreateNewJobRequestResponse
            {
                ResponseText = $"Request was succesful. But no quotes with id '{request.QuoteId}' were found.",
            };

            EntityEntry<Job> entry = await this.context.Jobs.AddAsync(jobResponse.Result as Job);

            return new CreateNewJobRequestResponse
            {
                Result = new CreateNewJobRequestResponseModel
                { 
                    Customer = new CustomerResponseDTO
                    {
                        Id = entry.Entity.Id
                    }
                },
                ResponseText = $"Created new Entity with id {entry.Entity.Id}."
            };
        }
    }
}
