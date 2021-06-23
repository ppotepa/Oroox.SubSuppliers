using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Event;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob.Events.NewJobCreated
{
    public class NewJobCreatedEvent : IEvent<CreateNewJobRequest>
    {
        private readonly IApplicationContext context;

        public NewJobCreatedEvent(IApplicationContext context)
        {
            this.context = context;
        }

        public Task<Unit> Handle(CreateNewJobRequest request, CancellationToken cancelationToken)
        {
            if (request.Job is null)
                throw new InvalidOperationException("Something went wrong");

            IQueryable<Domain.Entities.Customer> matchingCustomers = this.context
                                            .Customers
                                            .AsQueryable()
                                            .Where(customer => customer.Machines.Any(machine => machine.MatchJob(request.Job)));

            return Unit.Task;
        }
    }
}
