using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Processors;
using System.Linq;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer.PreProcessor
{
    public class BindRegistration : IPreRequestProcessor<ActivateCustomerRequest>
    {
        private readonly IApplicationContext context;
        public BindRegistration(IApplicationContext context)
        {
            this.context = context;
        }

        public void Process(ActivateCustomerRequest request, CancellationToken cancelationToken)
        {
            Domain.Entities.Registration targetRegistration = context
                .Registrations
                .AsQueryable()
                .Where(x => x.ActivationCode == request.Registration.ActivationCode)
                .FirstOrDefault();

                request.Registration = targetRegistration;
          
        }
    }
}
