using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.PreProcessor
{
    public class BindWithCustomer : IRequestPreProcessor<AddCustomerMillingMachineRequest>
    {
        private readonly IApplicationContext context;
        public BindWithCustomer(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(AddCustomerMillingMachineRequest request, CancellationToken cancellationToken)
        {
            request.Customer = this.context.Customers.GetById(request.CustomerId).FirstOrDefault();
            return Unit.Task;
        }
    }
}
