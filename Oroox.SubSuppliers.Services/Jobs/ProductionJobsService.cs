using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Entities.Job;
using Oroox.SubSuppliers.Services.Jobs.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public class ProductionJobsService : IJobsService
    {
        private readonly IConfiguration configuration;
        public ProductionJobsService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Guid CreateNewJob()
        {
            throw new NotImplementedException();
        }

        public Task<GetQuoteCalculationDetailsResponse> RetreiveJobByQuoteId(Guid jobId, CancellationToken cancelationToken)
        {
            throw new NotImplementedException();
        }
    }
}
