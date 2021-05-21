using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Oroox.SubSuppliers.RequestHandlers;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customer.Requests.Processors
{
    public class GeneratePasswordHash : IPostRequestProcessor<CreateCustomer>
    {
        public void Process(CreateCustomer request, CancellationToken cancelationToken)
            => request.Customer.PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Customer.Password);
    }
}
