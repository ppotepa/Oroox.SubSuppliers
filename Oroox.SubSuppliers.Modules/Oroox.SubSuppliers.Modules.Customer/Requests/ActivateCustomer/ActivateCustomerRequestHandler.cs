using MediatR;
using Oroox.SubSuppliers.Modules.Customers.Requests.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests
{
    public class ActivateCustomerRequestHandler : IRequestHandler<ActivateCustomerRequest, ActivateCustomerRequestResponse>
    {
        public Task<ActivateCustomerRequestResponse> Handle(ActivateCustomerRequest request, CancellationToken cancellationToken)
        {
            if (request.Registration != null)
            {
                request.Registration.Customer.IsActive = true;
                return Task.FromResult
                (
                    new ActivateCustomerRequestResponse 
                    {
                        RedirectUrl = "/" 
                    }
                );               
            }
            return Task.FromResult
            (
                new ActivateCustomerRequestResponse 
                {
                    RedirectUrl = string.Empty 
                }
            );
        }
    }
}
