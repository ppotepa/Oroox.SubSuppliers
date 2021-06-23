using MediatR;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Services.Mailing;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Events
{
    public class SendNewSharedJobNotificationEvent : IEvent<CreateNewSharedJobRequest>
    {
        private readonly IMailingService mailingService;

        public SendNewSharedJobNotificationEvent(IMailingService mailingService)
        {
            this.mailingService = mailingService;
        }

        public async Task<Unit> Handle(CreateNewSharedJobRequest request, CancellationToken cancelationToken)
        {
            return await this.mailingService.SendNewSharedJobNotification
            (
                    customer: request.Customer,
                    job: request.Job,
                    sharedJob: request.SharedJob,
                    cancelationToken: cancelationToken
            );
        }
       

    }
}
