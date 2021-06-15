using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public class DevelopmentJobsService : IJobsService
    {
        private readonly IConfiguration configuration;
        public DevelopmentJobsService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void GetJobById(Guid jobId)
        {
            HttpClient httpClient = new HttpClient();
        }
    }
}
