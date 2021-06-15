using System;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public interface IJobsService
    {
        public void GetJobById(Guid jobId);
    }
}