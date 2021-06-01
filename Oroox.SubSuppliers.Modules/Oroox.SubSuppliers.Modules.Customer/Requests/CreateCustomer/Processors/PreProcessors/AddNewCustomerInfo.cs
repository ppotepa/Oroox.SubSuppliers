using MediatR;
using MediatR.Pipeline;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.Processors
{
    public class AddNewCustomerInfo : IRequestPreProcessor<CreateCustomerRequest>
    {
        public Task Process(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            if (request.Customer.CustomerAdditionalInfo == null)
            {
                request.Customer.CustomerAdditionalInfo = new Domain.Entities.CustomerAdditionalInfo();
            }

            return Unit.Task;
        }
    }
}
