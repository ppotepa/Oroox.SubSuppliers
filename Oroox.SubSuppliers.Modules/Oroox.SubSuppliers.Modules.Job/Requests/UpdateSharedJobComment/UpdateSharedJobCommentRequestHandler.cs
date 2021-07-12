using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment
{
    public class UpdateSharedJobCommentRequestHandler : IRequestHandler<UpdateSharedJobCommentRequest, UpdateSharedJobCommentResponse>
    {
        private readonly IApplicationContext context;

        public UpdateSharedJobCommentRequestHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public Task<UpdateSharedJobCommentResponse> Handle(UpdateSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            request.Comment.Text = request.NewComment.Text;
            
            UpdateSharedJobCommentResponse response = new UpdateSharedJobCommentResponse
            {
                ResponseText = $"Succesfully updated comment with id {request.Comment.Id}"
            };

            return Task.FromResult(response);
        }
    }
}
