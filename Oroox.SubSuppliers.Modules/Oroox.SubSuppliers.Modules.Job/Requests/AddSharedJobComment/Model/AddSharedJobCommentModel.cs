using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Model
{
    public class AddSharedJobCommentModel
    {        
        public Guid SharedJobId { get; set; }
        public CommentDTO Comment { get; set; }
    }
}