using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities.Job;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Utilities.Extensions;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{

    class TemporaryResult
    {  
        [JsonConverter(typeof(OldNewCalculationDetailsModelConverter))]
        public CalculationDetailsForQuote CalculationDetailsForQuote { get; set; }
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

        public  async Task<Job> RetrieveJobFromOxQuoteApp(Guid quoteid, CancellationToken cancelationToken)
        {
            OxSubSuppliersApplicationSettings settings = this.configuration.GetApplicationSettings();
            Uri apiUrl = new Uri(settings.Development.ServiceUrls.OxQuoteAppApiUrl);
            HttpClient httpClient = new HttpClient();

            var payload = (
                commandName: "getQuoteCalculationDetails",
                parameters: new
                {
                    quoteId = "4DC8B714-740A-4575-A0DE-97B4F3BA88C5"
                }
            );

            HttpResponseMessage quote = await httpClient.PostAsync
            (
                requestUri: apiUrl,
                content:    new StringContent(payload.ToJsonString(), null, "application/json")
            );

            Job job = await quote.Content.ReadDeserializedObject<Job>();
            return job;
        }
    }
}
