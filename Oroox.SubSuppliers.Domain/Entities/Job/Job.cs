using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class Job : Entity
    {
        public virtual Customer Customer { get; set; }
        public Guid? CustomerId { get; set; }
        public virtual CalculationDetailsForQuote CalculationDetailsForQuote { get; set; }
        public virtual Quote Quote { get; set; }
        public Guid QuoteId { get; set; }
    }
}
