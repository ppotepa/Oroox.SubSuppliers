using FluentValidation;
using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Validation
{
    public class AddSharedJobCommentAttachmentValidator : AbstractValidator<AddSharedJobCommentRequest>
    {
        private readonly IApplicationContext context;
        private readonly string[] validExtensions = new[] { "pdf", "png", "txt", "doc", "docx", "jpg", "jpeg" };
        private readonly IConfiguration configuration;

        private const int MAX_FILE_SIZE_IN_KB = 1024 * 1024;

        public AddSharedJobCommentAttachmentValidator(IConfiguration configuration, IApplicationContext context)
        {
            this.CascadeMode = CascadeMode.Stop;

            this.context = context;           
            this.configuration = configuration;

            When(request => request.Comment.Attachment != null, () => 
            {
                RuleFor(request => request.Comment.Attachment.FileName)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Invald filename.");

                RuleFor(request => request.Comment.Attachment.FileName)
                    .MaximumLength(100)
                    .WithMessage("File name exceeds 100 characters.");

                RuleFor(request => request.Comment.Attachment.FileName)
                   .MaximumLength(100)
                   .WithMessage("File name exceeds 100 characters.");

                RuleFor(request => request.Comment.Attachment.Content)
                    .Must(BeSmallerThan1MB)
                    .WithMessage($"File is too big. Maximum file size is {MAX_FILE_SIZE_IN_KB}");

                RuleFor(request => request.Comment.Attachment.Extension)
                    .Must(BeValid)
                    .WithMessage($"Unsupported attachment Type. Supported file types are : {string.Join(", ", validExtensions)}");
            });
        }

        private bool BeSmallerThan1MB(byte[] byteArray) 
            => byteArray.Length < MAX_FILE_SIZE_IN_KB;

        private bool BeValid(string extension) 
            => validExtensions.Contains(extension);
        
    }
}
