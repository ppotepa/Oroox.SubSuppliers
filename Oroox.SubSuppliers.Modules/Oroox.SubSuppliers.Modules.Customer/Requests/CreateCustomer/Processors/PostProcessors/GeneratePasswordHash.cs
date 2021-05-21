using Oroox.SubSuppliers.Processors;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.Processors
{
    public class GeneratePasswordHash : IPostRequestProcessor<CreateCustomerRequest>
    {
        public void Process(CreateCustomerRequest request, CancellationToken cancelationToken)
            => request.Customer.PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Customer.Password);
    }
}
