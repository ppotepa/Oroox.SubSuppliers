using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob
{
    public class CreateNewSharedJobRequest : IRequest<CreateNewSharedJobRequestResponse>
    {
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public SharedJob SharedJob { get; set; }
    }
}
