using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo
{
    internal class UpdateCustomerAdditionalInfoRequestHandler : IRequestHandler<UpdateCustomerAdditionalInfoRequest, UpdateCustomerAdditionalInfoRequestResponse>
    {
        private readonly IApplicationContext context;
        public UpdateCustomerAdditionalInfoRequestHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public Task<UpdateCustomerAdditionalInfoRequestResponse> Handle(UpdateCustomerAdditionalInfoRequest request, CancellationToken cancellationToken)
        {
            UpdateCustomerAdditionalInfoRequestResponse response = default;

            if (request.Customer.CustomerAdditionalInfo is null)
            {
                request.Customer.CustomerAdditionalInfo = request.CustomerAdditionalInfo;
                response = new UpdateCustomerAdditionalInfoRequestResponse
                {
                    ResponseText = $"Added new Customer Info. Id : {request.CustomerAdditionalInfo.Id}",
                };
            }
            else 
            {
                request.Customer.CustomerAdditionalInfo.Update(request.CustomerAdditionalInfo);
                response = new UpdateCustomerAdditionalInfoRequestResponse
                {
                    ResponseText = $"Updated Customer Info. Id : {request.CustomerAdditionalInfo.Id}",
                };
            }

            return Task.FromResult(response);
        }
    }
}
