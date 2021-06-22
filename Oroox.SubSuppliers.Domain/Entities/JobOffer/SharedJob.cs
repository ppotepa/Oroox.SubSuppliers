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

    public class Comment : Entity
    {
        public virtual Attachment Attachment { get; set; }
        public Guid AttachmentId { get; set; }
        public string Text { get; set; }
    }

    public class SharedJobQuestion : Entity
    {
        //public Entity From { get; set; }
        //public Entity To { get; set; }
        public virtual SharedJob JobOffer { get; set; }
        public Guid JobOfferId { get; set; }
        public bool IsAnswered { get; set; }
    }

    public enum SharedJobStatusTypeEnum
    {
        Accepted,
        Rejected,
        UnansweredQuestions
    }

    public enum SharedJobRejectionReasonTypeEnum
    {
        NoCapacity,
        MaterialNotAvailable,
        LeadTimeTooShort,
        NotFeasible
    }


    public class SharedJobStatusType : EnumerationEntity<SharedJobStatusTypeEnum>
    {
    }

    public class SharedJobRejectionReasonType : EnumerationEntity<SharedJobRejectionReasonTypeEnum>
    {
    }
}
