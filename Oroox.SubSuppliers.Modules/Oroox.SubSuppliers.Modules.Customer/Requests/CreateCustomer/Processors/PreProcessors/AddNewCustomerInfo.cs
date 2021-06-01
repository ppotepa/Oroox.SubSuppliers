using Oroox.SubSuppliers.Processors;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.Processors
{
    public class AddNewCustomerInfo : IPreRequestProcessor<CreateCustomerRequest>
    {
        public void Process(CreateCustomerRequest request, CancellationToken cancelationToken)
        {
            if (request.Customer.CustomerAdditionalInfo == null) 
            {
                request.Customer.CustomerAdditionalInfo = new Domain.Entities.CustomerAdditionalInfo();
            }
        }
    }
}
