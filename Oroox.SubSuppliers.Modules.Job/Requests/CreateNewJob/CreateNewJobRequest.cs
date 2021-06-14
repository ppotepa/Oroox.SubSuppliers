using MediatR;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob
{
    public class CreateNewJobRequest : IRequest<CreateNewJobRequestResponse>
    {
        public Guid CalculationId { get; set; }
    }
}
