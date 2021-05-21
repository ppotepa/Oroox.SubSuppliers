using MailKit.Net.Smtp;
using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Utilities;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    //orooxlab
    //grappaice69
    public abstract class MailingServiceBase : Disposable, IMailingService
    {
        protected readonly ILogger logger;
        protected ISmtpClient client;

        protected MailingServiceBase(ILogger logger)
        {
            this.logger = logger;
        }

        public abstract Task ConnectAndSend(MimeMessage message, CancellationToken cancelationToken);
        public abstract Task SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken, string text = null);
    }
}
