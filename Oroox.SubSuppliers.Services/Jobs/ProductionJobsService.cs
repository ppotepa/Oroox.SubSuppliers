using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;
using System.Net.Http;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public class ProductionJobsService : IJobsService
    {
        private readonly IConfiguration configuration;
        public ProductionJobsService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
     
        public CalculationDetails GetJobById(Guid jobId)
        {
            throw new NotImplementedException();
        }
    }
}
