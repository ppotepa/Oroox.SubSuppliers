using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsForQuote : Entity
    {   
        public Guid QuoteId { get; set; } // 1-1 relation with quote
        public Dictionary<uint, CalculationDetailsGroupMap> DetailsForQuantities { get; set; } = new Dictionary<uint, CalculationDetailsGroupMap>();
    }
}
