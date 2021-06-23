using System;
using System.Collections.Generic;
using System.Linq;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class SharedJob : Entity
    {
        public Guid JobId { get; set; }
        public virtual Job Job { get; set; }
        
        public virtual Customer Customer { get; set;}
        public Guid CustomerId { get; set; }

        public virtual List<SharedJobQuestion> Questions { get; set; }

        public virtual SharedJobStatusType SharedJobStatusType { get; set; }
        public Guid SharedJobStatusTypeId { get; set; }

        public bool HasAnyUnansweredQuestions 
            => Questions.Any(question => question.IsAnswered is false);

        public virtual List<Comment> Comments { get; set; }
    }
}
