using System;

namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public class CalculationDetailsForQuote : Entity
    {   
        public Guid QuoteId { get; set; } 
        public virtual CalculationDetailsGroupMap DetailsForQuantities { get; set; }
    }
}
