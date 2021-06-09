using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies
{
    public enum OtherTechnologyTypeEnum
    {
        DeepHoleDrilling, 
        ThreadsM,
        ThreadsTr,
        Toothings,
        Engravings,
        LaserMarking,
        Knurling,
        Annealing,
        Other,
    }

    public class OtherTechnology : EnumerationEntity<OtherTechnologyTypeEnum>
    {
        public virtual ICollection<Customer> Customers { get; internal set; }
    }
}
