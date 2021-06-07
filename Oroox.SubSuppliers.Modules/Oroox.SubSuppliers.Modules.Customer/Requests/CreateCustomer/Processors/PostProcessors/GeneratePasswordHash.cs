using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.PostProcessors
{
    public class GeneratePasswordHash : IRequestPostProcessor<CreateCustomerRequest, CreateCustomerRequestResponse>
    {
        public Task Process(CreateCustomerRequest request, CreateCustomerRequestResponse response, CancellationToken cancellationToken)
        {
            request.Customer.PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Customer.Password);
            return Unit.Task;
        }
    }
}
