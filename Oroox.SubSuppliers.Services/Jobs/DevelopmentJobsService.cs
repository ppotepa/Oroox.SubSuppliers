using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities.Job;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Utilities.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{

    class TemporaryResult
    {  
        [JsonConverter(typeof(OldNewCalculationDetailsModelConverter))]
        public CalculationDetailsForQuote Details { get; set; }
        public CalculationResult CalculationResult { get; set; }
        public Quote Quote { get; set; }
    }

    public class DevelopmentJobsService : IJobsService
    {
        private readonly IConfiguration configuration;
        private readonly IApplicationContext context;        

        public DevelopmentJobsService(IConfiguration configuration, IApplicationContext context)
        {            
            this.context = context;
            this.configuration = configuration;
        }

        private string[] PathParts => new string[]
        {
            Directory.GetCurrentDirectory(),
            "bin",
            "Debug",
            "netcoreapp3.1",
            "Jobs",
            "devjob.model.json"
        };

        private string JsonFileLocation => Path.Combine(PathParts);
        private string JsonFileText => File.ReadAllText(JsonFileLocation);

        public  async Task<Job> RetrieveJobFromOxQuoteApp(Guid quoteid, CancellationToken cancelationToken)
        {
            OxSubSuppliersApplicationSettings settings = this.configuration.GetApplicationSettings();
            Uri serviceUrl = new Uri(settings.Development.ServiceUrls.OxQuoteAppUrl);
            
            var httpClient = new HttpClient();
            var payload = new
            {
                commandName = "getQuoteCalculationDetails",
                parameters = new 
                {
                    quoteId = "4DC8B714-740A-4575-A0DE-97B4F3BA88C5"
                },
            };

            HttpResponseMessage quote = await httpClient.PostAsync
            (
                "https://localhost:5001/api/action",
                new StringContent(payload.ToJsonString(), null, "application/json")
            );

            var result = await quote.Content.ReadDeserializedObject<TemporaryResult>();

            Job job = new Job
            {
                CalculationDetailsForQuote = result.Details,                
                Quote = result.Quote                
            };

            return job;// await Task.FromResult(result);
        }
    }
}
