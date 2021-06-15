using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
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

        public CalculationDetails GetJobById(Guid jobId)
        {
            var json = 
            @"
                
            ";
            
            return new CalculationDetails()
            {
                
            };
        }
    }
}
