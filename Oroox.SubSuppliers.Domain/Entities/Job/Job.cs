using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Job : Entity
    {
        public virtual CalculationDetailsForQuote CalculationDetailsForQuote { get; set; }
        public Guid? CalculationDetailsForQuoteId { get; set; }
        public virtual Customer Customer { get; set; }
        public Guid? CustomerId { get; set; }
        public virtual Quote Quote { get; set; }
        public Guid? QuoteId { get; set; }
        public virtual List<SharedJob> SharedJobs { get; set; }        
    }
}
