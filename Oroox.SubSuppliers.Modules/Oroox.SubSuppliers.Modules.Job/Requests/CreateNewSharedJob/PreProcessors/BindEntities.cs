using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using Serilog;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.PreProcessors
{
    public class BindEntities : IRequestPreProcessor<CreateNewSharedJobRequest>
    {
        private readonly IApplicationContext context;
        private readonly ILogger logger;

        public BindEntities(IApplicationContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public Task Process(CreateNewSharedJobRequest request, CancellationToken cancellationToken)
        {
            request.Customer = this.context.Customers.AsQueryable().FirstOrDefault(customer => customer.Id == request.CustomerId);
            request.Job = this.context.Jobs.AsQueryable().FirstOrDefault(customer => customer.Id == request.JobId);

            return Unit.Task;
        }
    }
}
