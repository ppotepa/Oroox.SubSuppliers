using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Oroox.SubSuppliers.Services.Mailing;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customer.Events
{
    class SendRegistrationMailEvent : IEvent<CreateCustomer>
    {
        private readonly IMailingService mailingService;
   
        public SendRegistrationMailEvent(IMailingService mailingService)
        {
            this.mailingService = mailingService;
        }

        public async void Handle(CreateCustomer request, CancellationToken cancelationToken) 
        {
            await this.mailingService.SendNewCustomerRegistrationMessage(request.Customer, cancelationToken);
        }
    }
}
