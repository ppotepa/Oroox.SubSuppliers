using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests
{
    public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerRequestResponse>
    {
        private readonly IApplicationContext context;

        public CreateCustomerRequestHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public async Task<CreateCustomerRequestResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            EntityEntry<Domain.Entities.Customer> entry = await this.context.Customers.AddAsync(request.Customer, cancellationToken);
            return new CreateCustomerRequestResponse
            {
                Response = $"CustomerId : {entry.Entity.Id}"
            };
        }
    }
}
