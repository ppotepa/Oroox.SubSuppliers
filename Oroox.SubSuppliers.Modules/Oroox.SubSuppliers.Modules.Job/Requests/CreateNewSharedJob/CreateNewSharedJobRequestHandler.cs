using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Response;
using Serilog;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob
{
    public class CreateNewSharedJobRequestHandler : IRequestHandler<CreateNewSharedJobRequest, CreateNewSharedJobRequestResponse>
    {
        private readonly SubSuppliersContext context;
        private readonly ILogger logger;

        public CreateNewSharedJobRequestHandler(IApplicationContext context, ILogger logger)
        {
            this.context = context as SubSuppliersContext;
            this.logger = logger;
        }

        public Task<CreateNewSharedJobRequestResponse> Handle(CreateNewSharedJobRequest request, CancellationToken cancellationToken)
        {
            EntityEntry<SharedJob> newSharedJobEntry = this.context.Add
            (
                new SharedJob
                {
                    Job = request.Job,
                    SharedJobStatusType = context.Enumerations.SharedJobStatusTypes[SharedJobStatusTypeEnum.NoAction],
                    Customer = request.Customer
                }
            );

            return default;
        }
    }
}
