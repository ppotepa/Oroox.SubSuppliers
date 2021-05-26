using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Customers.Requests.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests
{
    public class ActivateCustomerRequestHandler : IRequestHandler<ActivateCustomerRequest, ActivateCustomerRequestResponse>
    {
        public Task<ActivateCustomerRequestResponse> Handle(ActivateCustomerRequest request, CancellationToken cancellationToken)
        {
            return request.Registration is null ?
                Task.FromResult(new ActivateCustomerRequestResponse() { Redirect = false }) :
                Task.FromResult(new ActivateCustomerRequestResponse() { Redirect = true });
        }
    }
}
