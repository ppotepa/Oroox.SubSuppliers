using Oroox.SubSuppliers.Core.Abstractions;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Customer : Entity
    {
        public string CompanyName { get; set; }
        public CompanySizeType CompanySize { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<MillingMachine> MillingMachines { get; set; }
        public virtual ICollection<TurningMachine> TurningMachines { get; set; }
    }
}
