using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsGroup
    {
        public string Name { get; set; }
        public List<CalculationDetailsSection> Sections { get; set; } = new List<CalculationDetailsSection>();
    }
}
