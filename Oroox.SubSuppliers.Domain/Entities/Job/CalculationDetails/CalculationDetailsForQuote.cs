using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsForQuote : Entity
    {   
        public Guid QuoteId { get; set; } 
        public virtual Dictionary<uint, CalculationDetailsGroupMap> DetailsForQuantities { get; set; }
    }
}
