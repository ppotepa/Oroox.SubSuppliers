using FluentValidation;
using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Extensions.Configuration;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Validation
{
    public class AddSharedJobCommentAttachmentValidator : AbstractValidator<AddSharedJobCommentRequest>
    {
        private readonly IConfiguration configuration;
        private readonly IApplicationContext context;

        private readonly OxSuppliersEnvironmentVariables environmentVariables;
        private readonly OxSubSuppliersApplicationSettings oxConfig;

        private readonly int maxAttachmentFileSize;
        private readonly string[] validExtensions;
        
        private const int MINIMUM_FILE_LENGTH = 5;
        private const int MAXIMUM_FILE_LENGTH = 100;

        public AddSharedJobCommentAttachmentValidator(IConfiguration configuration, IApplicationContext context)
        {
            this.CascadeMode = CascadeMode.Stop;

            this.oxConfig = configuration.GetApplicationSettings();
            this.environmentVariables = configuration.GetEnvironmentVariables();
            this.context = context;           
            this.configuration = configuration;

            OxConfig appConfig = this.environmentVariables.IsDevelopment ? this.oxConfig.Development : this.oxConfig.Production;

            this.validExtensions = appConfig.Other.AttachmentSettings.SupportedExtensions;
            this.maxAttachmentFileSize = appConfig.Other.AttachmentSettings.MaxAttachmentFileSize;

            When(request => request.Comment.Attachment != null, () => 
            {
                RuleFor(request => request.Comment.Attachment.FileName)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Invalid filename.");

                RuleFor(request => request.Comment.Attachment.FileName)
                    .MinimumLength(MINIMUM_FILE_LENGTH)
                    .WithMessage($"File name exceeds {MINIMUM_FILE_LENGTH} characters.");

                RuleFor(request => request.Comment.Attachment.FileName)
                   .MaximumLength(MAXIMUM_FILE_LENGTH)
                   .WithMessage($"File name exceeds {MAXIMUM_FILE_LENGTH} characters.");

                RuleFor(request => request.Comment.Attachment.Content)
                    .Must(BeSmallerThan1MB)
                    .WithMessage($"File is too big. Maximum file size is {appConfig.Other.AttachmentSettings.MaxAttachmentFileSize}");

                RuleFor(request => request.Comment.Attachment.Extension)
                    .Must(BeValid)
                    .WithMessage($"Unsupported attachment Type. Supported file types are : {string.Join(", ", validExtensions)}");
            });
        }

        private bool BeSmallerThan1MB(byte[] byteArray) 
            => byteArray.Length < this.maxAttachmentFileSize;

        private bool BeValid(string extension) 
            => validExtensions.Contains(extension);
        
    }
}
