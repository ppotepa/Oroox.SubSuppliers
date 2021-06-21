using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using Serilog;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob.Validation
{
    public class CreateNewJobRequestValidator : AbstractValidator<CreateNewJobRequest>
    {
        private readonly IApplicationContext context;
        private readonly ILogger logger;

        public CreateNewJobRequestValidator(ILogger logger, IApplicationContext context)
        {
            this.context = context;
            this.logger = logger;

            RuleFor(r => r.QuoteId).Must(NotBeDefault).WithMessage("Invalid quoteId");
        }

        private bool NotBeDefault(Guid quoteId)
            => quoteId != default;

    }
}
