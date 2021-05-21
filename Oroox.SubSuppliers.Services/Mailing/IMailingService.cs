using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public interface IMailingService
    {
        public Task SendNewCustomerRegistrationMessage(Customer customer);
        public Task ConnectAndSend(MimeMessage message);
    }
}