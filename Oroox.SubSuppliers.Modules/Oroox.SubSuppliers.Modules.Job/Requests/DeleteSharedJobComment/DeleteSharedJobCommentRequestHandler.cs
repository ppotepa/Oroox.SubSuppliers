using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
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

        public async Task<DeleteSharedJobCommentResponse> Handle(DeleteSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            EntityEntry<Comment> entry = this.context.Comments.Remove(request.Comment);

            DeleteSharedJobCommentResponse response = new DeleteSharedJobCommentResponse
            {
                ResponseText = $"Succesfully removed comment with id {entry.Entity.Id}"
            };

            return await Task.FromResult(response);
        }
    }
}
