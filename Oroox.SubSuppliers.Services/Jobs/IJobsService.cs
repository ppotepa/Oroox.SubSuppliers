using Oroox.SubSuppliers.Services.Jobs.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{
    /// <summary>
    /// Jobs service responsible for obtaining quotes from OxQuoteApp
    /// </summary>
    public interface IJobsService
    {
        public Task<GetQuoteCalculationDetailsResponse> RetreiveJobByQuoteId(Guid quoteId, CancellationToken cancelationToken);
    }
}