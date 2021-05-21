using Oroox.SubSuppliers.Processors;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.Processors
{
    internal class UserNameProcessor : IPreRequestProcessor<CreateCustomerRequest>
    {
        public void Process(CreateCustomerRequest request, CancellationToken cancelationToken)
        {
            if (request.Customer.CompanyName.Contains('a'))
            {
                request.Customer.CompanyName = "TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST";
            }

            if (request.Customer.CompanyName.Length > 5)
            {
                request.Customer.CompanyName = request.Customer.CompanyName.Substring(0, 5);
            }
        }
    }
}
