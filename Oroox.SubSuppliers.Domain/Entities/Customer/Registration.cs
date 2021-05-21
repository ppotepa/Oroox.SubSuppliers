using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Registration : Entity
    {
        public virtual Customer Customer { get; set; }
        public virtual Guid CustomerId { get; set; }
        public string ActivationCode { get; set; }        
        
    }
}
