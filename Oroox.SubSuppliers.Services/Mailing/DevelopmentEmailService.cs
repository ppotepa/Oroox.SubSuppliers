using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public class DevelopmentEmailService : MailingServiceBase
    {
        public DevelopmentEmailService(ILogger logger, SmtpClient client) : base(logger, client) { }

        public override bool SendCustomerRegistrationEmail(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
