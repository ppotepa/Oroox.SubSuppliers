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

        public async Task<UpdateCustomerAdditionalInfoRequestResponse> Handle(UpdateCustomerAdditionalInfoRequest request, CancellationToken cancellationToken)
        {
            return new UpdateCustomerAdditionalInfoRequestResponse
            {
                Result = null
            };
        }
    }
}
