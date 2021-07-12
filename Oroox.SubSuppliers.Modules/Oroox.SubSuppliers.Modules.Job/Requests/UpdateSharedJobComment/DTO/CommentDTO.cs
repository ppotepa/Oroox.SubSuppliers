using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.DTO
{
    public class CommentDTO
    {
       public Guid Id { get; set; }
    }

    public class NewCommentDTO
    {
        public string Text { get; set; }        
    }
}
