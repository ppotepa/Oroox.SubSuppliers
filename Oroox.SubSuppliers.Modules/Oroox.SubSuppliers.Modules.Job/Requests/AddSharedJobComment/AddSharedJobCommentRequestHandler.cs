using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment
{
    public class AddSharedJobCommentRequestHandler : IRequestHandler<AddSharedJobCommentRequest, AddSharedJobCommentResponse>
    {
        private readonly IApplicationContext context;

        public AddSharedJobCommentRequestHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public async Task<AddSharedJobCommentResponse> Handle(AddSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            if (request.SharedJob is null)
            {
                return new AddSharedJobCommentResponse
                {
                    ResponseText = "Something went wrong."
                };
            }

            request.Comment.RegardingObject = new RegardingObject
            {
                EntityName = nameof(SharedJob),
                RegardingObjectId = request.SharedJobId,                
            };

            request.SharedJob.Comments.Add(request.Comment);

            AddSharedJobCommentResponse result = new AddSharedJobCommentResponse
            {
                ResponseText = $"Succesfully added a comment for SharedJob with id {request.SharedJobId}",                
            };

            return await Task.FromResult(result);
        }
    }
}
