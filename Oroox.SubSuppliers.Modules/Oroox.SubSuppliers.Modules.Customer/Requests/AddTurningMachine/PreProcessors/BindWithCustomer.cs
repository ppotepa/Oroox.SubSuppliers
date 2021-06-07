using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine.PreProcessors
{
    public class BindWithCustomer : IRequestPreProcessor<AddTurningMachineRequest>
    {
        private readonly IApplicationContext context;
        public BindWithCustomer(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(AddTurningMachineRequest request, CancellationToken cancellationToken)
        {
            request.Customer = this.context.Customers.GetById(request.TurningMachine.CustomerId).FirstOrDefault();
            return Unit.Task;
        }
    }
}
