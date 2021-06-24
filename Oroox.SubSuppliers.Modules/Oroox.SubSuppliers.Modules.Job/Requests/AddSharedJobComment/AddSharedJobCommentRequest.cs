using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment
{
    public class AddSharedJobCommentRequest : IRequest<AddSharedJobCommentResponse>
    {
        public Guid SharedJobId { get; set; }   
        public Comment Comment { get; set; }
        public SharedJob SharedJob { get; set; }           
    }
}
