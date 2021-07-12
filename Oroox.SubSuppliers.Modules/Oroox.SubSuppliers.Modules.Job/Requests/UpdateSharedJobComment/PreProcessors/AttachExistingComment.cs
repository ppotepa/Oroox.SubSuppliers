using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.PreProcessors
{
    public class AttachExistingComment : IRequestPreProcessor<UpdateSharedJobCommentRequest>
    {
        private readonly IApplicationContext context;
        public AttachExistingComment(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(UpdateSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            this.context.AttachEntity(request.Comment);
            return Unit.Task;
        }
    }
}
