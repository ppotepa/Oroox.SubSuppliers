using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.Response;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment
{
    public class UpdateSharedJobCommentRequest : IRequest<UpdateSharedJobCommentResponse>
    {
        public Comment Comment { get; set; }        
        public Comment NewComment { get; set; }        
    }
}
