using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.Validators
{
    /// <summary>
    /// Validates SharedJobCommentRequest
    /// </summary>
    public class UpdateSharedJobCommentRequestValidator : AbstractValidator<UpdateSharedJobCommentModel>
    {
        private readonly IApplicationContext context;
        private readonly HttpContext httpContext;

        public UpdateSharedJobCommentRequestValidator(IHttpContextAccessor accessor, IApplicationContext context)
        {
            this.CascadeMode = CascadeMode.Stop;

            this.context = context;
            this.httpContext = accessor.HttpContext;

            RuleFor(request => request.Comment).NotNull().WithMessage("Please specify comment to be updated.");
            RuleFor(request => request.Comment.Id)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Please specify CommentId");

            RuleFor(request => request.Comment.Id)
                .Must(Exist)
                .WithMessage(request => $"Comment with id {request.Comment.Id} does not exist");

        }

        private bool Exist(Guid commentId) 
            => this.context.Comments.AsNoTracking().Any(comment => comment.Id == commentId);
        
    }
}
