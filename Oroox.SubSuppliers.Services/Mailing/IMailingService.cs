using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public interface IMailingService
    {
        public Task SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken);
        public Task ConnectAndSend(MimeMessage message, CancellationToken cancelationToken);
    }
}