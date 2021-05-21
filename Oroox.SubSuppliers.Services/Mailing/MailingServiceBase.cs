using MailKit.Net.Smtp;
using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using Serilog;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    //orooxlab
    //grappaice69
    public abstract class MailingServiceBase : IMailingService
    {
        protected readonly ILogger logger;
        protected readonly ISmtpClient client;

        protected MailingServiceBase(ILogger logger, ISmtpClient client)
        {
            this.logger = logger;
            this.client = client;
        }

        public abstract Task ConnectAndSend(MimeMessage message);
        public abstract Task SendNewCustomerRegistrationMessage(Customer customer);
    }
}
