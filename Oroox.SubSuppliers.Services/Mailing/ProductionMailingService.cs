using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public class ProductionMailingService : MailingServiceBase
    {
        public ProductionMailingService(ILogger logger, SmtpClient client) : base(logger, client) { }

        public override bool SendCustomerRegistrationEmail(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
