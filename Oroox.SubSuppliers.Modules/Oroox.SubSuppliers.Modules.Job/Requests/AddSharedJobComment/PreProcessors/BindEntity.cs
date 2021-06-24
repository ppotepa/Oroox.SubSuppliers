using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.PreProcessors
{
    public class BindEntity : IRequestPreProcessor<AddSharedJobCommentRequest>
    {
        private readonly IApplicationContext context;
        public BindEntity(IApplicationContext context)
        {
            this.context = context;
        }

        public async Task Process(AddSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            request.SharedJob = this.context.SharedJobs.AsQueryable()
                                    .FirstOrDefault(job => job.Id == request.SharedJobId);

            await Unit.Task;
        }
    }
}
