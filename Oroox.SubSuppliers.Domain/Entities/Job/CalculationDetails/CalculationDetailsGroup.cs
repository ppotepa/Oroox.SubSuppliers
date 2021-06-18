using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsGroup : Entity
    {
        public string Name { get; set; }
        public int PartIndex { get; set; }
        public virtual List<CalculationDetailsSection> Sections { get; set; }
        public Guid CalculationDetailsGroupMapId { get; set; }
    }
}
