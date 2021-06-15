using Microsoft.Extensions.Configuration;
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

        public void GetJobById(Guid jobId)
        {
            HttpClient httpClient = new HttpClient();
        }
    }
}
