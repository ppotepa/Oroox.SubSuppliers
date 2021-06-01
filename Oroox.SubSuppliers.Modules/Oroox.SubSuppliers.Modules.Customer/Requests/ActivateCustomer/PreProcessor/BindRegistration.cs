using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
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
            Domain.Entities.Registration targetRegistration = context
                .Registrations
                .AsQueryable()
                .Include(nameof(request.Registration.Customer))
                .FirstOrDefault(x => x.ActivationCode == request.Registration.ActivationCode);

            request.Registration = targetRegistration;

            return Unit.Task;
        }
    }
}
