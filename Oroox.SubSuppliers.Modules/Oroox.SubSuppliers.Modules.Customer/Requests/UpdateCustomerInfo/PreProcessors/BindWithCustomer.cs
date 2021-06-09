using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.PreProcessors
{
    public class BindWithCustomer : IRequestPreProcessor<UpdateCustomerAdditionalInfoRequest>
    {
        private readonly IApplicationContext context;
        public BindWithCustomer(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(UpdateCustomerAdditionalInfoRequest request, CancellationToken cancellationToken)
        {
            request.Customer = this.context.Customers
                .GetById(request.CustomerAdditionalInfo.CustomerId)                
                .FirstOrDefault();

            return Unit.Task;
        }
    }
}
