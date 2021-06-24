using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.DTO
{
    public class CommentResponseDTO
    {
        public Guid Id { get; set; }
        public AttachmentResponseDTO Attachment { get; set; }
    }
}