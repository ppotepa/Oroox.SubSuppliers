using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.Model;
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
            EntityEntry<Customer> entry = await this.context.Customers.AddAsync(request.Customer, cancellationToken);

            return new CreateCustomerRequestResponse
            {
                ResponseText = $"CustomerId : {entry.Entity.Id}",
                Result = new CreateCustomerRequestResponseModel
                {
                    Customer = new CustomerCreatedDTO
                    {
                        Id = entry.Entity.Id
                    }
                }
            };
        }
    }
}
