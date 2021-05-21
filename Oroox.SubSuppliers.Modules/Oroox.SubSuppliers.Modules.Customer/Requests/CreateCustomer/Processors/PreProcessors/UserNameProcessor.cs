using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Oroox.SubSuppliers.RequestHandlers;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customer.Requests.Processors
{
    internal class UserNameProcessor : IPreRequestProcessor<CreateCustomer>
    {
        public void Process(CreateCustomer request, CancellationToken cancelationToken)
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
}i
