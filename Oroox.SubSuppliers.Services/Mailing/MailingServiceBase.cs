using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public abstract class MailingServiceBase : IMailingService
    {
        private readonly ILogger logger;
        private readonly SmtpClient client;

        protected MailingServiceBase(ILogger logger, SmtpClient client)
        {
            this.logger = logger;
            this.client = client;
        }

        public abstract bool SendCustomerRegistrationEmail(Customer customer);
    }
}
