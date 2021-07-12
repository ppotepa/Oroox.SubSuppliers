using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment
{
    public class DeleteSharedJobCommentRequestHandler : IRequestHandler<DeleteSharedJobCommentRequest, DeleteSharedJobCommentResponse>
    {
        private readonly IApplicationContext context;

        public DeleteSharedJobCommentRequestHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public Task<DeleteSharedJobCommentResponse> Handle(DeleteSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        //public Task<DeleteSharedJobCommentResponse> Handle(DeleteSharedJobCommentRequest request, CancellationToken cancellationToken)
        //{
        //    return Task.FromResult(null);
        //}
    }
}
