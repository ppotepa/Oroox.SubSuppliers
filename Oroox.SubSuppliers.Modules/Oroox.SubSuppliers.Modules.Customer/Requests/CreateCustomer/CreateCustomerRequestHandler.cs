using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.User.Responses;
using Oroox.SubSuppliers.Services.Mailing;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer
{
    public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomer, CreateCustomerRequestResponse>
    {
        private readonly IApplicationContext context;
        private readonly IMailingService mailingService;

        public CreateCustomerRequestHandler(IApplicationContext context, IMailingService mailingService)
        {
            this.context = context;
            this.mailingService = mailingService;
        }

        public async Task<CreateCustomerRequestResponse> Handle(CreateCustomer request, CancellationToken cancellationToken)
        {
            EntityEntry<Domain.Entities.Customer> entry = await this.context.Customers.AddAsync(request.Customer, cancellationToken);
            await this.mailingService.SendNewCustomerRegistrationMessage(request.Customer);

            return new CreateCustomerRequestResponse
            {
                Response = $"CustomerId : {entry.Entity.Id}"
            };
        }
    }
}
