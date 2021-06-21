using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.RequestsCreateNewJob.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob
{
    public class CreateNewJobRequest : IRequest<CreateNewJobRequestResponse> 
    {
        public Guid QuoteId { get; set; }
        public Guid CustomerId { get; set; }
        public Job Job { get; set; }
    }
}
