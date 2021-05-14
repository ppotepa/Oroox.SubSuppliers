using System;

namespace Oroox.SubSuppliers.Domain
{
    public class Entity 
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public Guid Id { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
