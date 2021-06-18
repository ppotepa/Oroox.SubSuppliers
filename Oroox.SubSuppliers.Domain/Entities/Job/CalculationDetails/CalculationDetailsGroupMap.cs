using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsGroupMap : Entity
    {
        public uint Quantity { get; set; }
        public virtual List<CalculationDetailsGroup> Details { get; set; }
        public Guid CalculationDetailsForQuoteId { get; set; }
    }
}
