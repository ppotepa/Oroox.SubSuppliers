using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public interface IJobsService
    {
        public Task<CalculationDetailsForQuote> RetrieveJobFromOxQuoteApp(Guid jobId, CancellationToken cancelationToken);
    }
}