using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Domain.Context;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer.PreProcessor
{
    public class BindRegistration : IRequestPreProcessor<ActivateCustomerRequest>
    {
        private readonly IApplicationContext context;
        public BindRegistration(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Process(ActivateCustomerRequest request, CancellationToken cancellationToken)
        {
            request.Registration = context
                .Registrations
                .AsQueryable()                
                .FirstOrDefault(x => x.ActivationCode == request.Registration.ActivationCode);

            return Unit.Task;
        }
    }
}
