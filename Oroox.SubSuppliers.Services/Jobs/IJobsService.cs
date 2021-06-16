using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public interface IJobsService
    {
        public CalculationDetailsForQuote GetJobById(Guid jobId);
    }
}