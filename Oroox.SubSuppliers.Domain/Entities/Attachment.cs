using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Attachment : Entity
    {
        public virtual RegardingObject RegardingObject { get; set; }
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }

    public class RegardingObject : Entity
    {
        public string EntityName { get; set; }       
        public Guid RegardingObjectId { get; set; }

        [NotMapped]
        public Type EntityType
            => Type.GetType(this.EntityName, true, true);
    }
}
