using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Validation
{
    public class AddSharedJobCommentValidator : AbstractValidator<AddSharedJobCommentRequest>
    {
        private readonly IApplicationContext context;
        private const int MINIMUM_COMMENT_LENGTH = 10;
        private const int MAXIMUM_COMMENT_LENGTH = 5000;
        public AddSharedJobCommentValidator(IApplicationContext context)
        {
            this.context = context;

            RuleFor(request => request.SharedJobId).Must(NotBeDefault).WithMessage("Invalid shared job id.");
            RuleFor(request => request.SharedJobId).Must(Exist).WithMessage(x => $"Shared job with id {x.SharedJobId} does not exist.");
            RuleFor(request => request.Comment).NotNull().WithMessage("Comment was empty.");

            When(request => request.Comment != null, ValidateComment);
        }

        private void ValidateComment()
        {
            RuleFor(request => request.Comment.Text).NotEmpty().WithMessage("Comment text cannot be empty.");
            RuleFor(request => request.Comment.Text).MinimumLength(MINIMUM_COMMENT_LENGTH).WithMessage($"Comment must have at least {MINIMUM_COMMENT_LENGTH} of lenght.");
            RuleFor(request => request.Comment.Text).MaximumLength(MAXIMUM_COMMENT_LENGTH).WithMessage($"Comment must have {MAXIMUM_COMMENT_LENGTH} of lenght at most.");

        }

        private bool Exist(Guid sharedJobId)
            => this.context.SharedJobs.AsNoTracking().Any(x => x.Id == sharedJobId);


        private bool NotBeDefault(Guid sharedJobId) 
            => sharedJobId != default;
        
    }
}
