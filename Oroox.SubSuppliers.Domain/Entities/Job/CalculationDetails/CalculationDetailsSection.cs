using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class CalculationDetailsSection : Entity
    {
        public string Name { get; set; }
        public virtual List<CalculationDetails> Details { get; set; }
        public Guid CalculationDetailsGroupId { get; set; }
    }
}
