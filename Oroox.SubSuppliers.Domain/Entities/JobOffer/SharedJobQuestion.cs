using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class SharedJobQuestion : Entity
    {
        //public Entity From { get; set; }
        //public Entity To { get; set; }
        public virtual SharedJob JobOffer { get; set; }
        public Guid JobOfferId { get; set; }
        public bool IsAnswered { get; set; }
    }
}
