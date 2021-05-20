using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.User.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer
{
    public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomer, CreateCustomerRequestResponse>
    {
        private readonly IApplicationContext applicationContext;

        public CreateCustomerRequestHandler(IApplicationContext context)
        {
            this.applicationContext = context;
        }

        public async Task<CreateCustomerRequestResponse> Handle(CreateCustomer request, CancellationToken cancellationToken)
        {
            EntityEntry<Customer> customerId = await this.applicationContext.Customers.AddAsync(request.Customer);
            applicationContext.SaveChanges();
            return new CreateCustomerRequestResponse
            {
                Response = $"CustomerId : {customerId.Entity.Id}"
            };
        }
    }
}
