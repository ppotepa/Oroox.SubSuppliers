using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Comment : Entity
    {
        public virtual Attachment Attachment { get; set; }
        public Guid? AttachmentId { get; set; }
        public string Text { get; set; }
    }
}
