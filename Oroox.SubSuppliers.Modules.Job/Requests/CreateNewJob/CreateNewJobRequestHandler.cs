using MediatR;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Response
{
    public class CreateNewJobRequestHandler : IRequestHandler<CreateNewJobRequest, CreateNewJobRequestResponse>
    {
        public async Task<CreateNewJobRequestResponse> Handle(CreateNewJobRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new CreateNewJobRequestResponse());
        }
    }
}
