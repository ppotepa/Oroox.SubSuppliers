using MediatR;
using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomerRequest.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer
{
    public class ActivateCustomerRequestHandler : IRequestHandler<ActivateCustomerRequest, ActivateCustomerRequestResponse>
    {
        private readonly OxSuppliersEnvironmentVariables environmentVariables;
        public ActivateCustomerRequestHandler(IConfiguration configuration)
        {
            this.environmentVariables = configuration.GetEnvironmentVariables();
        }

        public Task<ActivateCustomerRequestResponse> Handle(ActivateCustomerRequest request, CancellationToken cancellationToken)
        {
            if (request.Registration != null && request.Registration.Customer.IsActive is false)
            {
                request.Registration.Customer.IsActive = true;

                return Task.FromResult
                (
                    new ActivateCustomerRequestResponse
                    {
                        RedirectUrl = environmentVariables.IsDevelopment ? "http://localhost:4200" : "/"
                    }
                );
            }

            return Task.FromResult
            (
                new ActivateCustomerRequestResponse 
                {
                   Response = "What are you doing here ? 🤔🤔🤔"
                }
            );
        }
    }
}
