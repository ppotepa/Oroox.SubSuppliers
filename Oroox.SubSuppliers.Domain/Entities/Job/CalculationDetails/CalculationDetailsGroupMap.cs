using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsGroupMap
    {
        public Dictionary<string, CalculationDetailsGroup> Details { get; set; } = new Dictionary<string, CalculationDetailsGroup>();
    }
}
