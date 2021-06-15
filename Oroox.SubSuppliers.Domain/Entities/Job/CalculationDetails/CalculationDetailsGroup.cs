using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsGroup
    {
        public string Name { get; set; }
        public virtual List<CalculationDetailsSection> Sections { get; set; }
    }
}
