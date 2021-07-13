using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AssignJobToCustomer
{
    public class AssignJobToCustomerRequestHandler : IRequestHandler<AssignJobToCustomerRequest, AssignJobToCustomerRequestResponse>
    {
        public Task<AssignJobToCustomerRequestResponse> Handle(AssignJobToCustomerRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
