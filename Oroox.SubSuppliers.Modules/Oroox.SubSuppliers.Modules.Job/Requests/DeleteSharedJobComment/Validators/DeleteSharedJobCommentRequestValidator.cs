using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment.Validators
{
    /// <summary>
    /// Validates DeleteSharedJobCommentRequest
    /// </summary>
    public class DeleteSharedJobCommentRequestValidator : AbstractValidator<DeleteSharedJobCommentRequest>
    {
        private readonly IApplicationContext context;        

        public DeleteSharedJobCommentRequestValidator(IApplicationContext context)
        {
            this.CascadeMode = CascadeMode.Stop;
            this.context = context;

            RuleFor(request => request.CommentId).NotEmpty().NotNull().WithMessage("Please provide valid CommendId");
            RuleFor(request => request.SharedJobId).NotEmpty().NotNull().WithMessage("Please provide valid SharedJobId");

            RuleFor(request => request).Must(CommentMustExist).WithMessage(request => $"Comment with id {request.CommentId} does not exist.");
        }

        private bool CommentMustExist(DeleteSharedJobCommentRequest request)
        {
            return this.context.Comments.AsNoTracking().Any(comment => comment.Id == request.CommentId);
        }
    }
}
