using System;

namespace Oroox.SubSuppliers.Domain
{
    public class Entity 
    { 
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool Deleted { get; set; }
    }
}
