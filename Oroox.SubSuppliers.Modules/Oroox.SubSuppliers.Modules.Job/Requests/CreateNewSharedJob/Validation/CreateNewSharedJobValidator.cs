using FluentValidation;
using Oroox.SubSuppliers.Domain.Context;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Validation
{
    public class CreateNewSharedJobValidator : AbstractValidator<CreateNewSharedJobRequest>
    {
        private readonly IApplicationContext context;
        public CreateNewSharedJobValidator(IApplicationContext context)
        {
            this.context = context;

            RuleFor(request => request.CustomerId).NotNull().NotEmpty().WithMessage("Invalid CustomerId");
            RuleFor(request => request.JobId).NotNull().NotEmpty().WithMessage("Invalid JobId");

            RuleFor(request => request.CustomerId).Must(ExistCustomer).WithMessage(request => $"Customer with id {request.CustomerId} does not exist.");
            RuleFor(request => request.JobId).Must(ExistJob).WithMessage(request => $"Job with id {request.Job} does not exist.");
        }

        private bool ExistCustomer(Guid customerId) 
            => this.context.Customers.Any(customer => customer.Id == customerId);
       

        private bool ExistJob(Guid jobid)
            => this.context.Jobs.Any(job => job.Id == jobid);

    }
}
