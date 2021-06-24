using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Validation
{
    public class AddSharedJobCommentValidator : AbstractValidator<AddSharedJobCommentRequest>
    {
        private readonly IApplicationContext context;
        public AddSharedJobCommentValidator(IApplicationContext context)
        {
            this.context = context;

            RuleFor(request => request.SharedJobId).Must(NotBeDefault).WithMessage("Invalid shared job id.");
            RuleFor(request => request.SharedJobId).Must(Exist).WithMessage(x => $"Shared job with id {x.SharedJobId} does not exist.");            
        }

        private bool Exist(Guid sharedJobId)
            => this.context.SharedJobs.Any(x => x.Id == sharedJobId);


        private bool NotBeDefault(Guid sharedJobId) 
            => sharedJobId != default;
        
    }
}
