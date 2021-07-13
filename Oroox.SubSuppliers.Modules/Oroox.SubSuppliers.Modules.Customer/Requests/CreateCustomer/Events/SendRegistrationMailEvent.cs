using MediatR;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Services.Mailing;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.Events
{
    public class SendRegistrationMailEvent : IEvent<CreateCustomerRequest>
    {
        private readonly IMailingService mailingService;
   
        public SendRegistrationMailEvent(IMailingService mailingService)
        {
            this.mailingService = mailingService;
        }

        public async Task<Unit> Handle(CreateCustomerRequest request, CancellationToken cancelationToken) 
        {
            Unit result = await this.mailingService.SendNewCustomerRegistrationMessage(request.Customer, cancelationToken);
            return result;
        }
    }
}
