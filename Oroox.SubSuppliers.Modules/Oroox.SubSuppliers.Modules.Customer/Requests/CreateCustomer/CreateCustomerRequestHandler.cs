using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.User.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User.Requests.Customer
{
    public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomer, CreateCustomerRequestResponse>
    {
        private readonly IApplicationContext context;

        public CreateCustomerRequestHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public async Task<CreateCustomerRequestResponse> Handle(CreateCustomer request, CancellationToken cancellationToken)
        {
            EntityEntry<Domain.Entities.Customer> entry = await this.context.Customers.AddAsync(request.Customer, cancellationToken);
            return new CreateCustomerRequestResponse
            {
                Response = $"CustomerId : {entry.Entity.Id}"
            };
        }
    }
}
