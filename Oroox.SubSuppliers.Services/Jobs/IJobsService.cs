using Oroox.SubSuppliers.Domain.Entities.Job;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public interface IJobsService
    {
        public Task<Job> RetrieveJobFromOxQuoteApp(Guid quoteId, CancellationToken cancelationToken);
    }
}