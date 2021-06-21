using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class CalculationDetailsForQuote : Entity
    {   
        public Guid QuoteId { get; set; }        
        public virtual List<CalculationDetailsGroupMap> DetailsForQuantities { get; set; }
    }
}
