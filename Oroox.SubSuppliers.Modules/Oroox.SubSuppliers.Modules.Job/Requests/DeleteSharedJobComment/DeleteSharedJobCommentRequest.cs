using MediatR;
using Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment
{
    public class DeleteSharedJobCommentRequest : IRequest<DeleteSharedJobCommentResponse>
    {
        public Guid CommentId { get; set; }
        public Guid SharedJobId { get; set; }
    }
}
