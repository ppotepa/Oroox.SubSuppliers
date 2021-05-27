using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Extensions;
using Oroox.SubSuppliers.Processors;
using System.Linq;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.PreProcessors
{
    public class BindWithCustomer : IPreRequestProcessor<UpdateCustomerAdditionalInfoRequest>
    {
        private readonly IApplicationContext context;
        public BindWithCustomer(IApplicationContext context)
        {
            this.context = context;
        }

        public void Process(UpdateCustomerAdditionalInfoRequest request, CancellationToken cancelationToken)
        {
            request.Customer = this.context.Customers
                .GetById(request.CustomerAdditionalInfo.CustomerId)
                .Include(nameof(request.Customer.CustomerAdditionalInfo))
                .FirstOrDefault();
           
        }
    }
}
