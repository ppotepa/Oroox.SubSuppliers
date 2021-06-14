using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsSection
    {
        public string Name { get; set; }
        public List<CalculationDetails> Details { get; set; } = new List<CalculationDetails>();
    }
}
