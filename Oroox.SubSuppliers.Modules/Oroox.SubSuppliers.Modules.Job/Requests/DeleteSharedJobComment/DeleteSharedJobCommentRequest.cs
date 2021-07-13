using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment
{
    public class DeleteSharedJobCommentRequest : IRequest<DeleteSharedJobCommentResponse>
    {
        public Comment Comment { get; set; }        
    }
}
