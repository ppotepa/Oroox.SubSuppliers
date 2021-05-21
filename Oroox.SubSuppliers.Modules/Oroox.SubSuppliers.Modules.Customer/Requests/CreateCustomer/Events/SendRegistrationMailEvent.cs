using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Modules.Customers.Requests;
using Oroox.SubSuppliers.Services.Mailing;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Events
{
    class SendRegistrationMailEvent : IEvent<CreateCustomerRequest>
    {
        private readonly IMailingService mailingService;
   
        public SendRegistrationMailEvent(IMailingService mailingService)
        {
            this.mailingService = mailingService;
        }

        public async void Handle(CreateCustomerRequest request, CancellationToken cancelationToken) 
        {
            await this.mailingService.SendNewCustomerRegistrationMessage(request.Customer, cancelationToken);
        }
    }
}
