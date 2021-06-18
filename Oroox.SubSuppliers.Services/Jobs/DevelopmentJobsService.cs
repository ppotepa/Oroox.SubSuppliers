using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities.Job;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Services.Jobs.Response;
using Oroox.SubSuppliers.Utilities.Extensions;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{
    /// <summary>
    /// Development Jobs service responsible for obtaining Jobs from OxQuoteApp.
    /// </summary>
    public class DevelopmentJobsService : IJobsService
    {
        private const string getQuoteCalculationDetails = "getQuoteCalculationDetails";
        private readonly IConfiguration configuration;
        private readonly IApplicationContext context;        

        public DevelopmentJobsService(IConfiguration configuration, IApplicationContext context)
        {            
            this.context = context;
            this.configuration = configuration;
        }

        /// <summary>
        /// Retreives a job from OxQuote App.
        /// If request is successful returns Job otherwise it returns null.
        /// </summary>
        /// <param name="quoteid"></param>
        /// <param name="cancelationToken"></param>
        /// <returns></returns>
        public  async Task<GetQuoteCalculationDetailsResponse> RetreiveJobByQuoteId(Guid quoteid, CancellationToken cancelationToken)
        {
            OxSubSuppliersApplicationSettings settings = this.configuration.GetApplicationSettings();
            Uri apiUrl = new Uri(settings.Development.ServiceUrls.OxQuoteAppApiUrl);

            using (HttpClient httpClient = new HttpClient())
            {
                string payloadJson = new
                {
                    commandName= getQuoteCalculationDetails,
                    parameters = new
                    {
                        quoteId = quoteid
                    }
                }
                .ToJsonString();

                using (HttpResponseMessage jobResponse = await httpClient.PostAsync(apiUrl, new StringContent(payloadJson, null, "application/json")))
                {
                    if (jobResponse.StatusCode is System.Net.HttpStatusCode.OK)
                    {
                        Job job = await jobResponse.Content.ReadDeserializedObject<Job>();
                        return new GetQuoteCalculationDetailsResponse 
                        {
                            Result = job,
                        };
                    }
                    else return new GetQuoteCalculationDetailsResponse
                    {
                        ResponseText = $"Unable to fetch Job for Quote with Id {quoteid}",
                        Result = null,
                    };
                }
            }
        }
    }
}
